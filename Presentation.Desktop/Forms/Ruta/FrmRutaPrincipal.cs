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
                _rutas =
                    await _rutaApiService.GetAllAsync();


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
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void ConfigurarGrid()
        {
            dgvRutas.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;


            dgvRutas.Columns["Id"].HeaderText =
                "ID";


            dgvRutas.Columns["Nombre"].HeaderText =
                "Nombre";


            dgvRutas.Columns["Origen"].HeaderText =
                "Origen";


            dgvRutas.Columns["Destino"].HeaderText =
                "Destino";


            dgvRutas.ClearSelection();
        }


        private void dgvRutas_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _rutaSeleccionadaId =
                    Convert.ToInt32(
                        dgvRutas.Rows[e.RowIndex]
                        .Cells["Id"].Value);
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
            if (_rutaSeleccionadaId == 0)
            {
                MessageBox.Show(
                    "Seleccione una ruta.");

                return;
            }


            var ruta =
                await _rutaApiService
                .GetByIdAsync(_rutaSeleccionadaId);


            if (ruta != null)
            {
                using var formulario =
                    new FrmDetalleRuta(ruta);


                formulario.ShowDialog();
            }
        }


        private async void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            if (_rutaSeleccionadaId == 0)
            {
                MessageBox.Show(
                    "Seleccione una ruta.");

                return;
            }


            var confirmar =
                MessageBox.Show(
                    "¿Desea eliminar esta ruta?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);



            if (confirmar == DialogResult.Yes)
            {
                await _rutaApiService
                    .DeleteAsync(_rutaSeleccionadaId);


                await CargarRutas();
            }
        }


        private async void btnActualizar_Click(
            object sender,
            EventArgs e)
        {
            if (_rutaSeleccionadaId == 0)
            {
                MessageBox.Show(
                    "Seleccione una ruta.");

                return;
            }

            var ruta =
                await _rutaApiService
                .GetByIdAsync(_rutaSeleccionadaId);



            if (ruta == null)
            {
                MessageBox.Show(
                    "No se encontró la ruta.");

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

        private void FrmRutaPrincipal_Load_1(object sender, EventArgs e)
        {

        }
    }
}
