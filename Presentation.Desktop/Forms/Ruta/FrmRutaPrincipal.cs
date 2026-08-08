using Microsoft.Extensions.DependencyInjection;
using SGA.Application.Dtos.Ruta;
using SGA.Presentation.Desktop.Interfaces;

namespace SGA.Presentation.Desktop.Forms.Ruta
{
    public partial class FrmRutaPrincipal : Form
    {
        private readonly IRutaApiService _rutaApiService;

        private List<RutaDto> _rutas = new();

        private int _rutaSeleccionadaId = 0;

        public FrmRutaPrincipal(
            IRutaApiService rutaApiService)
        {
            InitializeComponent();

            _rutaApiService = rutaApiService;

            Load += FrmRutaPrincipal_Load;

            btnNuevaRuta.Click += btnNuevaRuta_Click;
            btnDetalles.Click += btnDetalles_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnActualizar.Click += btnActualizar_Click;

            dgvRutas.CellClick += dgvRutas_CellClick;
        }

        private async void FrmRutaPrincipal_Load(
            object sender,
            EventArgs e)
        {
            await CargarRutas();
        }

        private async Task CargarRutas()
        {
            try
            {
                btnActualizar.Enabled = false;

                _rutas = await _rutaApiService.GetAllAsync();

                if (_rutas == null || !_rutas.Any())
                {
                    dgvRutas.DataSource = null;
                    MessageBox.Show(
                        "No hay rutas registradas.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                dgvRutas.DataSource = null;

                dgvRutas.DataSource =
                    _rutas.Select(r => new
                    {
                        r.Id,
                        r.Nombre,
                        r.Origen,
                        r.Destino
                    }).ToList();

                ConfigurarGrid();

                _rutaSeleccionadaId = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al cargar rutas:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnActualizar.Enabled = true;
            }
        }

        private void ConfigurarGrid()
        {
            dgvRutas.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvRutas.Columns["Id"].HeaderText = "ID";
            dgvRutas.Columns["Nombre"].HeaderText = "Nombre";
            dgvRutas.Columns["Origen"].HeaderText = "Origen";
            dgvRutas.Columns["Destino"].HeaderText = "Destino";

            dgvRutas.ClearSelection();
        }

        private void dgvRutas_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                var valor =
                    dgvRutas.Rows[e.RowIndex]
                    .Cells["Id"].Value;

                if (valor == null)
                {
                    _rutaSeleccionadaId = 0;
                    return;
                }

                _rutaSeleccionadaId =
                    Convert.ToInt32(valor);
            }
            catch
            {
                _rutaSeleccionadaId = 0;
            }
        }
        private void btnNuevaRuta_Click(
            object sender,
            EventArgs e)
        {
            using var formulario =
                Program.ServiceProvider
                .GetRequiredService<FrmNuevaRuta>();

            if (formulario.ShowDialog() == DialogResult.OK)
            {
                _ = CargarRutas();
            }
        }

        private async void btnDetalles_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidarSeleccion()) return;

            try
            {
                var ruta =
                    await _rutaApiService
                    .GetByIdAsync(_rutaSeleccionadaId);

                if (ruta == null)
                {
                    MessageBox.Show(
                        "La ruta no existe o fue eliminada.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    await CargarRutas();
                    return;
                }

                using var formulario =
                    new FrmDetalleRuta(ruta);

                formulario.ShowDialog();
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

        private async void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidarSeleccion()) return;

            var confirmar =
                MessageBox.Show(
                    "¿Desea eliminar esta ruta?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes)
                return;

            try
            {
                await _rutaApiService
                    .DeleteAsync(_rutaSeleccionadaId);

                MessageBox.Show(
                    "Ruta eliminada correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                await CargarRutas();
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

        private async void btnActualizar_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidarSeleccion()) return;

            try
            {
                var ruta =
                    await _rutaApiService
                    .GetByIdAsync(_rutaSeleccionadaId);

                if (ruta == null)
                {
                    MessageBox.Show(
                        "La ruta no existe.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                using var formulario =
                    new FrmNuevaRuta(
                        _rutaApiService,
                        ruta);

                if (formulario.ShowDialog() == DialogResult.OK)
                {
                    await CargarRutas();
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

        private bool ValidarSeleccion()
        {
            if (_rutaSeleccionadaId == 0)
            {
                MessageBox.Show(
                    "Seleccione una ruta.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private void FrmRutaPrincipal_Load_1(object sender, EventArgs e)
        {

        }
    }
}
