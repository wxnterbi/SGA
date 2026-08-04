using System;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using SGA.Application.Dtos.Usuario;
using SGA.Desktop.Interfaces;

namespace SGA.Desktop.Modulos.Usuario
{
    public partial class FrmGestionUsuario : Form
    {
        private readonly IUsuarioApiService _usuarioApiService;
        private List<UsuarioDto> _listaUsuariosOriginal = new List<UsuarioDto>();

        public FrmGestionUsuario(IUsuarioApiService usuarioApiService = null)
        {
            InitializeComponent();
            _usuarioApiService = usuarioApiService ?? Program.ServiceProvider.GetRequiredService<IUsuarioApiService>();

            ConfigurarEstilosGrid();
            InicializarFiltros();
            VincularEventos();
        }

        private void ConfigurarEstilosGrid()
        {
            if (dgvUsuarios.Columns["Id"] != null)
            {
                dgvUsuarios.Columns["Id"].HeaderText = "Id";
                dgvUsuarios.Columns["Id"].Width = 50;
                dgvUsuarios.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvUsuarios.Columns["Id"].DisplayIndex = 0;
            }

            if (dgvUsuarios.Columns["IdentificadorInstitucional"] != null)
            {
                dgvUsuarios.Columns["IdentificadorInstitucional"].HeaderText = "ID Institucional";
                dgvUsuarios.Columns["IdentificadorInstitucional"].DisplayIndex = 1;
            }

            if (dgvUsuarios.Columns["Nombre"] != null)
            {
                dgvUsuarios.Columns["Nombre"].HeaderText = "Nombre Completo";
                dgvUsuarios.Columns["Nombre"].DisplayIndex = 2;
            }

            if (dgvUsuarios.Columns["TipoUsuario"] != null)
            {
                dgvUsuarios.Columns["TipoUsuario"].HeaderText = "Tipo";
                dgvUsuarios.Columns["TipoUsuario"].DisplayIndex = 3;
            }

            if (dgvUsuarios.Columns["Estado"] != null)
            {
                dgvUsuarios.Columns["Estado"].HeaderText = "Estado";
                dgvUsuarios.Columns["Estado"].DisplayIndex = 4;
            }

            if (!dgvUsuarios.Columns.Contains("btnDetalles"))
            {
                var btnDetalles = new DataGridViewButtonColumn
                {
                    Name = "btnDetalles",
                    HeaderText = "Acciones",
                    Text = "Detalles",
                    UseColumnTextForButtonValue = true,
                    Width = 90,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    FlatStyle = FlatStyle.Flat
                };
                dgvUsuarios.Columns.Add(btnDetalles);
            }

            if (!dgvUsuarios.Columns.Contains("btnRecargar"))
            {
                var btnRecargar = new DataGridViewButtonColumn
                {
                    Name = "btnRecargar",
                    HeaderText = "Recarga",
                    Text = "Recargar",
                    UseColumnTextForButtonValue = true,
                    Width = 90,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    FlatStyle = FlatStyle.Flat
                };
                dgvUsuarios.Columns.Add(btnRecargar);
            }

            dgvUsuarios.Columns["btnDetalles"].DisplayIndex = dgvUsuarios.Columns.Count - 2;
            dgvUsuarios.Columns["btnRecargar"].DisplayIndex = dgvUsuarios.Columns.Count - 1;
        }

        private void InicializarFiltros()
        {
            cmbTipoUsuario.Items.Clear();
            cmbTipoUsuario.Items.AddRange(new string[] { "Todos", "Estudiante", "Conductor", "Administrador" });
            cmbTipoUsuario.SelectedIndex = 0;

            cmbEstado.Items.Clear();
            cmbEstado.Items.AddRange(new string[] { "Todos", "Activo", "Inactivo" });
            cmbEstado.SelectedIndex = 0;
        }

        private void VincularEventos()
        {
            this.Load += FrmGestionUsuario_Load;

            txtBuscar.TextChanged += (s, e) => AplicarFiltro();
            cmbTipoUsuario.SelectedIndexChanged += (s, e) => AplicarFiltro();
            cmbEstado.SelectedIndexChanged += (s, e) => AplicarFiltro();

            btnRefrescar.Click += async (s, e) => await CargarUsuariosAsync();
            btnLimpiarFiltros.Click += BtnLimpiarFiltros_Click;

            dgvUsuarios.CellClick += DgvUsuarios_CellClick;
        }

        private async void FrmGestionUsuario_Load(object sender, EventArgs e)
        {
            await CargarUsuariosAsync();
        }

        public async Task CargarUsuariosAsync()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var usuarios = await _usuarioApiService.GetAllAsync();

                _listaUsuariosOriginal = usuarios?.OrderByDescending(u => u.Id).ToList() ?? new List<UsuarioDto>();

