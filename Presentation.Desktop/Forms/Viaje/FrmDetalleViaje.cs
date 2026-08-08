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
            try
            {
                var viaje =
                    await _viajeApiService
                        .GetByIdAsync(id);

                if (viaje == null)
                {
                    MessageBox.Show(
                        "No se encontró el viaje.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    Close();

                    return;
                }

                lblRuta.Text =
                    viaje.NombreRuta;

                lblHorario.Text =
                    viaje.HorarioTexto;

                lblAutobus.Text =
                    viaje.PlacaAutobus;

                lblConductor.Text =
                    viaje.NombreConductor;

                lblEstado.Text =
                    viaje.Estado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Close();
            }
        }

        private void btnCerrar_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }

        private void FrmDetalleViaje_Load(
            object sender,
            EventArgs e)
        {
        }
    }
}