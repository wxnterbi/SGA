using Microsoft.Extensions.DependencyInjection;
using SGA.Application.Dtos.Usuario;
using SGA.Desktop.Interfaces;
using SGA.Domain.Enums.Configuration;

namespace SGA.Desktop.Modulos.Usuario
{
    public partial class FrmAgregarNuevoUsuario : Form
    {
        private readonly IUsuarioApiService _usuarioApiService;

        public FrmAgregarNuevoUsuario()
        {
            InitializeComponent();

            _usuarioApiService = Program.ServiceProvider.GetRequiredService<IUsuarioApiService>();

            Load += FrmAgregarNuevoUsuario_Load;

            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += BtnCancelar_Click;
        }

        private void FrmAgregarNuevoUsuario_Load(object sender, EventArgs e)
        {
            cboTipoUsuario.DataSource = Enum.GetValues(typeof(TipoUsuario));
            cboEstado.DataSource = Enum.GetValues(typeof(EstadoUsuario));
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdentificador.Text))
                {
                    MessageBox.Show("Debe ingresar el identificador.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre.");
                    return;
                }

                var dto = new CreateUsuarioDto
                {
                    IdentificadorInstitucional = txtIdentificador.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    TipoUsuario = (TipoUsuario)cboTipoUsuario.SelectedItem,
                    Estado = (EstadoUsuario)cboEstado.SelectedItem
                };

                bool creado = await _usuarioApiService.CrearUsuarioAsync(dto);

                if (creado)
                {
                    MessageBox.Show(
                        "Usuario registrado correctamente.",
                        "SGA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show(
                        "No fue posible registrar el usuario.",
                        "SGA",
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}