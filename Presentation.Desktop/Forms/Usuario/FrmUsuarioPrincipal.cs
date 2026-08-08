using SGA.Application.Dtos.Usuario;
using SGA.Presentation.Desktop.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace SGA.Presentation.Desktop.Forms.Usuario
{
    public partial class FrmUsuarioPrincipal : Form
    {
        private readonly IUsuarioApiService _usuarioApiService;

        private List<UsuarioDto> _usuarios = new();



        public FrmUsuarioPrincipal(
            IUsuarioApiService usuarioApiService)
        {
            InitializeComponent();

            _usuarioApiService = usuarioApiService;


            Load += FrmUsuarioPrincipal_Load;


            btnNuevoUsuario.Click += btnNuevoUsuario_Click;

            btnBuscar.Click += btnBuscar_Click;

            btnLimpiar.Click += btnLimpiar_Click;

            btnEditar.Click += btnEditar_Click;

            btnDetalles.Click += btnDetalles_Click;

            btnEliminar.Click += btnEliminar_Click;
        }


        private async void FrmUsuarioPrincipal_Load(
            object sender,
            EventArgs e)
        {
            try
            {
                CargarEstados();

                await CargarUsuarios();
            }
            catch (Exception ex)
            {
                MostrarError(
                    "No fue posible cargar la información de usuarios.",
                    ex);
            }
        }



        private void CargarEstados()
        {
            cmbEstado.Items.Clear();

            cmbEstado.Items.Add("Todos");


            foreach (var estado in
                Enum.GetValues(
                    typeof(
                        SGA.Domain.Enums.Configuration.EstadoUsuario)))
            {
                cmbEstado.Items.Add(estado);
            }


            cmbEstado.SelectedIndex = 0;
        }


        private async Task CargarUsuarios()
        {
            try
            {
                _usuarios =
                    await _usuarioApiService
                    .GetAllAsync();


                if (_usuarios == null)
                {
                    _usuarios =
                        new List<UsuarioDto>();
                }


                MostrarUsuarios(_usuarios);
            }
            catch (Exception ex)
            {
                MostrarError(
                    "No fue posible cargar los usuarios.",
                    ex);
            }
        }


        private void MostrarUsuarios(
            IEnumerable<UsuarioDto> lista)
        {
            try
            {
                dgvUsuarios.DataSource = null;


                dgvUsuarios.DataSource =
                    lista.Select(u => new
                    {
                        u.Id,

                        Identificador =
                            u.IdentificadorInstitucional,

                        Nombre =
                            u.Nombre,

                        Tipo =
                            u.TipoUsuario.ToString(),

                        Estado =
                            u.Estado.ToString()

                    }).ToList();


                dgvUsuarios.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;


                dgvUsuarios.ClearSelection();
            }
            catch (Exception ex)
            {
                MostrarError(
                    "No fue posible mostrar los usuarios.",
                    ex);
            }
        }


        private void btnBuscar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                IEnumerable<UsuarioDto> resultado =
                    _usuarios;


                if (_usuarios == null ||
                    !_usuarios.Any())
                {
                    MessageBox.Show(
                        "No hay usuarios registrados para realizar la búsqueda.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }


                if (!string.IsNullOrWhiteSpace(
                    txtBuscarNombre.Text))
                {
                    string nombreBuscado =
                        txtBuscarNombre.Text.Trim();


                    resultado =
                        resultado.Where(u =>
                            !string.IsNullOrWhiteSpace(u.Nombre) &&
                            u.Nombre.Contains(
                                nombreBuscado,
                                StringComparison.OrdinalIgnoreCase));
                }


                if (cmbEstado.SelectedItem != null &&
                    cmbEstado.SelectedIndex != 0)
                {
                    var estadoSeleccionado =
                        cmbEstado.SelectedItem
                        .ToString();


                    resultado =
                        resultado.Where(u =>
                            u.Estado.ToString()
                            ==
                            estadoSeleccionado);
                }


                var listaResultado =
                    resultado.ToList();


                if (!listaResultado.Any())
                {
                    MessageBox.Show(
                        "No se encontraron usuarios con los criterios de búsqueda.",
                        "Sin resultados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


                    MostrarUsuarios(
                        new List<UsuarioDto>());

                    return;
                }


                MostrarUsuarios(listaResultado);
            }
            catch (Exception ex)
            {
                MostrarError(
                    "Ocurrió un error al realizar la búsqueda.",
                    ex);
            }
        }


        private async void btnLimpiar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                txtBuscarNombre.Clear();


                if (cmbEstado.Items.Count > 0)
                {
                    cmbEstado.SelectedIndex = 0;
                }


                await CargarUsuarios();
            }
            catch (Exception ex)
            {
                MostrarError(
                    "No fue posible limpiar los filtros.",
                    ex);
            }
        }

        private async void btnNuevoUsuario_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                var formulario =
                    Program.ServiceProvider
                    .GetRequiredService<
                        FrmNuevoUsuario>();


                if (formulario.ShowDialog()
                    == DialogResult.OK)
                {
                    await CargarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MostrarError(
                    "No fue posible abrir el formulario de nuevo usuario.",
                    ex);
            }
        }


        private async void btnEditar_Click(
            object sender,
            EventArgs e)
        {
            try
            {

                if (!ValidarUsuarioSeleccionado())
                {
                    return;
                }


                int id;


                try
                {
                    id =
                        Convert.ToInt32(
                            dgvUsuarios.CurrentRow
                            .Cells["Id"]
                            .Value);
                }
                catch
                {
                    MessageBox.Show(
                        "No fue posible identificar el usuario seleccionado.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


                if (id <= 0)
                {
                    MessageBox.Show(
                        "El usuario seleccionado no tiene un identificador válido.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


                var formulario =
                    Program.ServiceProvider
                    .GetRequiredService<
                        FrmNuevoUsuario>();


                await formulario.CargarUsuario(id);


                if (formulario.ShowDialog()
                    == DialogResult.OK)
                {
                    await CargarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MostrarError(
                    "No fue posible editar el usuario.",
                    ex);
            }
        }


        private async void btnDetalles_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (dgvUsuarios.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione un usuario.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


                int id;

                try
                {
                    id = Convert.ToInt32(
                        dgvUsuarios.CurrentRow
                        .Cells["Id"]
                        .Value);
                }
                catch
                {
                    MessageBox.Show(
                        "No fue posible identificar el usuario seleccionado.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


                if (id <= 0)
                {
                    MessageBox.Show(
                        "El usuario seleccionado no tiene un identificador válido.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


                var formulario =
                    Program.ServiceProvider
                    .GetRequiredService<FrmDetalleUsuario>();


                formulario.CargarUsuario(id);


                formulario.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible cargar los detalles del usuario.\n\n" +
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
            try
            {
         

                if (!ValidarUsuarioSeleccionado())
                {
                    return;
                }

                int id;


                try
                {
                    id =
                        Convert.ToInt32(
                            dgvUsuarios.CurrentRow
                            .Cells["Id"]
                            .Value);
                }
                catch
                {
                    MessageBox.Show(
                        "No fue posible identificar el usuario seleccionado.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


                if (id <= 0)
                {
                    MessageBox.Show(
                        "El usuario seleccionado no tiene un identificador válido.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


                var confirmar =
                    MessageBox.Show(
                        "¿Desea eliminar este usuario?\n\n" +
                        "Esta acción no se puede deshacer.",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);


                if (confirmar != DialogResult.Yes)
                {
                    return;
                }



                bool resultado =
                    await _usuarioApiService
                    .DeleteAsync(id);


                if (resultado)
                {
                    MessageBox.Show(
                        "Usuario eliminado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


                    await CargarUsuarios();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo eliminar el usuario.\n\n" +
                        "Es posible que el usuario tenga información relacionada " +
                        "que impida su eliminación.",
                        "No se pudo eliminar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MostrarError(
                    ObtenerMensajeErrorEliminacion(ex),
                    ex);
            }
        }


        private bool ValidarUsuarioSeleccionado()
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un usuario.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }


            if (dgvUsuarios.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "La fila seleccionada no corresponde a un usuario.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }


            if (!dgvUsuarios.Columns.Contains("Id"))
            {
                MessageBox.Show(
                    "No fue posible identificar el usuario seleccionado.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }


            return true;
        }


        private string ObtenerMensajeErrorEliminacion(
            Exception ex)
        {
            string mensaje =
                ex.Message.ToLower();


            if (mensaje.Contains("foreign key") ||
                mensaje.Contains("constraint") ||
                mensaje.Contains("reference"))
            {
                return
                    "No se puede eliminar este usuario porque tiene " +
                    "información relacionada en el sistema.\n\n" +
                    "Primero debe revisar o eliminar los registros " +
                    "que dependen de este usuario.";
            }


            if (mensaje.Contains("not found") ||
                mensaje.Contains("no encontrado"))
            {
                return
                    "El usuario ya no existe o fue eliminado anteriormente.";
            }


            if (mensaje.Contains("timeout"))
            {
                return
                    "La operación tardó demasiado tiempo. " +
                    "Verifique la conexión con el servidor e inténtelo nuevamente.";
            }


            return
                "Ocurrió un error al eliminar el usuario.";
        }


        private void MostrarError(
            string mensaje,
            Exception ex)
        {
            string detalle =
                ex.Message;


            MessageBox.Show(
                mensaje +
                "\n\nDetalle:\n" +
                detalle,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }


        private void dgvUsuarios_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }


        private void FrmUsuarioPrincipal_Load_1(
            object sender,
            EventArgs e)
        {

        }
    }
}