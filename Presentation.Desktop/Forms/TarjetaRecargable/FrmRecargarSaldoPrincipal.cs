using SGA.Application.Dtos.Pago;
using SGA.Application.Dtos.TarjetaRecargable;
using SGA.Presentation.Desktop.Interfaces;

namespace SGA.Presentation.Desktop.Forms
{
    public partial class FrmRecargarSaldoPrincipal : Form
    {
        private readonly ITarjetaRecargableApiService _apiService;
        private readonly IPagoApiService _pagoApiService;

        private TarjetaRecargableDto? _tarjetaActual;

        public FrmRecargarSaldoPrincipal(
            ITarjetaRecargableApiService apiService,
            IPagoApiService pagoApiService)
        {
            InitializeComponent();

            _apiService = apiService;
            _pagoApiService = pagoApiService;

            Load += FrmRecargarSaldoPrincipal_Load;
            btnBuscar.Click += btnBuscar_Click;
            btnRecargar.Click += btnRecargar_Click;
        }


        private void FrmRecargarSaldoPrincipal_Load(
            object? sender,
            EventArgs e)
        {
            cmbTipoPago.Items.Clear();

            cmbTipoPago.Items.Add("Efectivo");
            cmbTipoPago.Items.Add("Tarjeta");
            cmbTipoPago.Items.Add("Transferencia");

            cmbTipoPago.SelectedIndex = 0;

            panelTarjeta.Visible = false;

            btnRecargar.Enabled = false;

            lblSaldo.Text = "RD$ 0.00";
            lblMatricula.Text = "-";

            ConfigurarHistorial();
        }

