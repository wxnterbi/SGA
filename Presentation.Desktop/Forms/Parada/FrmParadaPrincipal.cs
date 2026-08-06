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
                    await _paradaApiService.GetAllAsync();

                dgvParadas.DataSource = null;

                dgvParadas.DataSource =
                    _paradas.Select(p => new
                    {
                        p.Id,
                        p.Nombre,
                        p.Ubicacion,
                        p.Orden
                    }).ToList();

                ConfigurarGrid();

                _paradaSeleccionadaId = 0;
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
            dgvParadas.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvParadas.Columns["Id"].HeaderText = "ID";
            dgvParadas.Columns["Nombre"].HeaderText = "Nombre";
            dgvParadas.Columns["Ubicacion"].HeaderText = "Ubicación";
            dgvParadas.Columns["Orden"].HeaderText = "Orden";

            dgvParadas.ClearSelection();
        }



        private void dgvParadas_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _paradaSeleccionadaId =
                    Convert.ToInt32(
                        dgvParadas.Rows[e.RowIndex]
                        .Cells["Id"].Value);
            }
        }



        private void btnNuevaParada_Click(
            object sender,
            EventArgs e)
        {
            using var formulario =
                Program.ServiceProvider
                .GetRequiredService<FrmNuevaParada>();

            if (formulario.ShowDialog() == DialogResult.OK)
            {
                _ = CargarParadas();
            }
        }



        private async void btnDetalles_Click(
            object sender,
            EventArgs e)
        {
            if (_paradaSeleccionadaId == 0)
            {
                MessageBox.Show("Seleccione una parada.");
                return;
            }

            var parada =
                await _paradaApiService
                .GetByIdAsync(_paradaSeleccionadaId);

            if (parada != null)
            {
                using var formulario =
                    new FrmDetalleParada(parada);

                formulario.ShowDialog();
            }
        }



        private async void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            if (_paradaSeleccionadaId == 0)
            {
                MessageBox.Show("Seleccione una parada.");
                return;
            }

            var respuesta =
                MessageBox.Show(
                    "¿Desea eliminar esta parada?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                await _paradaApiService
                    .DeleteAsync(_paradaSeleccionadaId);

                await CargarParadas();
            }
        }



        private async void btnActualizar_Click(
            object sender,
            EventArgs e)
        {
            if (_paradaSeleccionadaId == 0)
            {
                MessageBox.Show("Seleccione una parada.");
                return;
            }

            var parada =
                await _paradaApiService
                .GetByIdAsync(_paradaSeleccionadaId);

            if (parada == null)
            {
                MessageBox.Show("No se encontró la parada.");
                return;
            }

            using var formulario =
                new FrmNuevaParada(
                    _paradaApiService,
                    parada);

            if (formulario.ShowDialog() == DialogResult.OK)
            {
                await CargarParadas();
            }
        }

        private void dgvParadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmParadaPrincipal_Load_1(object sender, EventArgs e)
        {

        }
    }
}