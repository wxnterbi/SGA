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


            _horarioApiService = horarioApiService;



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


                if (_horarios == null)
                {
                    _horarios = new List<HorarioDto>();
                }


                dgvHorarios.DataSource = null;


                dgvHorarios.DataSource =
                    _horarios
                    .Select(h => new
                    {
                        h.Id,

                        Dias = h.DiasOperacion,

                        Hora = h.HoraSalida
                            .ToString(@"hh\:mm"),

                        Ruta = h.NombreRuta
                    })
                    .ToList();


                ConfigurarGrid();


                _horarioSeleccionadoId = 0;


                dgvHorarios.ClearSelection();
            }
            catch (Exception ex)
            {
                MostrarError(
                    ex,
                    "No fue posible cargar los horarios.");
            }
        }


 

        private void ConfigurarGrid()
        {
            if (dgvHorarios.Columns.Count == 0)
                return;


            dgvHorarios.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;


            if (dgvHorarios.Columns.Contains("Id"))
            {
                dgvHorarios.Columns["Id"].HeaderText =
                    "ID";
            }


            if (dgvHorarios.Columns.Contains("Dias"))
            {
                dgvHorarios.Columns["Dias"].HeaderText =
                    "Días de operación";
            }


            if (dgvHorarios.Columns.Contains("Hora"))
            {
                dgvHorarios.Columns["Hora"].HeaderText =
                    "Hora salida";
            }


            if (dgvHorarios.Columns.Contains("Ruta"))
            {
                dgvHorarios.Columns["Ruta"].HeaderText =
                    "Ruta";
            }


            dgvHorarios.ClearSelection();
        }



        private void dgvHorarios_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


            try
            {
                var valor =
                    dgvHorarios
                    .Rows[e.RowIndex]
                    .Cells["Id"]
                    .Value;


                if (valor == null)
                {
                    _horarioSeleccionadoId = 0;
                    return;
                }


                if (int.TryParse(
                    valor.ToString(),
                    out int id))
                {
                    _horarioSeleccionadoId = id;
                }
                else
                {
                    _horarioSeleccionadoId = 0;
                }
            }
            catch
            {
                _horarioSeleccionadoId = 0;
            }
        }



        private void btnNuevoHorario_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                using var formulario =
                    Program.ServiceProvider
                    .GetRequiredService<FrmNuevoHorario>();


                if (formulario.ShowDialog() ==
                    DialogResult.OK)
                {
                    _ = CargarHorarios();
                }
            }
            catch (Exception ex)
            {
                MostrarError(
                    ex,
                    "No fue posible abrir el formulario de nuevo horario.");
            }
        }



        private async void btnDetalles_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (!ValidarHorarioSeleccionado())
                    return;


                var horario =
                    await _horarioApiService
                    .GetByIdAsync(
                        _horarioSeleccionadoId);


                if (horario == null)
                {
                    MessageBox.Show(
                        "No se encontró el horario seleccionado.",
                        "Horario no encontrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


                using var formulario =
                    new FrmDetalleHorario(horario);


                formulario.ShowDialog();
            }
            catch (Exception ex)
            {
                MostrarError(
                    ex,
                    "No fue posible obtener los detalles del horario.");
            }
        }


  

        private async void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
          

                if (!ValidarHorarioSeleccionado())
                    return;



                var horario =
                    await _horarioApiService
                    .GetByIdAsync(
                        _horarioSeleccionadoId);


                if (horario == null)
                {
                    MessageBox.Show(
                        "El horario seleccionado ya no existe.",
                        "Horario no encontrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    await CargarHorarios();

                    return;
                }



                var confirmar =
                    MessageBox.Show(
                        "¿Está seguro de que desea eliminar este horario?\n\n" +
                        $"Días: {horario.DiasOperacion}\n" +
                        $"Hora: {horario.HoraSalida:hh\\:mm}\n" +
                        $"Ruta: {horario.NombreRuta}",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);


                if (confirmar != DialogResult.Yes)
                    return;



                bool resultado =
                    await _horarioApiService
                    .DeleteAsync(
                        _horarioSeleccionadoId);



                if (resultado)
                {
                    MessageBox.Show(
                        "El horario fue eliminado correctamente.",
                        "Eliminación exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


                    _horarioSeleccionadoId = 0;


                    await CargarHorarios();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo eliminar el horario, este horario está asignado a un ticket mensual.",
                        "No se pudo eliminar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {



                if (EsErrorDeReferencia(ex))
                {
                    MessageBox.Show(
                        "No se puede eliminar este horario.\n\n" +
                        "El horario está siendo utilizado por otro registro " +
                        "en el sistema.\n\n" +
                        "Primero debe eliminar o modificar los registros " +
                        "que dependen de este horario y luego intentar " +
                        "eliminarlo nuevamente.",
                        "Horario en uso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


        

                MostrarError(
                    ex,
                    "No fue posible eliminar el horario");
            }
        }



        private async void btnActualizar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (!ValidarHorarioSeleccionado())
                    return;


                var horario =
                    await _horarioApiService
                    .GetByIdAsync(
                        _horarioSeleccionadoId);


                if (horario == null)
                {
                    MessageBox.Show(
                        "No se encontró el horario seleccionado.",
                        "Horario no encontrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    await CargarHorarios();

                    return;
                }


                var rutaApiService =
                    Program.ServiceProvider
                    .GetRequiredService<IRutaApiService>();


                using var formulario =
                    new FrmNuevoHorario(
                        _horarioApiService,
                        rutaApiService,
                        horario);


                if (formulario.ShowDialog() ==
                    DialogResult.OK)
                {
                    await CargarHorarios();
                }
            }
            catch (Exception ex)
            {
                MostrarError(
                    ex,
                    "No fue posible actualizar el horario.");
            }
        }


     

        private bool ValidarHorarioSeleccionado()
        {
            if (_horarioSeleccionadoId <= 0)
            {
                MessageBox.Show(
                    "Seleccione un horario de la lista antes de continuar.",
                    "Selección requerida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }


            return true;
        }



        private bool EsErrorDeReferencia(
            Exception ex)
        {
            Exception? actual = ex;


            while (actual != null)
            {
                string mensaje =
                    actual.Message.ToLowerInvariant();


                if (mensaje.Contains("foreign key") ||
                    mensaje.Contains("foreignkey") ||
                    mensaje.Contains("constraint") ||
                    mensaje.Contains("referenced") ||
                    mensaje.Contains("reference") ||
                    mensaje.Contains("conflicted") ||
                    mensaje.Contains("conflict") ||
                    mensaje.Contains("delete statement") ||
                    mensaje.Contains("fk_") ||
                    mensaje.Contains("clave foránea") ||
                    mensaje.Contains("clave foranea") ||
                    mensaje.Contains("referencia"))
                {
                    return true;
                }


                actual = actual.InnerException;
            }


            return false;
        }




        private void MostrarError(
            Exception ex,
            string mensajePrincipal)
        {
            string detalle =
                ObtenerMensajeError(ex);


            MessageBox.Show(
                $"{mensajePrincipal}\n\n{detalle}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }




        private string ObtenerMensajeError(
            Exception ex)
        {
            Exception? actual = ex;


            while (actual?.InnerException != null)
            {
                actual = actual.InnerException;
            }


            return actual?.Message
                   ?? ex.Message;
        }




        private void dgvHorarios_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {

        }


        private void FrmHorarioPrincipal_Load_1(
            object sender,
            EventArgs e)
        {

        }


        private void FrmHorarioPrincipal_Load_2(
            object sender,
            EventArgs e)
        {
        
        }


        private void dgvHorarios_CellContentClick_1(
            object sender,
            DataGridViewCellEventArgs e)
        {
     
        }
    }
}