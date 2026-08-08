using Microsoft.Extensions.DependencyInjection;
using SGA.Application.Dtos.Auditoria;
using SGA.Presentation.Desktop.Interfaces;

namespace SGA.Presentation.Desktop.Forms.Auditoria
{
    public partial class FrmAuditoriaPrincipal : Form
    {
        private readonly IAuditoriaApiService _auditoriaApiService;

        private List<AuditoriaDto> _auditorias = new();

        private int _auditoriaSeleccionadaId = 0;

        public FrmAuditoriaPrincipal(
            IAuditoriaApiService auditoriaApiService)
        {
            InitializeComponent();

            _auditoriaApiService = auditoriaApiService;

            Load += FrmAuditoriaPrincipal_Load;

            btnBuscar.Click += btnBuscar_Click;

            btnLimpiar.Click += btnLimpiar_Click;

            btnDetalles.Click += btnDetalles_Click;

            dgvAuditorias.CellClick += dgvAuditorias_CellClick;
        }

        private async void FrmAuditoriaPrincipal_Load(
            object sender,
            EventArgs e)
        {
            await CargarAuditorias();
        }

        private async Task CargarAuditorias()
        {
            try
            {
                _auditorias =
                    await _auditoriaApiService
                        .GetAllAsync();

                MostrarAuditorias(_auditorias);

                ConfigurarGrid();

                _auditoriaSeleccionadaId = 0;
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

        private void MostrarAuditorias(
            IEnumerable<AuditoriaDto> lista)
        {
            dgvAuditorias.DataSource = null;

            dgvAuditorias.DataSource =
                lista.Select(a => new
                {
                    a.Id,

                    Actor = a.Actor,

                    Accion = a.TipoAccion,

                    Descripcion = a.Descripcion,

                    Fecha = a.FechaHora.ToString(
                        "dd/MM/yyyy HH:mm:ss")
                }).ToList();

            dgvAuditorias.ClearSelection();

            _auditoriaSeleccionadaId = 0;
        }

        private void ConfigurarGrid()
        {
            dgvAuditorias.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvAuditorias.Columns["Id"] != null)
            {
                dgvAuditorias.Columns["Id"]
                    .HeaderText = "ID";
            }

            if (dgvAuditorias.Columns["Actor"] != null)
            {
                dgvAuditorias.Columns["Actor"]
                    .HeaderText = "Actor";
            }

            if (dgvAuditorias.Columns["Accion"] != null)
            {
                dgvAuditorias.Columns["Accion"]
                    .HeaderText = "Acción";
            }

            if (dgvAuditorias.Columns["Descripcion"] != null)
            {
                dgvAuditorias.Columns["Descripcion"]
                    .HeaderText = "Descripción";
            }

            if (dgvAuditorias.Columns["Fecha"] != null)
            {
                dgvAuditorias.Columns["Fecha"]
                    .HeaderText = "Fecha y hora";
            }
        }

        private void dgvAuditorias_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var valor =
                dgvAuditorias.Rows[e.RowIndex]
                    .Cells["Id"]
                    .Value;

            if (valor != null &&
                int.TryParse(
                    valor.ToString(),
                    out int id))
            {
                _auditoriaSeleccionadaId = id;
            }
        }

        private void btnBuscar_Click(
            object sender,
            EventArgs e)
        {
            IEnumerable<AuditoriaDto> resultado =
                _auditorias;

            string actor =
                txtBuscarActor.Text.Trim();

            string accion =
                txtBuscarAccion.Text.Trim();

            if (!string.IsNullOrWhiteSpace(actor))
            {
                resultado =
                    resultado.Where(a =>
                        !string.IsNullOrWhiteSpace(a.Actor) &&
                        a.Actor.Contains(
                            actor,
                            StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(accion))
            {
                resultado =
                    resultado.Where(a =>
                        !string.IsNullOrWhiteSpace(a.TipoAccion) &&
                        a.TipoAccion.Contains(
                            accion,
                            StringComparison.OrdinalIgnoreCase));
            }

            MostrarAuditorias(resultado);

            ConfigurarGrid();
        }

        private async void btnLimpiar_Click(
            object sender,
            EventArgs e)
        {
            txtBuscarActor.Clear();

            txtBuscarAccion.Clear();

            await CargarAuditorias();
        }

        private async void btnDetalles_Click(
     object sender,
     EventArgs e)
        {
            if (_auditoriaSeleccionadaId == 0)
            {
                MessageBox.Show(
                    "Seleccione un registro de auditoría.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                var auditoria =
                    await _auditoriaApiService
                        .GetByIdAsync(_auditoriaSeleccionadaId);

                if (auditoria == null)
                {
                    MessageBox.Show(
                        "No se encontró el registro de auditoría.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                var formulario =
                    Program.ServiceProvider
                        .GetRequiredService<FrmDetalleAuditoria>();

                formulario.MostrarAuditoria(auditoria);

                formulario.ShowDialog();
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

        private void FrmAuditoriaPrincipal_Load_1(
            object sender,
            EventArgs e)
        {
        }
    }
}