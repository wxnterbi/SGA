using SGA.Presentation.Desktop.Interfaces;

namespace SGA.Presentation.Desktop.Forms.RegistroAcceso
{
    public partial class FrmRegistroAccesoPrincipal : Form
    {
        private readonly IRegistroAccesoApiService _registroAccesoApiService;
        private readonly IViajeApiService _viajeApiService;

        public FrmRegistroAccesoPrincipal(
            IRegistroAccesoApiService registroAccesoApiService,
            IViajeApiService viajeApiService)
        {
            InitializeComponent();

            _registroAccesoApiService = registroAccesoApiService;
            _viajeApiService = viajeApiService;

            Load += FrmRegistroAccesoPrincipal_Load;
            btnValidar.Click += btnValidar_Click;
            btnDetalles.Click += btnDetalles_Click;
        }

        private async Task CargarViajes()
        {
            var viajes = await _viajeApiService.GetAllAsync();

            cmbViaje.DataSource = viajes;

            cmbViaje.DisplayMember = "NombreRuta";

            cmbViaje.ValueMember = "Id";
        }

        private async void FrmRegistroAccesoPrincipal_Load(
            object? sender,
            EventArgs e)
        {
            await CargarViajes();
            await CargarRegistros();
        }

        private async Task CargarRegistros()
        {
            try
            {
                var registros =
                    await _registroAccesoApiService.GetAllAsync();

                dgvRegistros.DataSource = registros
                    .OrderByDescending(r => r.FechaHora)
                    .Select(r => new
                    {
                        Matrícula = r.Matricula,
                        Estado = r.Permitido
                            ? "Permitido"
                            : "Denegado",
                        Motivo = r.Motivo,
                        Fecha = r.FechaHora
                    })
                    .ToList();

                dgvRegistros.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvRegistros.ReadOnly = true;
                dgvRegistros.AllowUserToAddRows = false;
                dgvRegistros.AllowUserToDeleteRows = false;
                dgvRegistros.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible cargar los registros de acceso.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnValidar_Click(
            object? sender,
            EventArgs e)
        {
            try
            {
                string matricula = txtMatricula.Text.Trim();

                if (string.IsNullOrWhiteSpace(matricula))
                {
                    MessageBox.Show(
                        "Debe introducir una matrícula.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtMatricula.Focus();
                    return;
                }

                btnValidar.Enabled = false;

                if (cmbViaje.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un viaje.");
                    return;
                }

                int viajeId = (int)cmbViaje.SelectedValue;

                var resultado =
                    await _registroAccesoApiService
                        .ValidarMatriculaAsync(
                            matricula,
                            viajeId);

                if (resultado == null)
                {
                    MessageBox.Show(
                        "No fue posible validar la matrícula.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                lblResultado.Text = resultado.Mensaje;

                lblNombre.Text =
                    string.IsNullOrWhiteSpace(resultado.Nombre)
                        ? "Estudiante no encontrado"
                        : resultado.Nombre;

                lblMatricula.Text =
                    string.IsNullOrWhiteSpace(resultado.Matricula)
                        ? matricula
                        : resultado.Matricula;

                if (resultado.Permitido)
                {
                    lblEstado.Text = "ACCESO PERMITIDO";
                    lblEstado.ForeColor =
                        Color.FromArgb(40, 167, 69);
                }
                else
                {
                    lblEstado.Text = "ACCESO DENEGADO";
                    lblEstado.ForeColor =
                        Color.Firebrick;
                }

                await CargarRegistros();

                txtMatricula.Clear();
                txtMatricula.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al validar la matrícula.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnValidar.Enabled = true;
            }
        }

        private void btnDetalles_Click(
            object? sender,
            EventArgs e)
        {
            if (dgvRegistros.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un registro.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            string matricula =
                dgvRegistros.CurrentRow
                    .Cells["Matrícula"]
                    .Value?.ToString() ?? "";

            string estado =
                dgvRegistros.CurrentRow
                    .Cells["Estado"]
                    .Value?.ToString() ?? "";

            string motivo =
                dgvRegistros.CurrentRow
                    .Cells["Motivo"]
                    .Value?.ToString() ?? "";

            string fecha =
                dgvRegistros.CurrentRow
                    .Cells["Fecha"]
                    .Value?.ToString() ?? "";

            MessageBox.Show(
                $"Matrícula: {matricula}\n\n" +
                $"Estado: {estado}\n\n" +
                $"Motivo: {motivo}\n\n" +
                $"Fecha: {fecha}",
                "Detalle del acceso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmRegistroAccesoPrincipal_Load_1(object sender, EventArgs e)
        {

        }
    }
}
