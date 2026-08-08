using SGA.Application.Dtos.Conductor;
using SGA.Presentation.Desktop.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace SGA.Presentation.Desktop.Forms.Conductor
{
    public partial class FrmConductorPrincipal : Form
    {
        private readonly IConductorApiService _conductorApiService;

        private List<ConductorDto> _conductores = new();

        public FrmConductorPrincipal(
            IConductorApiService conductorApiService)
        {
            InitializeComponent();

            _conductorApiService = conductorApiService;

            Load += FrmConductorPrincipal_Load;

            btnBuscar.Click += btnBuscar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnNuevo.Click += btnNuevo_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnActualizar.Click += btnActualizar_Click;
            btnDetalles.Click += btnDetalles_Click;
        }

        private async void FrmConductorPrincipal_Load(
            object sender,
            EventArgs e)
        {
            CargarEstados();

            await CargarConductores();
        }

        private void CargarEstados()
        {
            cmbEstado.Items.Clear();

            cmbEstado.Items.Add("Todos");
            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");

            cmbEstado.SelectedIndex = 0;
        }

        private async Task CargarConductores()
        {
            try
            {
                _conductores =
                    await _conductorApiService.GetAllAsync();

                MostrarConductores(_conductores);
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

        private void MostrarConductores(
            IEnumerable<ConductorDto> lista)
        {
            dgvConductores.DataSource = null;

            dgvConductores.DataSource =
                lista.Select(c => new
                {
                    c.Id,
                    c.Nombre,
                    c.Cedula,
                    c.Licencia,
                    c.Telefono,
                    Estado =
                        c.EstadoConductorId == 1
                            ? "Activo"
                            : "Inactivo"
                }).ToList();

            dgvConductores.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvConductores.ClearSelection();
        }

        private void btnBuscar_Click(
            object sender,
            EventArgs e)
        {
            IEnumerable<ConductorDto> resultado =
                _conductores;

            if (!string.IsNullOrWhiteSpace(
                txtBuscarNombre.Text))
            {
                resultado =
                    resultado.Where(c =>
                        !string.IsNullOrWhiteSpace(c.Nombre) &&
                        c.Nombre.Contains(
                            txtBuscarNombre.Text.Trim(),
                            StringComparison.OrdinalIgnoreCase));
            }

            if (cmbEstado.SelectedItem != null &&
                cmbEstado.SelectedItem.ToString() != "Todos")
            {
                int estado =
                    cmbEstado.SelectedItem.ToString() == "Activo"
                        ? 1
                        : 2;

                resultado =
                    resultado.Where(c =>
                        c.EstadoConductorId == estado);
            }

            MostrarConductores(resultado);
        }

        private async void btnLimpiar_Click(
            object sender,
            EventArgs e)
        {
            txtBuscarNombre.Clear();

            cmbEstado.SelectedIndex = 0;

            await CargarConductores();
        }

        private void btnNuevo_Click(
            object sender,
            EventArgs e)
        {
            using var formulario =
                Program.ServiceProvider
                    .GetRequiredService<FrmNuevoConductor>();

            if (formulario.ShowDialog() == DialogResult.OK)
            {
                _ = CargarConductores();
            }
        }

        private async void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            if (dgvConductores.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un conductor.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int id =
                Convert.ToInt32(
                    dgvConductores.CurrentRow
                        .Cells["Id"]
                        .Value);

            var confirmar =
                MessageBox.Show(
                    "¿Desea eliminar este conductor?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes)
                return;

            try
            {
                bool eliminado =
                    await _conductorApiService
                        .DeleteAsync(id);

                if (eliminado)
                {
                    MessageBox.Show(
                        "Conductor eliminado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    await CargarConductores();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo eliminar el conductor.",
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
            if (dgvConductores.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un conductor.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int id =
                Convert.ToInt32(
                    dgvConductores.CurrentRow
                        .Cells["Id"]
                        .Value);

            using var formulario =
                Program.ServiceProvider
                    .GetRequiredService<FrmNuevoConductor>();

            formulario.CargarConductor(id);

            if (formulario.ShowDialog() == DialogResult.OK)
            {
                await CargarConductores();
            }
        }

        private void btnDetalles_Click(
            object sender,
            EventArgs e)
        {
            if (dgvConductores.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un conductor.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int id =
                Convert.ToInt32(
                    dgvConductores
                        .CurrentRow
                        .Cells["Id"]
                        .Value);

            using var formulario =
                Program.ServiceProvider
                    .GetRequiredService<FrmDetalleConductor>();

            formulario.CargarConductor(id);

            formulario.ShowDialog();
        }

        private void dgvConductores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}