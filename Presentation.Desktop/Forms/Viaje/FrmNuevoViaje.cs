using Microsoft.Extensions.DependencyInjection;
using SGA.Application.Dtos.Viaje;
using SGA.Domain.Enums.Reservation;
using SGA.Presentation.Desktop.Interfaces;
using System.Globalization;

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

            cmbRuta.DataSource = null;
            cmbRuta.DataSource = rutas;
            cmbRuta.DisplayMember = "Nombre";
            cmbRuta.ValueMember = "Id";

            var horarios =
                await _horarioApiService.GetAllAsync();

            var horariosCombo = horarios
                .Select(h => new
                {
                    Id = h.Id,
                    HoraTexto = DateTime.Today
                        .Add(h.HoraSalida)
                        .ToString(
                            "hh:mm tt",
                            CultureInfo.InvariantCulture)
                })
                .ToList();

            cmbHorario.DataSource = null;
            cmbHorario.DataSource = horariosCombo;
            cmbHorario.DisplayMember = "HoraTexto";
            cmbHorario.ValueMember = "Id";

            var autobuses =
                await _autobusApiService.GetAllAsync();

            cmbAutobus.DataSource = null;
            cmbAutobus.DataSource = autobuses;
            cmbAutobus.DisplayMember = "Placa";
            cmbAutobus.ValueMember = "Id";

            var conductores =
                await _conductorApiService.GetAllAsync();

            cmbConductor.DataSource = null;
            cmbConductor.DataSource = conductores;
            cmbConductor.DisplayMember = "Nombre";
            cmbConductor.ValueMember = "Id";
        }

        private void CargarEstados()
        {
            cmbEstado.DataSource = null;
            cmbEstado.DataSource =
                Enum.GetValues(typeof(EstadoViaje));
        }

        private void CargarDatosEditar()
        {
            if (_viajeEditar == null)
                return;

            cmbRuta.SelectedValue =
                _viajeEditar.RutaId;

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


                if (cmbRuta.SelectedValue == null)
                {
                    MessageBox.Show(
                        "Debe seleccionar una ruta.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbRuta.Focus();
                    return;
                }

                if (!int.TryParse(
                    cmbRuta.SelectedValue.ToString(),
                    out int rutaId) ||
                    rutaId <= 0)
                {
                    MessageBox.Show(
                        "La ruta seleccionada no es válida.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbRuta.Focus();
                    return;
                }



                if (cmbHorario.SelectedValue == null)
                {
                    MessageBox.Show(
                        "Debe seleccionar un horario.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbHorario.Focus();
                    return;
                }

                if (!int.TryParse(
                    cmbHorario.SelectedValue.ToString(),
                    out int horarioId) ||
                    horarioId <= 0)
                {
                    MessageBox.Show(
                        "El horario seleccionado no es válido.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbHorario.Focus();
                    return;
                }


                if (cmbAutobus.SelectedValue == null)
                {
                    MessageBox.Show(
                        "Debe seleccionar un autobús.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbAutobus.Focus();
                    return;
                }

                if (!int.TryParse(
                    cmbAutobus.SelectedValue.ToString(),
                    out int autobusId) ||
                    autobusId <= 0)
                {
                    MessageBox.Show(
                        "El autobús seleccionado no es válido.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbAutobus.Focus();
                    return;
                }


                if (cmbConductor.SelectedValue == null)
                {
                    MessageBox.Show(
                        "Debe seleccionar un conductor.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbConductor.Focus();
                    return;
                }

                if (!int.TryParse(
                    cmbConductor.SelectedValue.ToString(),
                    out int conductorId) ||
                    conductorId <= 0)
                {
                    MessageBox.Show(
                        "El conductor seleccionado no es válido.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbConductor.Focus();
                    return;
                }

                if (cmbEstado.SelectedItem == null)
                {
                    MessageBox.Show(
                        "Debe seleccionar un estado.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbEstado.Focus();
                    return;
                }

                if (!(cmbEstado.SelectedItem
                    is EstadoViaje))
                {
                    MessageBox.Show(
                        "El estado seleccionado no es válido.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbEstado.Focus();
                    return;
                }

                EstadoViaje estado =
                    (EstadoViaje)cmbEstado.SelectedItem;


                var viaje = new ViajeDto
                {
                    RutaId = rutaId,
                    HorarioId = horarioId,
                    AutobusId = autobusId,
                    ConductorId = conductorId,
                    Estado = estado
                };

                bool resultado;



                if (_viajeEditar == null)
                {
                    var respuesta =
                        await _viajeApiService
                            .CreateAsync(viaje);

                    if (!respuesta.Success)
                    {
                        MessageBox.Show(
                            respuesta.Message,
                            "Validación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    resultado = true;
                }
                else
                {


                    viaje.Id =
                        _viajeEditar.Id;

                    resultado =
                        await _viajeApiService
                            .UpdateAsync(viaje);

                    if (!resultado)
                    {
                        MessageBox.Show(
                            "No se pudo actualizar el viaje.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return;
                    }
                }


                if (resultado)
                {
                    MessageBox.Show(
                        _viajeEditar == null
                            ? "Viaje registrado correctamente."
                            : "Viaje actualizado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    DialogResult =
                        DialogResult.OK;

                    Close();
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