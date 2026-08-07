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
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private async void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdentificador.Text) ||
                    string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show(
                        "Debe completar todos los campos.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (!_modoEdicion &&
                    string.IsNullOrWhiteSpace(txtContrasena.Text))
                {
                    MessageBox.Show(
                        "Debe ingresar una contraseña.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }



                if (!_modoEdicion)
                {
                    var usuario = new CreateUsuarioDto
                    {
                        IdentificadorInstitucional =
                        txtIdentificador.Text.Trim(),

                        Nombre =
                        txtNombre.Text.Trim(),

                        Contrasena =
                        txtContrasena.Text.Trim(),

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
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se pudo registrar el usuario.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }

                else
                {
                    var usuario = new UpdateUsuarioDto
                    {
                        Id = _usuarioId,

                        IdentificadorInstitucional =
                        txtIdentificador.Text.Trim(),

                        Nombre =
                        txtNombre.Text.Trim(),

                        Contrasena =
                        txtContrasena.Text.Trim(),

                        TipoUsuario =
                        (TipoUsuario)cmbTipoUsuario.SelectedItem,

                        Estado =
                        (EstadoUsuario)cmbEstado.SelectedItem
                    };



                    bool resultado =
                        await _usuarioApiService
                        .UpdateAsync(
                            _usuarioId,
                            usuario);



                    if (resultado)
                    {
                        MessageBox.Show(
                            "Usuario actualizado correctamente.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);


                        DialogResult =
                            DialogResult.OK;


                        Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se pudo actualizar el usuario.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
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
        private void btnCancelar_Click(
            object sender,
            EventArgs e)
        {
            DialogResult =
                DialogResult.Cancel;


            Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

        }
    }
}