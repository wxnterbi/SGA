using SGA.Application.Dtos.Incidencia;
using SGA.Domain.Enums.Reservation;
using SGA.Presentation.Desktop.Interfaces;

namespace SGA.Presentation.Desktop.Forms.Incidencia
{
    public partial class FrmNuevaIncidencia : Form
    {
        private readonly IIncidenciaApiService _incidenciaApiService;
        private readonly IViajeApiService _viajeApiService;
        private readonly IConductorApiService _conductorApiService;

        private readonly IncidenciaDto? _incidenciaEditar;


        public FrmNuevaIncidencia(
            IIncidenciaApiService incidenciaApiService,
            IViajeApiService viajeApiService,
            IConductorApiService conductorApiService,
            IncidenciaDto? incidencia = null)
        {
            InitializeComponent();

            _incidenciaApiService = incidenciaApiService;
            _viajeApiService = viajeApiService;
            _conductorApiService = conductorApiService;

            _incidenciaEditar = incidencia;

            Load += FrmNuevaIncidencia_Load;

            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
        }


        private async void FrmNuevaIncidencia_Load(
            object sender,
            EventArgs e)
        {
            try
            {
                await CargarCombos();

                if (_incidenciaEditar != null)
                {
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible cargar los datos.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private async Task CargarCombos()
        {


            var viajes =
                await _viajeApiService.GetAllAsync();

            cmbViaje.DataSource = null;

            cmbViaje.DataSource = viajes;

            cmbViaje.DisplayMember = "NombreRuta";
            cmbViaje.ValueMember = "Id";


            var conductores =
                await _conductorApiService.GetAllAsync();

            cmbConductor.DataSource = null;

            cmbConductor.DataSource = conductores;

            cmbConductor.DisplayMember = "Nombre";
            cmbConductor.ValueMember = "Id";


            cmbTipo.DataSource = null;

            cmbTipo.DataSource =
                Enum.GetValues(typeof(TipoIncidencia));




            if (_incidenciaEditar == null)
            {
                dtpFecha.Value = DateTime.Now;
            }
        }


        private void CargarDatos()
        {
            if (_incidenciaEditar == null)
                return;

            cmbViaje.SelectedValue =
                _incidenciaEditar.ViajeId;

            cmbConductor.SelectedValue =
                _incidenciaEditar.ConductorId;


            cmbTipo.SelectedItem =
                (TipoIncidencia)_incidenciaEditar.Tipo;

            txtDescripcion.Text =
                _incidenciaEditar.Descripcion;

            if (_incidenciaEditar.FechaHora != DateTime.MinValue)
            {
                dtpFecha.Value =
                    _incidenciaEditar.FechaHora;
            }


            lblTitulo.Text =
                "EDITAR INCIDENCIA";

            btnGuardar.Text =
                "Actualizar";
        }


        private async void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            try
            {

                if (cmbViaje.SelectedValue == null)
                {
                    MessageBox.Show(
                        "Debe seleccionar un viaje.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


                if (cmbConductor.SelectedValue == null)
                {
                    MessageBox.Show(
                        "Debe seleccionar un conductor.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


                if (cmbTipo.SelectedItem == null)
                {
                    MessageBox.Show(
                        "Debe seleccionar un tipo de incidencia.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show(
                        "Debe escribir una descripción.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtDescripcion.Focus();

                    return;
                }


                var incidencia = new IncidenciaDto
                {
                    ViajeId =
                        Convert.ToInt32(
                            cmbViaje.SelectedValue),

                    ConductorId =
                        Convert.ToInt32(
                            cmbConductor.SelectedValue),

                    Tipo =
                        (int)(TipoIncidencia)
                            cmbTipo.SelectedItem,

                    Descripcion =
                        txtDescripcion.Text.Trim(),

                    FechaHora =
                        dtpFecha.Value
                };


                bool resultado;

                if (_incidenciaEditar == null)
                {
                    resultado =
                        await _incidenciaApiService
                            .CreateAsync(incidencia);
                }


                else
                {
                    incidencia.Id =
                        _incidenciaEditar.Id;

                    resultado =
                        await _incidenciaApiService
                            .UpdateAsync(incidencia);
                }




                if (resultado)
                {
                    string mensaje =
                        _incidenciaEditar == null
                            ? "Incidencia registrada correctamente."
                            : "Incidencia actualizada correctamente.";


                    MessageBox.Show(
                        mensaje,
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


                    DialogResult =
                        DialogResult.OK;

                    Close();
                }
                else
                {
                    MessageBox.Show(
                        "No fue posible guardar la incidencia.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
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

        private void FrmNuevaIncidencia_Load_1(
            object sender,
            EventArgs e)
        {

        }
    }
}