using Microsoft.Extensions.DependencyInjection;
using SGA.Application.Dtos.Horario;
using SGA.Presentation.Desktop.Interfaces;
using SGA.Presentation.Desktop.Helpers;

namespace SGA.Presentation.Desktop.Forms.Horario
{
    public partial class FrmHorarioPrincipal : Form
    {
        private readonly IHorarioApiService _horarioApiService;

        private List<HorarioDto> _horarios = new();

        private int _horarioSeleccionadoId = 0;


        public FrmHorarioPrincipal(
            IHorarioApiService horarioApiService)
        {
            InitializeComponent();

            ButtonStyleHelper.AplicarEstilo(
                btnNuevoHorario,
                Color.FromArgb(40, 167, 69));


            ButtonStyleHelper.AplicarEstilo(
                btnDetalles,
                Color.FromArgb(33, 150, 243));


            ButtonStyleHelper.AplicarEstilo(
                btnEliminar,
                Color.Firebrick);


            ButtonStyleHelper.AplicarEstilo(
                btnActualizar,
                Color.Gray);

            _horarioApiService = horarioApiService;


            Load += FrmHorarioPrincipal_Load;

            btnNuevoHorario.Click += btnNuevoHorario_Click;
            btnDetalles.Click += btnDetalles_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnActualizar.Click += btnActualizar_Click;

            dgvHorarios.CellClick += dgvHorarios_CellClick;
        }



        private async void FrmHorarioPrincipal_Load(
            object sender,
            EventArgs e)
        {
            await CargarHorarios();
        }



        private async Task CargarHorarios()
        {
            try
            {
                _horarios =
                    await _horarioApiService.GetAllAsync();


                dgvHorarios.DataSource = null;


                dgvHorarios.DataSource =
                    _horarios.Select(h => new
                    {
                        h.Id,
                        Dias = h.DiasOperacion,
                        Hora = h.HoraSalida.ToString(@"hh\:mm"),
                        Ruta = h.NombreRuta

                    }).ToList();


                ConfigurarGrid();

                _horarioSeleccionadoId = 0;
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
            dgvHorarios.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;


            dgvHorarios.Columns["Id"].HeaderText = "ID";
            dgvHorarios.Columns["Dias"].HeaderText = "Días de operación";
            dgvHorarios.Columns["Hora"].HeaderText = "Hora salida";
            dgvHorarios.Columns["Ruta"].HeaderText = "Ruta";


            dgvHorarios.ClearSelection();
        }



        private void dgvHorarios_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _horarioSeleccionadoId =
                    Convert.ToInt32(
                        dgvHorarios.Rows[e.RowIndex]
                        .Cells["Id"].Value);
            }
        }



        private void btnNuevoHorario_Click(
            object sender,
            EventArgs e)
        {
            using var formulario =
                Program.ServiceProvider
                .GetRequiredService<FrmNuevoHorario>();


            if (formulario.ShowDialog() == DialogResult.OK)
            {
                _ = CargarHorarios();
            }
        }



        private async void btnDetalles_Click(
            object sender,
            EventArgs e)
        {
            if (_horarioSeleccionadoId == 0)
            {
                MessageBox.Show(
                    "Seleccione un horario.");

                return;
            }


            var horario =
                await _horarioApiService
                .GetByIdAsync(_horarioSeleccionadoId);


            if (horario != null)
            {
                using var formulario =
                    new FrmDetalleHorario(horario);

                formulario.ShowDialog();
            }
        }



        private async void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            if (_horarioSeleccionadoId == 0)
            {
                MessageBox.Show(
                    "Seleccione un horario.");

                return;
            }


            var confirmar =
                MessageBox.Show(
                    "¿Desea eliminar este horario?",
                    "Confirmar",
                    MessageBoxButtons.YesNo);


            if (confirmar == DialogResult.Yes)
            {
                await _horarioApiService
                    .DeleteAsync(_horarioSeleccionadoId);


                await CargarHorarios();
            }
        }



        private async void btnActualizar_Click(
            object sender,
            EventArgs e)
        {
            if (_horarioSeleccionadoId == 0)
            {
                MessageBox.Show(
                    "Seleccione un horario.");

                return;
            }


            var horario =
                await _horarioApiService
                .GetByIdAsync(
                    _horarioSeleccionadoId);



            if (horario == null)
            {
                MessageBox.Show(
                    "No se encontró el horario.");

                return;
            }



            using var formulario =
                new FrmNuevoHorario(
                    _horarioApiService,
                    Program.ServiceProvider
                    .GetRequiredService<IRutaApiService>(),
                    horario);



            if (formulario.ShowDialog() == DialogResult.OK)
            {
                await CargarHorarios();
            }
        }

        private void dgvHorarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmHorarioPrincipal_Load_1(object sender, EventArgs e)
        {

        }

        private void FrmHorarioPrincipal_Load_2(object sender, EventArgs e)
        {

        }
    }
}