                ActualizarTarjetasKPI(_listaUsuariosOriginal);
                AplicarFiltro();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios desde la API: {ex.Message}", "SGA API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ActualizarTarjetasKPI(List<UsuarioDto> lista)
        {
            lblCard1Valor.Text = lista.Count.ToString();
            lblCard2Valor.Text = lista.Count(u => u.Estado.ToString().Equals("Activo", StringComparison.OrdinalIgnoreCase)).ToString();
            lblCard3Valor.Text = lista.Count(u => u.TipoUsuario.ToString().Equals("Estudiante", StringComparison.OrdinalIgnoreCase)).ToString();
            lblCard4Valor.Text = lista.Count(u => u.Estado.ToString().Equals("Inactivo", StringComparison.OrdinalIgnoreCase)).ToString();
        }

        private void AplicarFiltro()
        {
            string filtroTexto = txtBuscar.Text.Trim().ToLower();
            var resultado = _listaUsuariosOriginal.AsEnumerable();

            if (!string.IsNullOrEmpty(filtroTexto))
            {
                resultado = resultado.Where(u =>
                    (u.Nombre != null && u.Nombre.ToLower().Contains(filtroTexto)) ||
                    (u.IdentificadorInstitucional != null && u.IdentificadorInstitucional.ToLower().Contains(filtroTexto))
                );
            }

            if (cmbTipoUsuario.SelectedIndex > 0)
            {
                string tipoSeleccionado = cmbTipoUsuario.SelectedItem.ToString();
                resultado = resultado.Where(u => u.TipoUsuario.ToString().Equals(tipoSeleccionado, StringComparison.OrdinalIgnoreCase));
            }

            if (cmbEstado.SelectedIndex > 0)
            {
                string estadoSeleccionado = cmbEstado.SelectedItem.ToString();
                resultado = resultado.Where(u => u.Estado.ToString().Equals(estadoSeleccionado, StringComparison.OrdinalIgnoreCase));
            }

            var listaFiltrada = resultado.ToList();

            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = listaFiltrada;

            FormatearGrilla();

            lblTotalRegistros.Text = $"Mostrando {listaFiltrada.Count} de {_listaUsuariosOriginal.Count} usuarios registrados";
        }

        private void FormatearGrilla()
        {
            if (dgvUsuarios.Columns["Id"] != null)
            {
                dgvUsuarios.Columns["Id"].Width = 50;
                dgvUsuarios.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
            if (dgvUsuarios.Columns["IdentificadorInstitucional"] != null)
                dgvUsuarios.Columns["IdentificadorInstitucional"].HeaderText = "ID Institucional";

            if (dgvUsuarios.Columns["Nombre"] != null)
                dgvUsuarios.Columns["Nombre"].HeaderText = "Nombre Completo";

            if (dgvUsuarios.Columns["TipoUsuario"] != null)
                dgvUsuarios.Columns["TipoUsuario"].HeaderText = "Tipo";

            if (dgvUsuarios.Columns["Estado"] != null)
                dgvUsuarios.Columns["Estado"].HeaderText = "Estado";

            if (!dgvUsuarios.Columns.Contains("btnDetalles"))
            {
                var btnDetalles = new DataGridViewButtonColumn
                {
                    Name = "btnDetalles",
                    HeaderText = "Acciones",
                    Text = "Detalles",
                    UseColumnTextForButtonValue = true,
                    Width = 90,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    FlatStyle = FlatStyle.Flat
                };
                dgvUsuarios.Columns.Add(btnDetalles);
            }

            if (!dgvUsuarios.Columns.Contains("btnRecargar"))
            {
                var btnRecargar = new DataGridViewButtonColumn
                {
                    Name = "btnRecargar",
                    HeaderText = "Recarga",
                    Text = "Recargar",
                    UseColumnTextForButtonValue = true,
                    Width = 90,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    FlatStyle = FlatStyle.Flat
                };
                dgvUsuarios.Columns.Add(btnRecargar);
            }
        }

        private async void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvUsuarios.Rows[e.RowIndex].DataBoundItem is UsuarioDto usuarioSeleccionado)
            {
                if (dgvUsuarios.Columns[e.ColumnIndex].Name == "btnDetalles")
                {
                    using (var frm = new FrmDetalleUsuario(usuarioSeleccionado.Id))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            await CargarUsuariosAsync();
                        }
                    }
                }
                else if (dgvUsuarios.Columns[e.ColumnIndex].Name == "btnRecargar")
                {
                    using (var frm = new FrmRecargarTarjetaModal(usuarioSeleccionado.Id, usuarioSeleccionado.Nombre))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            await CargarUsuariosAsync();
                        }
                    }
                }
            }
        }

        private void BtnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = string.Empty;
            cmbTipoUsuario.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
        }
    }
}