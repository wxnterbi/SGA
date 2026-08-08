using Microsoft.Extensions.DependencyInjection;
using SGA.Application.Dtos.Parada;
using SGA.Presentation.Desktop.Interfaces;

namespace SGA.Presentation.Desktop.Forms.Parada
{
    public partial class FrmParadaPrincipal : Form
    {
        private readonly IParadaApiService _paradaApiService;

        private List<ParadaDto> _paradas = new();

        private int _paradaSeleccionadaId = 0;

        private bool _procesando = false;


        public FrmParadaPrincipal(
            IParadaApiService paradaApiService)
        {
            InitializeComponent();

            _paradaApiService = paradaApiService;

            Load += FrmParadaPrincipal_Load;

            btnNuevaParada.Click += btnNuevaParada_Click;
            btnDetalles.Click += btnDetalles_Click;
            btnActualizar.Click += btnActualizar_Click;
            btnEliminar.Click += btnEliminar_Click;

            dgvParadas.CellClick += dgvParadas_CellClick;
        }


        private async void FrmParadaPrincipal_Load(
            object sender,
            EventArgs e)
        {
            await CargarParadas();
        }


        private async Task CargarParadas()
        {
            try
            {
                _paradas =
                    await _paradaApiService
                    .GetAllAsync();


                if (_paradas == null)
                {
                    _paradas =
                        new List<ParadaDto>();
                }


                dgvParadas.DataSource = null;


                dgvParadas.DataSource =
                    _paradas
                    .Select(p => new
                    {
                        p.Id,
                        p.Nombre,
                        p.Ubicacion,
                        p.Orden
                    })
                    .ToList();


                ConfigurarGrid();


                _paradaSeleccionadaId = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ObtenerMensajeError(ex),
                    "Error cargando paradas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void ConfigurarGrid()
        {
            dgvParadas.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;


            if (dgvParadas.Columns.Contains("Id"))
            {
                dgvParadas.Columns["Id"].HeaderText =
                    "ID";
            }


            if (dgvParadas.Columns.Contains("Nombre"))
            {
                dgvParadas.Columns["Nombre"].HeaderText =
                    "Nombre";
            }


            if (dgvParadas.Columns.Contains("Ubicacion"))
            {
                dgvParadas.Columns["Ubicacion"].HeaderText =
                    "Ubicación";
            }


            if (dgvParadas.Columns.Contains("Orden"))
            {
                dgvParadas.Columns["Orden"].HeaderText =
                    "Orden";
            }


            dgvParadas.ClearSelection();
        }


        private void dgvParadas_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


            try
            {
                object? valor =
                    dgvParadas
                    .Rows[e.RowIndex]
                    .Cells["Id"]
                    .Value;


                if (valor == null)
                {
                    _paradaSeleccionadaId = 0;
                    return;
                }


                if (!int.TryParse(
                    valor.ToString(),
                    out int id))
                {
                    _paradaSeleccionadaId = 0;
                    return;
                }


                _paradaSeleccionadaId = id;
            }
            catch
            {
                _paradaSeleccionadaId = 0;
            }
        }


        private bool ValidarSeleccion()
        {
            if (_paradaSeleccionadaId <= 0)
            {
                MessageBox.Show(
                    "Seleccione una parada de la lista.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }


            return true;
        }


        private void btnNuevaParada_Click(
            object sender,
            EventArgs e)
        {
            if (_procesando)
                return;


            try
            {
                using var formulario =
                    Program.ServiceProvider
                    .GetRequiredService<FrmNuevaParada>();


                if (formulario.ShowDialog()
                    == DialogResult.OK)
                {
                    _ = CargarParadas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ObtenerMensajeError(ex),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private async void btnDetalles_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidarSeleccion())
                return;


            try
            {
                var parada =
                    await _paradaApiService
                    .GetByIdAsync(
                        _paradaSeleccionadaId);


                if (parada == null)
                {
                    MessageBox.Show(
                        "No se encontró la parada seleccionada.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    await CargarParadas();

                    return;
                }


                using var formulario =
                    new FrmDetalleParada(parada);


                formulario.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ObtenerMensajeError(ex),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private async void btnActualizar_Click(
            object sender,
            EventArgs e)
        {
            if (_procesando)
                return;


            if (!ValidarSeleccion())
                return;


            try
            {
                _procesando = true;

                btnActualizar.Enabled = false;


                var parada =
                    await _paradaApiService
                    .GetByIdAsync(
                        _paradaSeleccionadaId);


                if (parada == null)
                {
                    MessageBox.Show(
                        "No se encontró la parada seleccionada.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


                using var formulario =
                    new FrmNuevaParada(
                        _paradaApiService,
                        parada);


                if (formulario.ShowDialog()
                    == DialogResult.OK)
                {
                    await CargarParadas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ObtenerMensajeError(ex),
                    "Error actualizando parada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                _procesando = false;

                if (!IsDisposed)
                    btnActualizar.Enabled = true;
            }
        }


        private async void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            if (_procesando)
                return;


            if (!ValidarSeleccion())
                return;


            try
            {
                var parada =
                    await _paradaApiService
                    .GetByIdAsync(
                        _paradaSeleccionadaId);


                if (parada == null)
                {
                    MessageBox.Show(
                        "La parada seleccionada ya no existe.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    await CargarParadas();

                    return;
                }


                var respuesta =
                    MessageBox.Show(
                        $"¿Desea eliminar la parada \"{parada.Nombre}\"?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);


                if (respuesta != DialogResult.Yes)
                    return;


                _procesando = true;

                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;
                btnDetalles.Enabled = false;


                bool resultado =
                    await _paradaApiService
                    .DeleteAsync(
                        _paradaSeleccionadaId);


                if (resultado)
                {
                    MessageBox.Show(
                        "Parada eliminada correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


                    await CargarParadas();

                    return;
                }


                MessageBox.Show(
                    "No fue posible eliminar la parada.",
                    "No se puede eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ObtenerMensajeErrorEliminar(ex),
                    "No se puede eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            finally
            {
                _procesando = false;

                if (!IsDisposed)
                {
                    btnEliminar.Enabled = true;
                    btnActualizar.Enabled = true;
                    btnDetalles.Enabled = true;
                }
            }
        }


        private string ObtenerMensajeError(
            Exception ex)
        {
            if (string.IsNullOrWhiteSpace(ex.Message))
            {
                return "Ocurrió un error inesperado.";
            }


            return ex.Message;
        }


        private string ObtenerMensajeErrorEliminar(
            Exception ex)
        {
            string mensaje =
                ex.Message ?? string.Empty;


            string texto =
                mensaje.ToLowerInvariant();


            if (texto.Contains("foreign key") ||
                texto.Contains("constraint") ||
                texto.Contains("reference") ||
                texto.Contains("referenced"))
            {
                return
                    "No se puede eliminar esta parada porque está siendo utilizada por otro registro del sistema.\n\n" +
                    "Primero debe eliminar o modificar los registros que dependen de esta parada.";
            }


            if (texto.Contains("fk_"))
            {
                return
                    "No se puede eliminar esta parada porque existen registros relacionados con ella.";
            }


            if (string.IsNullOrWhiteSpace(mensaje))
            {
                return
                    "No se puede eliminar la parada porque tiene información relacionada.";
            }


            return mensaje;
        }


        private void dgvParadas_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }


        private void FrmParadaPrincipal_Load_1(
            object sender,
            EventArgs e)
        {
        }
    }
}