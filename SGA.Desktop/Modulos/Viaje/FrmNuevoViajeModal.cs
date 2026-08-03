using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGA.Application.Dtos.Autobus;
using SGA.Application.Dtos.Conductor;
using SGA.Application.Dtos.Horario;
using SGA.Application.Dtos.Ruta;
using SGA.Application.Dtos.Viaje;
using SGA.Application.Interfaces;
using SGA.Domain.Enums.Reservation;

namespace SGA.Desktop.Modulos.Viaje
{
    public partial class FrmNuevoViajeModal : Form
    {
        private readonly IViajeService _viajeService;
        private readonly IRutaService _rutaService;
        private readonly IAutobusService _autobusService;
        private readonly IConductorService _conductorService;
        private readonly IHorarioService _horarioService;

        public ViajeDto ViajeProcesado { get; private set; }
        public bool EsEdicion { get; private set; }
        private readonly ViajeDto _viajeAEditar;

        public FrmNuevoViajeModal(
            IViajeService viajeService,
            IRutaService rutaService,
            IAutobusService autobusService,
            IConductorService conductorService,
            IHorarioService horarioService,
            ViajeDto viajeAEditar = null)
        {
            InitializeComponent();

            _viajeService = viajeService;
            _rutaService = rutaService;
            _autobusService = autobusService;
            _conductorService = conductorService;
            _horarioService = horarioService;

            _viajeAEditar = viajeAEditar;
            EsEdicion = _viajeAEditar != null;
        }

        private async void FrmNuevoViajeModal_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = EsEdicion ? "Actualizar Viaje" : "Programar Nuevo Viaje";

                // COMENTA ESTA LÍNEA TEMPORALMENTE:
                await CargarDatosDesdeBaseDeDatosAsync();

                MessageBox.Show("¡El modal abrió al instante sin consultas a BD!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async Task CargarDatosDesdeBaseDeDatosAsync()
        {
            try
            {
                // 1. Obtener los datos uno por uno desde la BD (evita choques en DbContext)
                List<RutaDto> rutas = null;
                List<AutobusDto> autobuses = null;
                List<ConductorDto> conductores = null;
                List<HorarioDto> horarios = null;

                if (_rutaService != null)
                {
                    var res = await _rutaService.GetAllAsync();
                    rutas = res?.ToList();
                }

                if (_autobusService != null)
                {
                    var res = await _autobusService.GetAllAsync();
                    autobuses = res?.ToList();
                }

                if (_conductorService != null)
                {
                    var res = await _conductorService.GetAllAsync();
                    conductores = res?.ToList();
                }

                if (_horarioService != null)
                {
                    var res = await _horarioService.GetAllAsync();
                    horarios = res?.ToList();
                }

                // 2. Poblar los controles de la interfaz de forma segura
                if (rutas != null && cmbRuta != null)
                {
                    cmbRuta.DisplayMember = "Nombre";
                    cmbRuta.ValueMember = "Id";
                    cmbRuta.DataSource = rutas;
                }

                if (autobuses != null && cmbAutobus != null)
                {
                    cmbAutobus.DisplayMember = "Placa";
                    cmbAutobus.ValueMember = "Id";
                    cmbAutobus.DataSource = autobuses;
                }

                if (conductores != null && cmbConductor != null)
                {
                    cmbConductor.DisplayMember = "Nombre";
                    cmbConductor.ValueMember = "Id";
                    cmbConductor.DataSource = conductores;
                }

                if (horarios != null && cmbHorario != null)
                {
                    cmbHorario.DisplayMember = "HoraInicio";
                    cmbHorario.ValueMember = "Id";
                    cmbHorario.DataSource = horarios;
                }

                // 3. Deseleccionar si es un registro nuevo
                if (!EsEdicion)
                {
                    if (cmbRuta != null) cmbRuta.SelectedIndex = -1;
                    if (cmbAutobus != null) cmbAutobus.SelectedIndex = -1;
                    if (cmbConductor != null) cmbConductor.SelectedIndex = -1;
                    if (cmbHorario != null) cmbHorario.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosParaEdicion()
        {
            if (_viajeAEditar != null)
            {
                if (cmbRuta != null) cmbRuta.SelectedValue = _viajeAEditar.RutaId;
                if (cmbAutobus != null) cmbAutobus.SelectedValue = _viajeAEditar.AutobusId;
                if (cmbConductor != null) cmbConductor.SelectedValue = _viajeAEditar.ConductorId;
                if (cmbHorario != null) cmbHorario.SelectedValue = _viajeAEditar.HorarioId;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarSeleccion()) return;

            try
            {
                var dto = new ViajeDto
                {
                    Id = EsEdicion ? _viajeAEditar.Id : 0,
                    RutaId = Convert.ToInt32(cmbRuta.SelectedValue),
                    AutobusId = Convert.ToInt32(cmbAutobus.SelectedValue),
                    ConductorId = Convert.ToInt32(cmbConductor.SelectedValue),
                    HorarioId = Convert.ToInt32(cmbHorario.SelectedValue),
                    Estado = EsEdicion ? _viajeAEditar.Estado : EstadoViaje.Programado
                };

                if (_viajeService != null)
                {
                    if (EsEdicion)
                    {
                        await _viajeService.UpdateAsync(dto);
                        MessageBox.Show("El viaje ha sido actualizado en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        await _viajeService.AddAsync(dto);
                        MessageBox.Show("El viaje ha sido registrado exitosamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                ViajeProcesado = dto;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar en la base de datos: {ex.Message}",
                                "Error de Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarSeleccion()
        {
            if (cmbRuta.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar una Ruta válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbAutobus.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un Autobús válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbConductor.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un Conductor válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbHorario.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un Horario válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}