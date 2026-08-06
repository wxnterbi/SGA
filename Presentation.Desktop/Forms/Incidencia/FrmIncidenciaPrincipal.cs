using Microsoft.Extensions.DependencyInjection;
using SGA.Application.Dtos.Incidencia;
using SGA.Domain.Enums.Reservation;
using SGA.Presentation.Desktop.Interfaces;

namespace SGA.Presentation.Desktop.Forms.Incidencia
{
    public partial class FrmIncidenciaPrincipal : Form
    {
        private readonly IIncidenciaApiService _incidenciaApiService;
        private readonly IViajeApiService _viajeApiService;
        private readonly IConductorApiService _conductorApiService;

        private List<IncidenciaDto> _incidencias = new();

        private int _incidenciaSeleccionadaId = 0;

        public FrmIncidenciaPrincipal(
            IIncidenciaApiService incidenciaApiService,
            IViajeApiService viajeApiService,
            IConductorApiService conductorApiService)
        {
            InitializeComponent();

            _incidenciaApiService = incidenciaApiService;
            _viajeApiService = viajeApiService;
            _conductorApiService = conductorApiService;

            Load += FrmIncidenciaPrincipal_Load;

            btnNuevaIncidencia.Click += btnNuevaIncidencia_Click;
            btnDetalles.Click += btnDetalles_Click;
            btnActualizar.Click += btnActualizar_Click;
            btnEliminar.Click += btnEliminar_Click;

            dgvIncidencias.CellClick += dgvIncidencias_CellClick;
        }

        private async void FrmIncidenciaPrincipal_Load(
            object sender,
            EventArgs e)
        {
            await CargarIncidencias();
        }

        private async Task CargarIncidencias()
        {
            try
            {
                _incidencias =
                    await _incidenciaApiService.GetAllAsync();

                dgvIncidencias.DataSource = null;

                dgvIncidencias.DataSource =
                    _incidencias.Select(i => new
                    {
                        i.Id,
                        i.ViajeId,
                        i.ConductorId,
                        Tipo = ((TipoIncidencia)i.Tipo).ToString(),
                        i.Descripcion,
                        i.FechaHora
                    }).ToList();

                dgvIncidencias.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvIncidencias.ClearSelection();

                _incidenciaSeleccionadaId = 0;
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

        private void dgvIncidencias_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _incidenciaSeleccionadaId =
                    Convert.ToInt32(
                        dgvIncidencias.Rows[e.RowIndex]
                        .Cells["Id"].Value);
            }
        }

        private void dgvIncidencias_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {

        }

        private void FrmIncidenciaPrincipal_Load_1(
            object sender,
            EventArgs e)
        {

        }

        private void btnNuevaIncidencia_Click(
            object sender,
            EventArgs e)
        {
            using var formulario =
                new FrmNuevaIncidencia(
                    _incidenciaApiService,
                    _viajeApiService,
                    _conductorApiService);

            if (formulario.ShowDialog() == DialogResult.OK)
            {
                _ = CargarIncidencias();
            }
        }

        private async void btnDetalles_Click(
            object sender,
            EventArgs e)
        {
            if (_incidenciaSeleccionadaId == 0)
            {
                MessageBox.Show(
                    "Seleccione una incidencia.");

                return;
            }

            var incidencia =
                await _incidenciaApiService
                .GetByIdAsync(_incidenciaSeleccionadaId);

            if (incidencia != null)
            {
                using var formulario =
                    new FrmDetalleIncidencia(incidencia);

                formulario.ShowDialog();
            }
        }

        private async void btnActualizar_Click(
            object sender,
            EventArgs e)
        {
            if (_incidenciaSeleccionadaId == 0)
            {
                MessageBox.Show(
                    "Seleccione una incidencia.");

                return;
            }

            var incidencia =
                await _incidenciaApiService
                .GetByIdAsync(_incidenciaSeleccionadaId);

            if (incidencia == null)
            {
                MessageBox.Show(
                    "No se encontró la incidencia.");

                return;
            }

            using var formulario =
                new FrmNuevaIncidencia(
                    _incidenciaApiService,
                    _viajeApiService,
                    _conductorApiService,
                    incidencia);

            if (formulario.ShowDialog() == DialogResult.OK)
            {
                await CargarIncidencias();
            }
        }

        private async void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            if (_incidenciaSeleccionadaId == 0)
            {
                MessageBox.Show(
                    "Seleccione una incidencia.");

                return;
            }

            var respuesta =
                MessageBox.Show(
                    "¿Desea eliminar esta incidencia?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                await _incidenciaApiService
                    .DeleteAsync(_incidenciaSeleccionadaId);

                await CargarIncidencias();
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
