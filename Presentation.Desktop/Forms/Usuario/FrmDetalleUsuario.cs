using SGA.Application.Dtos.Usuario;
using SGA.Presentation.Desktop.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace SGA.Presentation.Desktop.Forms.Usuario
{
    public partial class FrmDetalleUsuario : Form
    {

        private readonly IUsuarioApiService _usuarioApiService;


        private int _usuarioId;



        public FrmDetalleUsuario(
            IUsuarioApiService usuarioApiService)
        {
            InitializeComponent();


            _usuarioApiService =
                usuarioApiService;


            btnEditar.Click += btnEditar_Click;


            btnCerrar.Click += btnCerrar_Click;

        }




        public async void CargarUsuario(int id)
        {
            try
            {

                _usuarioId = id;


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



                txtIdentificador.Text =
                    usuario.IdentificadorInstitucional;



                txtNombre.Text =
                    usuario.Nombre;



                txtTipoUsuario.Text =
                    usuario.TipoUsuario
                    .ToString();



                txtEstado.Text =
                    usuario.Estado
                    .ToString();

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
        private async void btnEditar_Click(
    object sender,
    EventArgs e)
        {

            var formulario =
                Program.ServiceProvider
                .GetRequiredService<FrmNuevoUsuario>();


            await formulario.CargarUsuario(_usuarioId);



            if (formulario.ShowDialog()
                == DialogResult.OK)
            {
                CargarUsuario(_usuarioId);
            }

        }




        private void btnCerrar_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }


    }
}