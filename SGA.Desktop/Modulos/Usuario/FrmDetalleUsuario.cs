using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using SGA.Application.Dtos.Usuario;
using SGA.Desktop.Interfaces;
using SGA.Domain.Enums.Configuration;

namespace SGA.Desktop.Modulos.Usuario
{
    public partial class FrmDetalleUsuario : Form
    {
        private readonly int _usuarioId;
        private readonly IUsuarioApiService _usuarioApiService;

        private UsuarioDto _usuarioActual;
        private bool _modoEdicion = false;

        public FrmDetalleUsuario(int usuarioId)
        {
            InitializeComponent();

            _usuarioId = usuarioId;

            _usuarioApiService = Program.ServiceProvider
                .GetRequiredService<IUsuarioApiService>();

            this.Load += FrmDetalleUsuario_Load;
            btnEditar.Click += BtnEditar_Click;
            btnGuardar.Click += BtnGuardar_Click;
            btnRecargar.Click += BtnRecargar_Click;
        }

        private async void FrmDetalleUsuario_Load(object sender, EventArgs e)
        {
            CargarEnums();
            await CargarDatosUsuarioAsync();
            EstablecerModoEdicion(false);
        }

        private void CargarEnums()
        {
            cboTipoUsuario.DataSource = Enum.GetValues(typeof(TipoUsuario));
            cboEstado.DataSource = Enum.GetValues(typeof(EstadoUsuario));
        }

        private async Task CargarDatosUsuarioAsync()
        {
            try
            {
                _usuarioActual = await _usuarioApiService.GetByIdAsync(_usuarioId);

                if (_usuarioActual != null)
                {
                    txtId.Text = _usuarioActual.Id.ToString();
                    txtIdentificador.Text = _usuarioActual.IdentificadorInstitucional;
                    txtNombre.Text = _usuarioActual.Nombre;
                    cboTipoUsuario.SelectedItem = _usuarioActual.TipoUsuario;
                    cboEstado.SelectedItem = _usuarioActual.Estado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los detalles del usuario: {ex.Message}", "SGA Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EstablecerModoEdicion(bool activo)
        {
            _modoEdicion = activo;

            txtNombre.ReadOnly = !activo;
            txtIdentificador.ReadOnly = !activo;
            cboTipoUsuario.Enabled = activo;
            cboEstado.Enabled = activo;

            btnGuardar.Visible = activo;
            btnEditar.Text = activo ? "Cancelar" : "Editar";
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            EstablecerModoEdicion(!_modoEdicion);
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_usuarioActual == null) return;

                var dto = new UpdateUsuarioDto
                {
                    Id = _usuarioActual.Id,
                    IdentificadorInstitucional = txtIdentificador.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    TipoUsuario = (TipoUsuario)cboTipoUsuario.SelectedItem,
                    Estado = (EstadoUsuario)cboEstado.SelectedItem
                };

                var actualizado = await _usuarioApiService.UpdateAsync(
                    _usuarioActual.Id,
                    dto
                );

                if (actualizado)
                {
                    MessageBox.Show(
                        "Usuario actualizado correctamente.",
                        "SGA Usuarios",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo actualizar el usuario.",
                        "SGA Usuarios",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al actualizar usuario: {ex.Message}",
                    "SGA Usuarios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private async void BtnRecargar_Click(object sender, EventArgs e)
        {
            if (_usuarioActual == null) return;

            using (var frmRecarga = new FrmRecargarTarjetaModal(_usuarioActual.Id, _usuarioActual.Nombre))
            {
                if (frmRecarga.ShowDialog() == DialogResult.OK)
                {
                    await CargarDatosUsuarioAsync();
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}