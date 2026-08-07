using SGA.Application.Dtos.Conductor;
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
                        "No se encontró el conductor.");

                    Close();

                    return;
                }



                lblNombre.Text =
                    $"Nombre: {conductor.Nombre}";


                lblCedula.Text =
                    $"Cédula: {conductor.Cedula}";


                lblLicencia.Text =
                    $"Licencia: {conductor.Licencia}";


                lblTelefono.Text =
                    $"Teléfono: {conductor.Telefono}";


                lblEstado.Text =
                    $"Estado: {(conductor.EstadoConductorId == 1 ? "Activo" : "Inactivo")}";

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error");
            }

        }

        private void FrmDetalleConductor_Load_1(object sender, EventArgs e)
        {

        }
    }
}
