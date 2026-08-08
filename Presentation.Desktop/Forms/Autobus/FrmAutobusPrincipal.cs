using SGA.Application.Dtos.Autobus;
using SGA.Presentation.Desktop.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace SGA.Presentation.Desktop.Forms.Autobus
{
    public partial class FrmAutobusPrincipal : Form
    {
        private readonly IAutobusApiService _autobusApiService;

        private List<AutobusDto> _autobuses = new();

        public FrmAutobusPrincipal(
            IAutobusApiService autobusApiService)
        {
            InitializeComponent();

            _autobusApiService = autobusApiService;

            Load += FrmAutobusPrincipal_Load;

            btnNuevoAutobus.Click += btnNuevoAutobus_Click;
            btnDetalle.Click += btnDetalle_Click;
            btnEditar.Click += btnEditar_Click;
            btnEliminar.Click += btnEliminar_Click;
        }

        private async void FrmAutobusPrincipal_Load(
            object sender,
            EventArgs e)
        {
            await CargarAutobuses();
        }

        private async Task CargarAutobuses()
        {
            try
            {
                _autobuses =
                    await _autobusApiService.GetAllAsync();

                dgvAutobuses.DataSource = null;

                dgvAutobuses.DataSource =
                    _autobuses.Select(a => new
                    {
                        a.Id,
                        a.Placa,
                        a.Marca,
                        a.Modelo,
                        Capacidad = a.Capacidad,
                        Estado = a.EstadoDescripcion
                    }).ToList();

                ConfigurarGrid();
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

        private void ConfigurarGrid()
        {
            dgvAutobuses.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvAutobuses.Columns["Id"].HeaderText = "ID";
            dgvAutobuses.Columns["Placa"].HeaderText = "Placa";
            dgvAutobuses.Columns["Marca"].HeaderText = "Marca";
            dgvAutobuses.Columns["Modelo"].HeaderText = "Modelo";
            dgvAutobuses.Columns["Capacidad"].HeaderText = "Capacidad";
            dgvAutobuses.Columns["Estado"].HeaderText = "Estado";

            dgvAutobuses.ClearSelection();
        }

        private void btnNuevoAutobus_Click(
            object sender,
            EventArgs e)
        {
            using var formulario =
                Program.ServiceProvider
                    .GetRequiredService<FrmNuevoAutobus>();

            if (formulario.ShowDialog() == DialogResult.OK)
            {
                _ = CargarAutobuses();
            }
        }

        private void btnDetalle_Click(
            object sender,
            EventArgs e)
        {
            if (dgvAutobuses.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un autobús para ver el detalle.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            int id = Convert.ToInt32(
                dgvAutobuses.CurrentRow.Cells["Id"].Value);

            var autobus =
                _autobuses.FirstOrDefault(a => a.Id == id);

            if (autobus == null)
            {
                MessageBox.Show(
                    "No se encontró la información del autobús.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            using var formulario =
                new FrmDetalleAutobus(autobus);

            formulario.ShowDialog();
        }

        private void btnEditar_Click(
            object sender,
            EventArgs e)
        {
            if (dgvAutobuses.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un autobús para editar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int id = Convert.ToInt32(
                dgvAutobuses.CurrentRow.Cells["Id"].Value);

            var autobus =
                _autobuses.FirstOrDefault(a => a.Id == id);

            if (autobus == null)
            {
                MessageBox.Show(
                    "No se encontró el autobús seleccionado.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            using var formulario =
                Program.ServiceProvider
                    .GetRequiredService<FrmNuevoAutobus>();

            formulario.CargarAutobus(autobus);

            if (formulario.ShowDialog() == DialogResult.OK)
            {
                _ = CargarAutobuses();
            }
        }

        private async void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            if (dgvAutobuses.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un autobús para eliminar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int id = Convert.ToInt32(
                dgvAutobuses.CurrentRow.Cells["Id"].Value);

            var confirmar =
                MessageBox.Show(
                    "¿Desea eliminar el autobús seleccionado?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes)
                return;

            var resultado =
                await _autobusApiService.DeleteAsync(id);

            MessageBox.Show(
                resultado.Message,
                resultado.Success ? "Éxito" : "Error",
                MessageBoxButtons.OK,
                resultado.Success
                    ? MessageBoxIcon.Information
                    : MessageBoxIcon.Error);

            if (resultado.Success)
            {
                await CargarAutobuses();
            }
        }

        private void lblTitulo_Click(
            object sender,
            EventArgs e)
        {
        }

        private void dgvAutobuses_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }
    }
}