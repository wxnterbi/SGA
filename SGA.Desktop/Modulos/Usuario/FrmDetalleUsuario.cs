using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using SGA.Application.Dtos.TarjetaRecargable;
using SGA.Application.Dtos.Usuario;
using SGA.Application.Interfaces;
using SGA.Domain.Enums.Configuration;

namespace SGA.Desktop.Modulos.Usuario
{
    public partial class FrmDetalleUsuario : Form
    {
        private readonly int _usuarioId;
        private readonly IUsuarioService _usuarioService;
        private readonly ITarjetaRecargableService _tarjetaService;

        private UsuarioDto _usuarioActual;
        private TarjetaRecargableDto _tarjetaActual;
        private bool _modoEdicion = false;

        public FrmDetalleUsuario(
            int usuarioId,
            IUsuarioService usuarioService = null,
            ITarjetaRecargableService tarjetaService = null)
        {
            InitializeComponent();
            _usuarioId = usuarioId;
            _usuarioService = usuarioService ?? Program.ServiceProvider.GetRequiredService<IUsuarioService>();
            _tarjetaService = tarjetaService ?? Program.ServiceProvider.GetRequiredService<ITarjetaRecargableService>();

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
                _usuarioActual = await _usuarioService.GetByIdAsync(_usuarioId);

                if (_usuarioActual != null)
                {
                    txtId.Text = _usuarioActual.Id.ToString();
                    txtIdentificador.Text = _usuarioActual.IdentificadorInstitucional;
                    txtNombre.Text = _usuarioActual.Nombre;
                    cboTipoUsuario.SelectedItem = _usuarioActual.TipoUsuario;
                    cboEstado.SelectedItem = _usuarioActual.Estado;

                    // Consultar Tarjeta Recargable asignada
                    var tarjetas = await _tarjetaService.GetAllAsync();
                    _tarjetaActual = tarjetas?.FirstOrDefault(t => t.UsuarioId == _usuarioId);

                    if (_tarjetaActual != null)
                    {
                        lblSaldoValor.Text = $"RD$ {_tarjetaActual.Saldo:N2}";
                    }
                    else
                    {
                        lblSaldoValor.Text = "Sin Tarjeta";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar detalles: {ex.Message}", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                _usuarioActual.Nombre = txtNombre.Text.Trim();
                _usuarioActual.IdentificadorInstitucional = txtIdentificador.Text.Trim();
                _usuarioActual.TipoUsuario = (TipoUsuario)cboTipoUsuario.SelectedItem;
                _usuarioActual.Estado = (EstadoUsuario)cboEstado.SelectedItem;

                await _usuarioService.UpdateAsync(_usuarioActual);

                MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar: {ex.Message}", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnRecargar_Click(object sender, EventArgs e)
        {
            using (var frmRecarga = new FrmRecargarTarjetaModal(_usuarioActual.Id, _usuarioActual.Nombre))
            {
                if (frmRecarga.ShowDialog() == DialogResult.OK)
                {
                    await CargarDatosUsuarioAsync(); // Refrescar saldo localmente
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}