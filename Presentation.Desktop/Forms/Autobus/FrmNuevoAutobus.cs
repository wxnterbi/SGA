using SGA.Application.Dtos.Autobus;
using SGA.Domain.Enums.Configuration;
using SGA.Presentation.Desktop.Interfaces;
using SGA.Presentation.Desktop.Models;

namespace SGA.Presentation.Desktop.Forms.Autobus
{
    public partial class FrmNuevoAutobus : Form
    {
        private readonly IAutobusApiService _autobusApiService;

        private AutobusDto? _autobusEditar;

        public FrmNuevoAutobus(
            IAutobusApiService autobusApiService)
        {
            InitializeComponent();

            _autobusApiService = autobusApiService;

            Load += FrmNuevoAutobus_Load;

            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
        }

        private void FrmNuevoAutobus_Load(
            object sender,
            EventArgs e)
        {
            CargarEstados();

            if (_autobusEditar != null)
            {
                CargarDatos();
            }
        }

        public void CargarAutobus(
            AutobusDto autobus)
        {
            _autobusEditar = autobus;
        }

        private void CargarEstados()
        {
            cmbEstado.DataSource =
                Enum.GetValues(typeof(EstadoAutobus));

            cmbEstado.SelectedIndex = 0;
        }

        private void CargarDatos()
        {
            if (_autobusEditar == null)
                return;

            txtPlaca.Text =
                _autobusEditar.Placa;

            txtMarca.Text =
                _autobusEditar.Marca;

            txtModelo.Text =
                _autobusEditar.Modelo;

            numCapacidad.Value =
                _autobusEditar.Capacidad;

            cmbEstado.SelectedItem =
                (EstadoAutobus)_autobusEditar.EstadoAutobusId;

            lblTitulo.Text =
                "Editar Autobús";

            btnGuardar.Text =
                "Actualizar";
        }

        private async void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPlaca.Text))
                {
                    MessageBox.Show(
                        "La placa es obligatoria.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtPlaca.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMarca.Text))
                {
                    MessageBox.Show(
                        "La marca es obligatoria.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtMarca.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtModelo.Text))
                {
                    MessageBox.Show(
                        "El modelo es obligatorio.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtModelo.Focus();
                    return;
                }

                if (numCapacidad.Value <= 0)
                {
                    MessageBox.Show(
                        "La capacidad debe ser mayor que cero.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    numCapacidad.Focus();
                    return;
                }

                if (cmbEstado.SelectedItem == null)
                {
                    MessageBox.Show(
                        "Debe seleccionar un estado.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                var autobus = new AutobusDto
                {
                    Placa = txtPlaca.Text.Trim(),
                    Marca = txtMarca.Text.Trim(),
                    Modelo = txtModelo.Text.Trim(),
                    Capacidad = Convert.ToInt32(numCapacidad.Value),
                    EstadoAutobusId =
                        (int)cmbEstado.SelectedItem
                };

                ApiResponse resultado;

                if (_autobusEditar == null)
                {
                    resultado =
                        await _autobusApiService
                            .CreateAsync(autobus);
                }
                else
                {
                    autobus.Id =
                        _autobusEditar.Id;

                    resultado =
                        await _autobusApiService
                            .UpdateAsync(autobus);
                }

                MessageBox.Show(
                    resultado.Message,
                    resultado.Success
                        ? "Éxito"
                        : "Error",
                    MessageBoxButtons.OK,
                    resultado.Success
                        ? MessageBoxIcon.Information
                        : MessageBoxIcon.Error);

                if (!resultado.Success)
                    return;

                DialogResult =
                    DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(
            object sender,
            EventArgs e)
        {
            DialogResult =
                DialogResult.Cancel;

            Close();
        }
    }
}