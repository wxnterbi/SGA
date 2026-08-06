using Microsoft.Extensions.DependencyInjection;
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


        private ViajeDto? _viajeEditar;


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



        public FrmNuevoViaje(
            IViajeApiService viajeApiService,
            ViajeDto viaje)
        {
            InitializeComponent();


            _viajeApiService = viajeApiService;

            _viajeEditar = viaje;


            _rutaApiService =
                Program.ServiceProvider
                .GetRequiredService<IRutaApiService>();


            _horarioApiService =
                Program.ServiceProvider
                .GetRequiredService<IHorarioApiService>();


            _autobusApiService =
                Program.ServiceProvider
                .GetRequiredService<IAutobusApiService>();


            _conductorApiService =
                Program.ServiceProvider
                .GetRequiredService<IConductorApiService>();



            Load += FrmNuevoViaje_Load;

            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
        }



        private async void FrmNuevoViaje_Load(
            object sender,
            EventArgs e)
        {
            try
            {
                await CargarCombos();

                CargarEstados();


                if (_viajeEditar != null)
                {
                    CargarDatosEditar();
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



        private async Task CargarCombos()
        {
            var rutas =
                await _rutaApiService.GetAllAsync();


            cmbRuta.DataSource = rutas;

            cmbRuta.DisplayMember =
                "Nombre";

            cmbRuta.ValueMember =
                "Id";



            var horarios =
                await _horarioApiService.GetAllAsync();


            cmbHorario.DataSource =
                horarios;

            cmbHorario.DisplayMember =
                "HoraSalida";

            cmbHorario.ValueMember =
                "Id";



            var autobuses =
                await _autobusApiService.GetAllAsync();


            cmbAutobus.DataSource =
                autobuses;

            cmbAutobus.DisplayMember =
                "Placa";

            cmbAutobus.ValueMember =
                "Id";



            var conductores =
                await _conductorApiService.GetAllAsync();


            cmbConductor.DataSource =
                conductores;

            cmbConductor.DisplayMember =
                "Nombre";

            cmbConductor.ValueMember =
                "Id";

        }



        private void CargarEstados()
        {
            cmbEstado.DataSource =
                Enum.GetValues(typeof(EstadoViaje));
        }



        private void CargarDatosEditar()
        {
            cmbRuta.SelectedValue =
                _viajeEditar!.RutaId;


            cmbHorario.SelectedValue =
                _viajeEditar.HorarioId;


            cmbAutobus.SelectedValue =
                _viajeEditar.AutobusId;


            cmbConductor.SelectedValue =
                _viajeEditar.ConductorId;


            cmbEstado.SelectedItem =
                _viajeEditar.Estado;


            lblTitulo.Text =
                "Actualizar Viaje";
        }



        private async void btnGuardar_Click(
            object sender,
            EventArgs e)
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
                        "Complete todos los campos.");

                    return;
                }



                var viaje = new ViajeDto
                {
                    RutaId =
                    Convert.ToInt32(
                        cmbRuta.SelectedValue),

                    HorarioId =
                    Convert.ToInt32(
                        cmbHorario.SelectedValue),

                    AutobusId =
                    Convert.ToInt32(
                        cmbAutobus.SelectedValue),

                    ConductorId =
                    Convert.ToInt32(
                        cmbConductor.SelectedValue),

                    Estado =
                    (EstadoViaje)cmbEstado.SelectedItem
                };



                bool resultado;



                if (_viajeEditar == null)
                {
                    var respuesta =
                        await _viajeApiService
                        .CreateAsync(viaje);


                    resultado =
                        respuesta.Success;


                    if (!resultado)
                    {
                        MessageBox.Show(
                            respuesta.Message);

                        return;
                    }

                }
                else
                {
                    viaje.Id =
                        _viajeEditar.Id;


                    resultado =
                        await _viajeApiService
                        .UpdateAsync(viaje);
                }



                if (resultado)
                {
                    MessageBox.Show(
                        "Operación realizada correctamente.");


                    DialogResult =
                        DialogResult.OK;


                    Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error");
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