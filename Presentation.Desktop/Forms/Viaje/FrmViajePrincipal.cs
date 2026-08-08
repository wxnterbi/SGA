using SGA.Application.Dtos.Viaje;
using SGA.Domain.Enums.Reservation;
using SGA.Presentation.Desktop.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace SGA.Presentation.Desktop.Forms.Viaje
{
    public partial class FrmViajePrincipal : Form
    {
        private readonly IViajeApiService _viajeApiService;

        private List<ViajeDto> _viajes = new();

        public FrmViajePrincipal(
            IViajeApiService viajeApiService)
        {
            InitializeComponent();

            _viajeApiService =
                viajeApiService;

            Load += FrmViajePrincipal_Load;

            btnNuevoViaje.Click += btnNuevo_Click;
            btnBuscar.Click += btnBuscar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnDetalles.Click += btnDetalles_Click;

            btnIniciar.Click += btnIniciar_Click;
            btnFinalizar.Click += btnFinalizar_Click;
            btnCancelar.Click += btnCancelar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnActualizar.Click += btnActualizar_Click;
        }

        private async void FrmViajePrincipal_Load(
            object sender,
            EventArgs e)
        {
            CargarEstados();

            await CargarViajes();
        }

        private void CargarEstados()
        {
            cmbEstado.Items.Clear();

            cmbEstado.Items.Add("Todos");
            cmbEstado.Items.Add("Programado");
            cmbEstado.Items.Add("EnCurso");
            cmbEstado.Items.Add("Finalizado");
            cmbEstado.Items.Add("Cancelado");

            cmbEstado.SelectedIndex = 0;
        }

        private async Task CargarViajes()
        {
            try
            {
                _viajes =
                    await _viajeApiService
                        .GetAllAsync();

                MostrarViajes(_viajes);
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

        private void MostrarViajes(
            IEnumerable<ViajeDto> lista)
        {
            dgvViajes.DataSource = null;

            dgvViajes.DataSource =
                lista.Select(v => new
                {
                    v.Id,

                    Estado =
                        v.Estado.ToString(),

                    Horario =
                        v.HorarioTexto,

                    Ruta =
                        v.NombreRuta,

                    Autobus =
                        v.PlacaAutobus,

                    Conductor =
                        v.NombreConductor
                }).ToList();

            dgvViajes.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvViajes.ClearSelection();
        }

        private int ObtenerIdSeleccionado()
        {
            if (dgvViajes.CurrentRow == null)
            {
                MessageBox.Show(
                    "Debe seleccionar un viaje.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return 0;
            }

            var valor =
                dgvViajes.CurrentRow
                    .Cells["Id"]
                    .Value;

            if (valor == null ||
                !int.TryParse(
                    valor.ToString(),
                    out int id) ||
                id <= 0)
            {
                MessageBox.Show(
                    "El viaje seleccionado no es válido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return 0;
            }

            return id;
        }

        private async Task CambiarEstado(
            EstadoViaje estado)
        {
            int id =
                ObtenerIdSeleccionado();

            if (id == 0)
                return;

            try
            {
                var viaje =
                    await _viajeApiService
                        .GetByIdAsync(id);

                if (viaje == null)
                {
                    MessageBox.Show(
                        "No se encontró el viaje.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                viaje.Estado =
                    estado;

                bool resultado =
                    await _viajeApiService
                        .UpdateAsync(viaje);

                if (resultado)
                {
                    MessageBox.Show(
                        "Estado actualizado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    await CargarViajes();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo actualizar el viaje.",
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

        private async void btnIniciar_Click(
            object sender,
            EventArgs e)
        {
            int id =
                ObtenerIdSeleccionado();

            if (id == 0)
                return;

            try
            {
                var viaje =
                    await _viajeApiService
                        .GetByIdAsync(id);

                if (viaje == null)
                {
                    MessageBox.Show(
                        "No se encontró el viaje.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (viaje.Estado !=
                    EstadoViaje.Programado)
                {
                    MessageBox.Show(
                        "Solo se puede iniciar un viaje programado.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                await CambiarEstado(
                    EstadoViaje.EnCurso);
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

        private async void btnFinalizar_Click(
            object sender,
            EventArgs e)
        {
            int id =
                ObtenerIdSeleccionado();

            if (id == 0)
                return;

            try
            {
                var viaje =
                    await _viajeApiService
                        .GetByIdAsync(id);

                if (viaje == null)
                {
                    MessageBox.Show(
                        "No se encontró el viaje.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (viaje.Estado !=
                    EstadoViaje.EnCurso)
                {
                    MessageBox.Show(
                        "Solo se puede finalizar un viaje que esté en curso.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                await CambiarEstado(
                    EstadoViaje.Finalizado);
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

        private async void btnCancelar_Click(
            object sender,
            EventArgs e)
        {
            int id =
                ObtenerIdSeleccionado();

            if (id == 0)
                return;

            try
            {
                var viaje =
                    await _viajeApiService
                        .GetByIdAsync(id);

                if (viaje == null)
                {
                    MessageBox.Show(
                        "No se encontró el viaje.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (viaje.Estado ==
                    EstadoViaje.Finalizado)
                {
                    MessageBox.Show(
                        "No se puede cancelar un viaje finalizado.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (viaje.Estado ==
                    EstadoViaje.Cancelado)
                {
                    MessageBox.Show(
                        "El viaje ya está cancelado.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                await CambiarEstado(
                    EstadoViaje.Cancelado);
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
            int id =
                ObtenerIdSeleccionado();

            if (id == 0)
                return;

            try
            {
                var viaje =
                    await _viajeApiService
                        .GetByIdAsync(id);

                if (viaje == null)
                {
                    MessageBox.Show(
                        "No se encontró el viaje.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (viaje.Estado ==
                    EstadoViaje.EnCurso)
                {
                    MessageBox.Show(
                        "No se puede eliminar un viaje que está en curso.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                var confirmar =
                    MessageBox.Show(
                        "¿Desea eliminar este viaje?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (confirmar !=
                    DialogResult.Yes)
                {
                    return;
                }

                bool eliminado =
                    await _viajeApiService
                        .DeleteAsync(id);

                if (eliminado)
                {
                    MessageBox.Show(
                        "Viaje eliminado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    await CargarViajes();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo eliminar el viaje.",
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

        private async void btnActualizar_Click(
            object sender,
            EventArgs e)
        {
            await CargarViajes();
        }

        private void btnDetalles_Click(
            object sender,
            EventArgs e)
        {
            int id =
                ObtenerIdSeleccionado();

            if (id == 0)
                return;

            using var formulario =
                Program.ServiceProvider
                    .GetRequiredService<FrmDetalleViaje>();

            formulario.CargarViaje(id);

            formulario.ShowDialog();
        }

        private async void btnBuscar_Click(
            object sender,
            EventArgs e)
        {
            IEnumerable<ViajeDto> resultado =
                _viajes;


            if (cmbEstado.SelectedItem != null &&
                cmbEstado.SelectedItem
                    .ToString() != "Todos")
            {
                string estado =
                    cmbEstado.SelectedItem.ToString()!;

                resultado =
                    resultado.Where(v =>
                        v.Estado.ToString()
                        == estado);
            }

            string textoBusqueda =
                txtBuscarRuta.Text.Trim();

            if (!string.IsNullOrWhiteSpace(
                textoBusqueda))
            {
                resultado =
                    resultado.Where(v =>
                        !string.IsNullOrWhiteSpace(
                            v.NombreRuta) &&
                        v.NombreRuta.Contains(
                            textoBusqueda,
                            StringComparison
                                .OrdinalIgnoreCase));
            }

            MostrarViajes(resultado);
        }

        private async void btnLimpiar_Click(
            object sender,
            EventArgs e)
        {
            cmbEstado.SelectedIndex = 0;

            txtBuscarRuta.Clear();

            dtpFecha.Value =
                DateTime.Now;

            await CargarViajes();
        }

        private async void btnNuevo_Click(
            object sender,
            EventArgs e)
        {
            using var formulario =
                Program.ServiceProvider
                    .GetRequiredService<
                        FrmNuevoViaje>();

            if (formulario.ShowDialog()
                == DialogResult.OK)
            {
                await CargarViajes();
            }
        }

        private void FrmViajePrincipal_Load_1(
            object sender,
            EventArgs e)
        {
        }

        private void dgvViajes_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }
    }
}

