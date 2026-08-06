using SGA.Application.Dtos.Viaje;
using SGA.Presentation.Desktop.Interfaces;

namespace SGA.Presentation.Desktop.Forms.Viaje
{
    public partial class FrmDetalleViaje : Form
    {

        private readonly IViajeApiService _viajeApiService;


        public FrmDetalleViaje(
            IViajeApiService viajeApiService)
        {
            InitializeComponent();

            _viajeApiService = viajeApiService;
        }



        public async void CargarViaje(int id)
        {
            var viaje =
                await _viajeApiService
                .GetByIdAsync(id);


            if (viaje == null)
            {
                MessageBox.Show(
                    "No se encontró el viaje.");

                Close();

                return;
            }


            lblRuta.Text =
                $"Ruta: {viaje.NombreRuta}";

            lblHorario.Text =
                $"Horario: {viaje.HorarioTexto}";

            lblAutobus.Text =
                $"Autobús: {viaje.PlacaAutobus}";

            lblConductor.Text =
                $"Conductor: {viaje.NombreConductor}";

            lblEstado.Text =
                $"Estado: {viaje.Estado}";
        }

        private void FrmDetalleViaje_Load(object sender, EventArgs e)
        {
        }

    }
}