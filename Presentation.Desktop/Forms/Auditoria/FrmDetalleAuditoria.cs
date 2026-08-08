using SGA.Application.Dtos.Auditoria;

namespace SGA.Presentation.Desktop.Forms.Auditoria
{
    public partial class FrmDetalleAuditoria : Form
    {
        public FrmDetalleAuditoria()
        {
            InitializeComponent();
        }

        public void MostrarAuditoria(AuditoriaDto auditoria)
        {
            if (auditoria == null)
            {
                MessageBox.Show(
                    "No se encontró el registro de auditoría.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Close();

                return;
            }

            lblId.Text =
                auditoria.Id.ToString();

            lblActor.Text =
                auditoria.Actor;

            lblAccion.Text =
                auditoria.TipoAccion;

            lblFecha.Text =
                auditoria.FechaHora.ToString(
                    "dd/MM/yyyy HH:mm:ss");

            lblDescripcion.Text =
                auditoria.Descripcion;
        }

        private void btnCerrar_Click(
            object? sender,
            EventArgs e)
        {
            Close();
        }

        private void FrmDetalleAuditoria_Load(
            object? sender,
            EventArgs e)
        {
        }
    }
}
