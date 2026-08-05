using SGA.Application.Dtos.Viaje;
using SGA.Presentation.Desktop.Interfaces;

namespace SGA.Presentation.Desktop.Forms.Viaje
{
    public partial class FrmViajePrincipal : Form
    {
        private readonly IViajeApiService _viajeApiService;
        private List<ViajeDto> _viajes = new();

        public FrmViajePrincipal(IViajeApiService viajeApiService)
        {
            InitializeComponent();

            _viajeApiService = viajeApiService;

            Load += FrmViajePrincipal_Load;
        }

        private async void FrmViajePrincipal_Load(object sender, EventArgs e)
        {
            await CargarViajes();
        }

        private async Task CargarViajes()
        {

            try
            {
                var viajes = await _viajeApiService.GetAllAsync();

                dgvViajes.DataSource = null;

                dgvViajes.DataSource = viajes.Select(v => new
                {
                    v.Id,
                    Estado = v.Estado.ToString(),
                    Horario = v.HorarioTexto,
                    Ruta = v.NombreRuta,
                    Autobus = v.PlacaAutobus,
                    Conductor = v.NombreConductor
                }).ToList();

                ConfigurarGrid();
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
        private void ConfigurarGrid()
        {
            dgvViajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvViajes.Columns["Id"].HeaderText = "ID";
            dgvViajes.Columns["Estado"].HeaderText = "Estado";
            dgvViajes.Columns["Horario"].HeaderText = "Horario";
            dgvViajes.Columns["Ruta"].HeaderText = "Ruta";
            dgvViajes.Columns["Autobus"].HeaderText = "Autobús";
            dgvViajes.Columns["Conductor"].HeaderText = "Conductor";

            dgvViajes.Columns["Id"].FillWeight = 15;
            dgvViajes.Columns["Estado"].FillWeight = 20;
            dgvViajes.Columns["Horario"].FillWeight = 20;
            dgvViajes.Columns["Ruta"].FillWeight = 30;
            dgvViajes.Columns["Autobus"].FillWeight = 25;
            dgvViajes.Columns["Conductor"].FillWeight = 30;

            dgvViajes.ClearSelection();
        }
    }
}