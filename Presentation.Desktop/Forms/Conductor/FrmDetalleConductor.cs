using SGA.Presentation.Desktop.Interfaces;

namespace SGA.Presentation.Desktop.Forms.Conductor
{
    public partial class FrmDetalleConductor : Form
    {
        private readonly IConductorApiService _conductorApiService;

        private int _id;

        public FrmDetalleConductor(
            IConductorApiService conductorApiService)
        {
            InitializeComponent();

            _conductorApiService = conductorApiService;

            Load += FrmDetalleConductor_Load;
            btnCerrar.Click += btnCerrar_Click;
        }

        public void CargarConductor(int id)
        {
            _id = id;
        }

        private async void FrmDetalleConductor_Load(
            object sender,
            EventArgs e)
        {
            try
            {
                var conductor =
                    await _conductorApiService
                    .GetByIdAsync(_id);

                if (conductor == null)
                {
                    MessageBox.Show(
                        "No se encontró el conductor.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Close();
                    return;
                }

                lblNombre.Text =
                    conductor.Nombre;

                lblCedula.Text =
                    conductor.Cedula;

                lblLicencia.Text =
                    conductor.Licencia;

                lblTelefono.Text =
                    conductor.Telefono;

                lblEstado.Text =
                    conductor.EstadoConductorId == 1
                    ? "Activo"
                    : "Inactivo";
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

        private void btnCerrar_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }

        private void FrmDetalleConductor_Load_1(object sender, EventArgs e)
        {

        }
    }
}