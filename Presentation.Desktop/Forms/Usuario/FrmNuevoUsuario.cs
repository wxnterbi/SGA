using SGA.Application.Dtos.Usuario;
using SGA.Domain.Enums.Configuration;
using SGA.Presentation.Desktop.Interfaces;

namespace SGA.Presentation.Desktop.Forms.Usuario
{
    public partial class FrmNuevoUsuario : Form
    {
        private readonly IUsuarioApiService _usuarioApiService;

        private int _usuarioId = 0;

        private bool _modoEdicion = false;


        public FrmNuevoUsuario(
            IUsuarioApiService usuarioApiService)
        {
            InitializeComponent();

            _usuarioApiService = usuarioApiService;

            Load += FrmNuevoUsuario_Load;

            btnGuardar.Click += btnGuardar_Click;

            btnCancelar.Click += btnCancelar_Click;
        }


        private void FrmNuevoUsuario_Load(
            object sender,
            EventArgs e)
        {
            CargarTiposUsuario();

            CargarEstados();

            lblMensajeContrasena.Visible = false;
        }


        private void CargarTiposUsuario()
        {
            cmbTipoUsuario.DataSource =
                Enum.GetValues(typeof(TipoUsuario));

            cmbTipoUsuario.SelectedIndex = 0;
        }


        private void CargarEstados()
        {
            cmbEstado.DataSource =
                Enum.GetValues(typeof(EstadoUsuario));

            cmbEstado.SelectedIndex = 0;
        }


