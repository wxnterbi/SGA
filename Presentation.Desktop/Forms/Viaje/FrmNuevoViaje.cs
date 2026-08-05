using SGA.Application.Dtos.Viaje;
using SGA.Domain.Enums.Reservation;
using SGA.Presentation.Desktop.Interfaces;

namespace SGA.Presentation.Desktop.Forms.Viaje
{
    public partial class FrmNuevoViaje : Form
    {

        private readonly IViajeApiService _viajeApiService;
        private readonly IRutaApiService _rutaApiService;
        private readonly IHorarioApiService _horarioApiService;
        private readonly IAutobusApiService _autobusApiService;
        private readonly IConductorApiService _conductorApiService;


        public FrmNuevoViaje(
            IViajeApiService viajeApiService,
            IRutaApiService rutaApiService,
            IHorarioApiService horarioApiService,
            IAutobusApiService autobusApiService,
            IConductorApiService conductorApiService)
        {
            InitializeComponent();


            _viajeApiService = viajeApiService;
            _rutaApiService = rutaApiService;
            _horarioApiService = horarioApiService;
            _autobusApiService = autobusApiService;
            _conductorApiService = conductorApiService;


            Load += FrmNuevoViaje_Load;

            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
        }



        private async void FrmNuevoViaje_Load(object sender, EventArgs e)
        {
            try
            {
                await CargarCombos();

                CargarEstados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error cargando datos del viaje:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }



        private async Task CargarCombos()
        {

            // Rutas

            var rutas = await _rutaApiService.GetAllAsync();

            cmbRuta.DataSource = rutas;
            cmbRuta.DisplayMember = "Nombre";
            cmbRuta.ValueMember = "Id";



            // Horarios

            var horarios = await _horarioApiService.GetAllAsync();

            cmbHorario.DataSource = horarios;
            cmbHorario.DisplayMember = "HoraSalida";
            cmbHorario.ValueMember = "Id";



            // Autobuses

            var autobuses = await _autobusApiService.GetAllAsync();

            cmbAutobus.DataSource = autobuses;
            cmbAutobus.DisplayMember = "Placa";
            cmbAutobus.ValueMember = "Id";



            // Conductores

            var conductores = await _conductorApiService.GetAllAsync();

            cmbConductor.DataSource = conductores;
            cmbConductor.DisplayMember = "Nombre";
            cmbConductor.ValueMember = "Id";


            cmbRuta.SelectedIndex = -1;
            cmbHorario.SelectedIndex = -1;
            cmbAutobus.SelectedIndex = -1;
            cmbConductor.SelectedIndex = -1;

        }



        private void CargarEstados()
        {

            cmbEstado.DataSource =
                Enum.GetValues(typeof(EstadoViaje));

            cmbEstado.SelectedItem =
                EstadoViaje.Programado;

        }



        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbRuta.SelectedValue == null ||
                    cmbHorario.SelectedValue == null ||
                    cmbAutobus.SelectedValue == null ||
                    cmbConductor.SelectedValue == null ||
                    cmbEstado.SelectedItem == null)
                {
                    MessageBox.Show(
                        "Debe completar todos los campos.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


                var viaje = new ViajeDto
                {
                    RutaId = Convert.ToInt32(cmbRuta.SelectedValue),

                    HorarioId = Convert.ToInt32(cmbHorario.SelectedValue),

                    AutobusId = Convert.ToInt32(cmbAutobus.SelectedValue),

                    ConductorId = Convert.ToInt32(cmbConductor.SelectedValue),

                    Estado = (EstadoViaje)cmbEstado.SelectedItem
                };


                var resultado = await _viajeApiService.CreateAsync(viaje);


                if (resultado.Success)
                {
                    MessageBox.Show(
                        resultado.Message,
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


                    DialogResult = DialogResult.OK;

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
                    $"Error guardando viaje:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;

            Close();

        }

    }
}