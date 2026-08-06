using SGA.Application.Dtos.Autobus;
using SGA.Domain.Enums.Configuration;
using SGA.Presentation.Desktop.Interfaces;

namespace SGA.Presentation.Desktop.Forms.Autobus
{
    public partial class FrmNuevoAutobus : Form
    {
        private readonly IAutobusApiService _autobusApiService;

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
        }

        private void CargarEstados()
        {

            cmbEstado.DataSource =
                Enum.GetValues(typeof(EstadoAutobus));


            cmbEstado.SelectedIndex = 0;

        }

        private async void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtPlaca.Text) ||
                   string.IsNullOrWhiteSpace(txtMarca.Text) ||
                   string.IsNullOrWhiteSpace(txtModelo.Text) ||
                   cmbEstado.SelectedItem == null)
                {

                    MessageBox.Show(
                        "Debe completar todos los campos.",
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

                    Capacidad =
                        Convert.ToInt32(numCapacidad.Value),


                    EstadoAutobusId =
                        (int)cmbEstado.SelectedItem

                };

                var resultado =
                    await _autobusApiService
                    .CreateAsync(autobus);

                if (resultado.Success)
                {

                    MessageBox.Show(
                        resultado.Message,
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);



                    DialogResult =
                        DialogResult.OK;


                    Close();

                }
                else
                {

                    MessageBox.Show(
                        resultado.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }

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