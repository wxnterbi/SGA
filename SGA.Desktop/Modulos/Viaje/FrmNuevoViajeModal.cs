using SGA.Application.Dtos.Autobus;
using SGA.Application.Dtos.Conductor;
using SGA.Application.Dtos.Horario;
using SGA.Application.Dtos.Ruta;
using SGA.Application.Dtos.Viaje;
using SGA.Desktop.Interfaces.Viaje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGA.Desktop.Modulos.Viaje
{
    public partial class FrmNuevoViajeModal : Form
    {
        private readonly IViajeApiService _viajeApiService;
        private readonly HttpClient _httpClient;

        public ViajeDto ViajeProcesado { get; private set; }
        public bool EsEdicion { get; private set; }
        private readonly ViajeDto _viajeAEditar;

        public FrmNuevoViajeModal(
            IViajeApiService viajeApiService,
            HttpClient httpClient,
            ViajeDto viajeAEditar = null)
        {
            InitializeComponent();

            _viajeApiService = viajeApiService;
            _httpClient = httpClient;

            _viajeAEditar = viajeAEditar;
            EsEdicion = _viajeAEditar != null;
        }

        private async void FrmNuevoViajeModal_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = EsEdicion ? "Actualizar Viaje" : "Programar Nuevo Viaje";

                await CargarDatosDesdeApiAsync();

                if (EsEdicion)
                {
                    CargarDatosParaEdicion();
                }
                else
                {
                    LimpiarSelecciones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar la ventana: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarDatosDesdeApiAsync()
        {
            try
            {
                var rutas = await _httpClient.GetFromJsonAsync<List<RutaDto>>("api/rutas") ?? new List<RutaDto>();
                var autobuses = await _httpClient.GetFromJsonAsync<List<AutobusDto>>("api/autobuses") ?? new List<AutobusDto>();
                var conductores = await _httpClient.GetFromJsonAsync<List<ConductorDto>>("api/conductores") ?? new List<ConductorDto>();
                var horarios = await _httpClient.GetFromJsonAsync<List<HorarioDto>>("api/horarios") ?? new List<HorarioDto>();

                if (cmbRuta != null)
                {
                    cmbRuta.DisplayMember = "Nombre";
                    cmbRuta.ValueMember = "Id";
                    cmbRuta.DataSource = rutas.ToList();
                }

                if (cmbAutobus != null)
                {
                    cmbAutobus.DisplayMember = "Placa";
                    cmbAutobus.ValueMember = "Id";
                    cmbAutobus.DataSource = autobuses.ToList();
                }

                if (cmbConductor != null)
                {
                    cmbConductor.DisplayMember = "Nombre";
                    cmbConductor.ValueMember = "Id";
                    cmbConductor.DataSource = conductores.ToList();
                }

                if (cmbHorario != null)
                {
                    var listaHorarios = horarios.Select(h => new
                    {
                        Id = h.Id,
                        TextoMostrar = DateTime.Today.Add(h.HoraSalida).ToString("hh:mm tt")
                    }).ToList();

                    cmbHorario.DisplayMember = "TextoMostrar";
                    cmbHorario.ValueMember = "Id";
                    cmbHorario.DataSource = listaHorarios;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos desde el servidor API:\n{ex.Message}",
                                "SGA ITLA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void LimpiarSelecciones()
        {
            if (cmbRuta != null) cmbRuta.SelectedIndex = -1;
            if (cmbAutobus != null) cmbAutobus.SelectedIndex = -1;
            if (cmbConductor != null) cmbConductor.SelectedIndex = -1;
            if (cmbHorario != null) cmbHorario.SelectedIndex = -1;
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
            try
            {
                // Extraer el ID de forma segura incluso si SelectedValue devuelve un tipo anónimo
                int ObtenerIdCombo(ComboBox combo)
                {
                    if (combo.SelectedValue != null && int.TryParse(combo.SelectedValue.ToString(), out int idVal))
                        return idVal;

                    if (combo.SelectedItem != null)
                    {
                        var prop = combo.SelectedItem.GetType().GetProperty("Id");
                        if (prop != null)
                            return Convert.ToInt32(prop.GetValue(combo.SelectedItem, null));
                    }
                    return 0;
                }

                int rutaId = ObtenerIdCombo(cmbRuta);
                int autobusId = ObtenerIdCombo(cmbAutobus);
                int conductorId = ObtenerIdCombo(cmbConductor);
                int horarioId = ObtenerIdCombo(cmbHorario);

                // Validaciones locales previas al envío
                if (rutaId <= 0 || autobusId <= 0 || conductorId <= 0 || horarioId <= 0)
                {
                    MessageBox.Show("Debe seleccionar una Ruta, Autobús, Conductor y Horario válidos.",
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool exito = false;

                if (EsEdicion)
                {
                    var updateDto = new UpdateViajeDto
                    {
                        RutaId = rutaId,
                        AutobusId = autobusId,
                        ConductorId = conductorId,
                        HorarioId = horarioId,
                        Estado = _viajeAEditar.Estado
                    };

                    exito = await _viajeApiService.UpdateAsync(_viajeAEditar.Id, updateDto);
                }
                else
                {
                    var createDto = new CreateViajeDto
                    {
                        RutaId = rutaId,
                        AutobusId = autobusId,
                        ConductorId = conductorId,
                        HorarioId = horarioId
                    };

                    exito = await _viajeApiService.CreateAsync(createDto);
                }

                if (exito)
                {
                    MessageBox.Show("El viaje se guardó exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de Validación / Servidor:\n\n{ex.Message}",
                                "Validación de Viaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}