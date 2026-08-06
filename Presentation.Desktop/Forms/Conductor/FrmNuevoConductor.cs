using SGA.Application.Dtos.Conductor;
using SGA.Presentation.Desktop.Interfaces;
using SGA.Domain.Enums.Configuration;

namespace SGA.Presentation.Desktop.Forms.Conductor
{
    public partial class FrmNuevoConductor : Form
    {
        private readonly IConductorApiService _conductorApiService;

        private int _idConductor = 0;


        public FrmNuevoConductor(
            IConductorApiService conductorApiService)
        {
            InitializeComponent();

            _conductorApiService = conductorApiService;


            Load += FrmNuevoConductor_Load;

            btnGuardar.Click += btnGuardar_Click;

            btnCancelar.Click += btnCancelar_Click;
        }



        private void FrmNuevoConductor_Load(
            object sender,
            EventArgs e)
        {
            CargarEstados();
        }



        private void CargarEstados()
        {
            cmbEstado.DataSource =
                Enum.GetValues(typeof(EstadoLaboral));

            cmbEstado.SelectedIndex = 0;
        }




        public async void CargarConductor(int id)
        {
            _idConductor = id;


            var conductor =
                await _conductorApiService
                .GetByIdAsync(id);


            if (conductor == null)
            {
                MessageBox.Show(
                    "No se encontró el conductor.");

                return;
            }



            txtNombre.Text = conductor.Nombre;

            txtCedula.Text = conductor.Cedula;

            txtLicencia.Text = conductor.Licencia;

            txtTelefono.Text = conductor.Telefono;


            cmbEstado.SelectedItem =
                (EstadoLaboral)
                conductor.EstadoConductorId;


            btnGuardar.Text = "Actualizar";
        }





        private async void btnGuardar_Click(
            object sender,
            EventArgs e)
        {

            try
            {

                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtCedula.Text) ||
                    string.IsNullOrWhiteSpace(txtLicencia.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefono.Text))
                {

                    MessageBox.Show(
                        "Debe completar todos los campos.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }




                var conductor = new ConductorDto
                {
                    Id = _idConductor,

                    Nombre = txtNombre.Text,

                    Cedula = txtCedula.Text,

                    Licencia = txtLicencia.Text,

                    Telefono = txtTelefono.Text,

                    EstadoConductorId =
                    (int)cmbEstado.SelectedItem
                };





                bool resultado;



                // NUEVO

                if (_idConductor == 0)
                {
                    resultado =
                        await _conductorApiService
                        .CreateAsync(conductor);
                }


                // ACTUALIZAR

                else
                {
                    resultado =
                        await _conductorApiService
                        .UpdateAsync(conductor);
                }





                if (resultado)
                {

                    MessageBox.Show(
                        _idConductor == 0
                        ? "Conductor registrado correctamente."
                        : "Conductor actualizado correctamente.",
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
                        "No se pudo guardar la información.",
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

        private void FrmNuevoConductor_Load_1(object sender, EventArgs e)
        {

        }
    }
}
