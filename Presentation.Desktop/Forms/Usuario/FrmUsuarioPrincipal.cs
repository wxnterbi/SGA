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
            CargarEstados();

            await CargarUsuarios();
        }



        private void CargarEstados()
        {
            cmbEstado.Items.Clear();


            cmbEstado.Items.Add("Todos");


            foreach (var estado in
                Enum.GetValues(
                    typeof(SGA.Domain.Enums.Configuration.EstadoUsuario)))
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


                MostrarUsuarios(_usuarios);

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



        private void MostrarUsuarios(
            IEnumerable<UsuarioDto> lista)
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
        private void btnBuscar_Click(
    object sender,
    EventArgs e)
        {
            IEnumerable<UsuarioDto> resultado =
                _usuarios;



            // Buscar por nombre

            if (!string.IsNullOrWhiteSpace(
                txtBuscarNombre.Text))
            {
                resultado =
                    resultado.Where(u =>
                        u.Nombre.Contains(
                            txtBuscarNombre.Text,
                            StringComparison.OrdinalIgnoreCase));
            }



            // Filtrar por estado

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



            MostrarUsuarios(resultado);
        }




        private async void btnLimpiar_Click(
            object sender,
            EventArgs e)
        {

            txtBuscarNombre.Clear();


            cmbEstado.SelectedIndex = 0;


            await CargarUsuarios();

        }




        private async void btnNuevoUsuario_Click(
            object sender,
            EventArgs e)
        {

            var formulario =
                Program.ServiceProvider
                .GetRequiredService<FrmNuevoUsuario>();



            if (formulario.ShowDialog()
                == DialogResult.OK)
            {
                await CargarUsuarios();
            }

        }
        private async void btnEditar_Click(
            object sender,
            EventArgs e)
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



            int id =
                Convert.ToInt32(
                    dgvUsuarios.CurrentRow.Cells["Id"].Value);



            var formulario =
                Program.ServiceProvider
                .GetRequiredService<FrmNuevoUsuario>();



            await formulario.CargarUsuario(id);



            if (formulario.ShowDialog()
                == DialogResult.OK)
            {
                await CargarUsuarios();
            }

        }





        private void btnDetalles_Click(
            object sender,
            EventArgs e)
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



            int id =
                Convert.ToInt32(
                    dgvUsuarios.CurrentRow.Cells["Id"].Value);



            var formulario =
                Program.ServiceProvider
                .GetRequiredService<FrmDetalleUsuario>();


            formulario.CargarUsuario(id);


            formulario.ShowDialog();

        }





        private async void btnEliminar_Click(
            object sender,
            EventArgs e)
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



            int id =
                Convert.ToInt32(
                    dgvUsuarios.CurrentRow.Cells["Id"].Value);



            var confirmar =
                MessageBox.Show(
                    "¿Desea eliminar este usuario?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);



            if (confirmar == DialogResult.Yes)
            {

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
                        "No se pudo eliminar el usuario.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }

        }


    }
}