        private async void btnBuscar_Click(
            object? sender,
            EventArgs e)
        {
            string matricula = txtMatricula.Text.Trim();

            if (string.IsNullOrWhiteSpace(matricula))
            {
                MessageBox.Show(
                    "Ingrese una matrícula.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMatricula.Focus();

                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;

                _tarjetaActual =
                    await _apiService.GetByMatriculaAsync(matricula);

                if (_tarjetaActual == null)
                {
                    MessageBox.Show(
                        "Usuario no encontrado o no tiene una tarjeta recargable.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Limpiar();

                    return;
                }

                panelTarjeta.Visible = true;

                lblMatricula.Text =
                    _tarjetaActual.IdentificadorInstitucional;

                lblSaldo.Text =
                    $"RD$ {_tarjetaActual.Saldo:N2}";

                btnRecargar.Enabled = true;

                await CargarHistorial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo buscar el usuario.\n\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private async void btnRecargar_Click(
            object? sender,
            EventArgs e)
        {
            if (_tarjetaActual == null)
            {
                MessageBox.Show(
                    "Debe buscar un usuario antes de realizar una recarga.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (!decimal.TryParse(
                    txtMonto.Text.Trim(),
                    out decimal monto))
            {
                MessageBox.Show(
                    "Ingrese un monto válido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMonto.Focus();

                return;
            }

            if (monto <= 0)
            {
                MessageBox.Show(
                    "El monto debe ser mayor que cero.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMonto.Focus();

                return;
            }

            if (cmbTipoPago.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(cmbTipoPago.Text))
            {
                MessageBox.Show(
                    "Seleccione el tipo de pago.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbTipoPago.Focus();

                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;

                var dto = new RecargarSaldoDto
                {
                    UsuarioId = _tarjetaActual.UsuarioId,
                    Monto = monto,
                    TipoPago = cmbTipoPago.Text
                };

                bool ok =
                    await _apiService.RecargarSaldoAsync(dto);

                if (!ok)
                {
                    MessageBox.Show(
                        "No fue posible realizar la recarga.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                _tarjetaActual =
                    await _apiService.GetByMatriculaAsync(
                        _tarjetaActual.IdentificadorInstitucional);

                if (_tarjetaActual != null)
                {
                    lblSaldo.Text =
                        $"RD$ {_tarjetaActual.Saldo:N2}";
                }

                await CargarHistorial();

                MessageBox.Show(
                    $"La recarga de RD$ {monto:N2} fue realizada correctamente.",
                    "Recarga exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtMonto.Clear();

                cmbTipoPago.SelectedIndex = 0;

                txtMonto.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No fue posible realizar la recarga.\n\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }


        private async Task CargarHistorial()
        {
            if (_tarjetaActual == null)
                return;

            try
            {
                var recargas =
                    await _pagoApiService
                        .GetRecargasByUsuarioAsync(
                            _tarjetaActual.UsuarioId);

                dgvHistorial.DataSource = null;
                dgvHistorial.DataSource = recargas;

                ConfigurarHistorial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo cargar el historial de recargas.\n\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void ConfigurarHistorial()
        {
            if (dgvHistorial == null)
                return;

            dgvHistorial.AutoGenerateColumns = true;


            if (dgvHistorial.Columns["Id"] != null)
                dgvHistorial.Columns["Id"].Visible = false;

            if (dgvHistorial.Columns["UsuarioId"] != null)
                dgvHistorial.Columns["UsuarioId"].Visible = false;

            if (dgvHistorial.Columns["TipoTicket"] != null)
                dgvHistorial.Columns["TipoTicket"].Visible = false;

            if (dgvHistorial.Columns["RutaEntradaId"] != null)
                dgvHistorial.Columns["RutaEntradaId"].Visible = false;

            if (dgvHistorial.Columns["HorarioEntradaId"] != null)
                dgvHistorial.Columns["HorarioEntradaId"].Visible = false;

            if (dgvHistorial.Columns["ParadaEntradaId"] != null)
                dgvHistorial.Columns["ParadaEntradaId"].Visible = false;

            if (dgvHistorial.Columns["RutaSalidaId"] != null)
                dgvHistorial.Columns["RutaSalidaId"].Visible = false;

            if (dgvHistorial.Columns["HorarioSalidaId"] != null)
                dgvHistorial.Columns["HorarioSalidaId"].Visible = false;

            if (dgvHistorial.Columns["ParadaSalidaId"] != null)
                dgvHistorial.Columns["ParadaSalidaId"].Visible = false;

            if (dgvHistorial.Columns["NombreRutaEntrada"] != null)
                dgvHistorial.Columns["NombreRutaEntrada"].Visible = false;

            if (dgvHistorial.Columns["NombreHorarioEntrada"] != null)
                dgvHistorial.Columns["NombreHorarioEntrada"].Visible = false;

            if (dgvHistorial.Columns["NombreParadaEntrada"] != null)
                dgvHistorial.Columns["NombreParadaEntrada"].Visible = false;

            if (dgvHistorial.Columns["NombreRutaSalida"] != null)
                dgvHistorial.Columns["NombreRutaSalida"].Visible = false;

            if (dgvHistorial.Columns["NombreHorarioSalida"] != null)
                dgvHistorial.Columns["NombreHorarioSalida"].Visible = false;

            if (dgvHistorial.Columns["NombreParadaSalida"] != null)
                dgvHistorial.Columns["NombreParadaSalida"].Visible = false;


            if (dgvHistorial.Columns["IdentificadorInstitucional"] != null)
            {
                dgvHistorial.Columns[
                    "IdentificadorInstitucional"
                ].HeaderText = "Matrícula";
            }


            if (dgvHistorial.Columns["Monto"] != null)
            {
                dgvHistorial.Columns["Monto"].HeaderText =
                    "Monto";

                dgvHistorial.Columns[
                    "Monto"
                ].DefaultCellStyle.Format = "C2";
            }

            if (dgvHistorial.Columns["FechaPago"] != null)
            {
                dgvHistorial.Columns["FechaPago"].HeaderText =
                    "Fecha";

                dgvHistorial.Columns[
                    "FechaPago"
                ].DefaultCellStyle.Format =
                    "dd/MM/yyyy HH:mm";
            }

            if (dgvHistorial.Columns["Modalidad"] != null)
            {
                dgvHistorial.Columns["Modalidad"].HeaderText =
                    "Tipo de pago";
            }


            if (dgvHistorial.Columns["Concepto"] != null)
            {
                dgvHistorial.Columns["Concepto"].HeaderText =
                    "Concepto";
            }


            dgvHistorial.ReadOnly = true;

            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.AllowUserToResizeRows = false;

            dgvHistorial.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvHistorial.MultiSelect = false;

            dgvHistorial.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvHistorial.RowHeadersVisible = false;

            dgvHistorial.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;

            dgvHistorial.RowTemplate.Height = 35;
        }


        private void Limpiar()
        {
            _tarjetaActual = null;

            panelTarjeta.Visible = false;

            lblMatricula.Text = "-";
            lblSaldo.Text = "RD$ 0.00";

            txtMonto.Clear();

            cmbTipoPago.SelectedIndex = 0;

            btnRecargar.Enabled = false;

            dgvHistorial.DataSource = null;
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelPrincipal_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}