        public async Task CargarUsuario(int id)
        {
            try
            {
                var usuario =
                    await _usuarioApiService
                    .GetByIdAsync(id);


                if (usuario == null)
                {
                    MessageBox.Show(
                        "No se encontró el usuario.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }


                _usuarioId = usuario.Id;

                _modoEdicion = true;


                lblTitulo.Text =
                    "Editar Usuario";


                txtContrasena.Clear();

                lblMensajeContrasena.Visible = true;


                txtIdentificador.Text =
                    usuario.IdentificadorInstitucional;


                txtNombre.Text =
                    usuario.Nombre;


                cmbTipoUsuario.SelectedItem =
                    usuario.TipoUsuario;


                cmbEstado.SelectedItem =
                    usuario.Estado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible cargar el usuario.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private bool ValidarNombre()
        {
            string nombre =
                txtNombre.Text.Trim();


            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show(
                    "Debe ingresar el nombre del usuario.",
                    "Nombre inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombre.Focus();

                return false;
            }


            if (nombre.Length < 2)
            {
                MessageBox.Show(
                    "El nombre debe tener al menos 2 caracteres.",
                    "Nombre inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombre.Focus();

                return false;
            }


            if (nombre.Length > 100)
            {
                MessageBox.Show(
                    "El nombre no puede superar los 100 caracteres.",
                    "Nombre inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombre.Focus();

                return false;
            }


            foreach (char caracter in nombre)
            {
                if (!char.IsLetter(caracter) &&
                    caracter != ' ')
                {
                    MessageBox.Show(
                        "El nombre solamente puede contener letras y espacios.\n\n" +
                        "No se permiten números ni caracteres especiales.",
                        "Nombre inválido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre.Focus();

                    return false;
                }
            }


            if (nombre.Contains("  "))
            {
                MessageBox.Show(
                    "El nombre no puede contener espacios consecutivos.",
                    "Nombre inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombre.Focus();

                return false;
            }


            return true;
        }


        private bool ValidarIdentificador()
        {
            string identificador =
                txtIdentificador.Text.Trim();


            if (string.IsNullOrWhiteSpace(identificador))
            {
                MessageBox.Show(
                    "Debe ingresar el identificador institucional.",
                    "Identificador inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtIdentificador.Focus();

                return false;
            }


            if (identificador.Length < 2)
            {
                MessageBox.Show(
                    "El identificador institucional debe tener al menos 2 caracteres.",
                    "Identificador inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtIdentificador.Focus();

                return false;
            }


            if (identificador.Length > 50)
            {
                MessageBox.Show(
                    "El identificador institucional no puede superar los 50 caracteres.",
                    "Identificador inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtIdentificador.Focus();

                return false;
            }


            if (identificador.Contains(' '))
            {
                MessageBox.Show(
                    "El identificador institucional no puede contener espacios.",
                    "Identificador inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtIdentificador.Focus();

                return false;
            }


            return true;
        }


        private bool ValidarContrasena()
        {
            string contrasena =
                txtContrasena.Text;


            if (_modoEdicion &&
                string.IsNullOrEmpty(contrasena))
            {
                return true;
            }


            if (string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show(
                    "Debe ingresar una contraseña.",
                    "Contraseña inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtContrasena.Focus();

                return false;
            }


            if (contrasena.Length < 6)
            {
                MessageBox.Show(
                    "La contraseña debe tener al menos 6 caracteres.",
                    "Contraseña inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtContrasena.Focus();

                return false;
            }


            if (contrasena.Contains(' '))
            {
                MessageBox.Show(
                    "La contraseña no puede contener espacios.",
                    "Contraseña inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtContrasena.Focus();

                return false;
            }


            return true;
        }


        private bool ValidarTipoUsuario()
        {
            if (cmbTipoUsuario.SelectedItem == null)
            {
                MessageBox.Show(
                    "Debe seleccionar el tipo de usuario.",
                    "Tipo de usuario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbTipoUsuario.Focus();

                return false;
            }


            return true;
        }


        private bool ValidarEstado()
        {
            if (cmbEstado.SelectedItem == null)
            {
                MessageBox.Show(
                    "Debe seleccionar el estado del usuario.",
                    "Estado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbEstado.Focus();

                return false;
            }


            return true;
        }


        private async void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                // Validar nombre
                if (!ValidarNombre())
                {
                    return;
                }


   
                if (!ValidarIdentificador())
                {
                    return;
                }



                if (!ValidarContrasena())
                {
                    return;
                }



                if (!ValidarTipoUsuario())
                {
                    return;
                }



                if (!ValidarEstado())
                {
                    return;
                }


                if (!_modoEdicion)
                {
                    var usuario =
                        new CreateUsuarioDto
                        {
                            IdentificadorInstitucional =
                                txtIdentificador.Text.Trim(),

                            Nombre =
                                txtNombre.Text.Trim(),

                            Contrasena =
                                txtContrasena.Text,

                            TipoUsuario =
                                (TipoUsuario)cmbTipoUsuario.SelectedItem,

                            Estado =
                                (EstadoUsuario)cmbEstado.SelectedItem
                        };


                    bool resultado =
                        await _usuarioApiService
                        .CreateAsync(usuario);


                    if (resultado)
                    {
                        MessageBox.Show(
                            "Usuario registrado correctamente.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        DialogResult =
                            DialogResult.OK;

                        Close();

                        return;
                    }


                    MessageBox.Show(
                        "No se pudo registrar el usuario.\n\n" +
                        "El servidor no pudo completar la operación.",
                        "Registro no realizado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                var usuarioActualizar =
                    new UpdateUsuarioDto
                    {
                        Id = _usuarioId,

                        IdentificadorInstitucional =
                            txtIdentificador.Text.Trim(),

                        Nombre =
                            txtNombre.Text.Trim(),

                        Contrasena =
                            txtContrasena.Text,

                        TipoUsuario =
                            (TipoUsuario)cmbTipoUsuario.SelectedItem,

                        Estado =
                            (EstadoUsuario)cmbEstado.SelectedItem
                    };


                bool resultadoActualizacion =
                    await _usuarioApiService
                    .UpdateAsync(
                        _usuarioId,
                        usuarioActualizar);


                if (resultadoActualizacion)
                {
                    MessageBox.Show(
                        "Usuario actualizado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    DialogResult =
                        DialogResult.OK;

                    Close();

                    return;
                }


                MessageBox.Show(
                    "No se pudo actualizar el usuario.\n\n" +
                    "El servidor no pudo completar la operación.",
                    "Actualización no realizada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al procesar el usuario.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void btnCancelar_Click(
            object sender,
            EventArgs e)
        {
            DialogResult =
                DialogResult.Cancel;

            Close();
        }


        private void btnCancelar_Click_1(
            object sender,
            EventArgs e)
        {
        }


        private void FrmNuevoUsuario_Load_1(
            object sender,
            EventArgs e)
        {
        }
    }
}