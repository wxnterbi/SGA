namespace SGA.Presentation.Desktop.Forms.Auditoria
{
    partial class FrmDetalleAuditoria
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Label lblIdTitulo;
        private Label lblActorTitulo;
        private Label lblAccionTitulo;
        private Label lblFechaTitulo;
        private Label lblDescripcionTitulo;

        private Label lblId;
        private Label lblActor;
        private Label lblAccion;
        private Label lblFecha;
        private Label lblDescripcion;

        private Button btnCerrar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components =
                new System.ComponentModel.Container();

            lblTitulo = new Label();

            lblIdTitulo = new Label();
            lblActorTitulo = new Label();
            lblAccionTitulo = new Label();
            lblFechaTitulo = new Label();
            lblDescripcionTitulo = new Label();

            lblId = new Label();
            lblActor = new Label();
            lblAccion = new Label();
            lblFecha = new Label();
            lblDescripcion = new Label();

            btnCerrar = new Button();

            SuspendLayout();

            // 
            // FrmDetalleAuditoria
            // 
            ClientSize =
                new Size(600, 430);

            Text =
                "Detalle de Auditoría";

            StartPosition =
                FormStartPosition.CenterParent;

            FormBorderStyle =
                FormBorderStyle.FixedDialog;

            MaximizeBox = false;
            MinimizeBox = false;

            BackColor =
                Color.White;

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;

            lblTitulo.Font =
                new Font(
                    "Segoe UI",
                    18F,
                    FontStyle.Bold);

            lblTitulo.ForeColor =
                Color.FromArgb(25, 42, 86);

            lblTitulo.Location =
                new Point(30, 20);

            lblTitulo.Name =
                "lblTitulo";

            lblTitulo.Size =
                new Size(310, 41);

            lblTitulo.TabIndex = 0;

            lblTitulo.Text =
                "DETALLE DE AUDITORÍA";

            // 
            // Títulos
            // 
            Label[] titulos =
            {
                lblIdTitulo,
                lblActorTitulo,
                lblAccionTitulo,
                lblFechaTitulo,
                lblDescripcionTitulo
            };

            string[] textos =
            {
                "ID",
                "Actor",
                "Acción",
                "Fecha y hora",
                "Descripción"
            };

            int y = 90;

            for (int i = 0; i < titulos.Length; i++)
            {
                titulos[i].AutoSize = true;

                titulos[i].Font =
                    new Font(
                        "Segoe UI",
                        11F,
                        FontStyle.Bold);

                titulos[i].Location =
                    new Point(40, y);

                titulos[i].Name =
                    "lbl" + textos[i]
                        .Replace(" ", "");

                titulos[i].Text =
                    textos[i];

                y += 50;
            }

            // 
            // Valores
            // 
            Label[] valores =
            {
                lblId,
                lblActor,
                lblAccion,
                lblFecha,
                lblDescripcion
            };

            y = 90;

            foreach (Label lbl in valores)
            {
                lbl.AutoSize = true;

                lbl.Font =
                    new Font(
                        "Segoe UI",
                        11F);

                lbl.Location =
                    new Point(220, y);

                lbl.MaximumSize =
                    new Size(330, 0);

                y += 50;
            }

            // 
            // btnCerrar
            // 
            btnCerrar.BackColor =
                Color.FromArgb(25, 42, 86);

            btnCerrar.FlatStyle =
                FlatStyle.Flat;

            btnCerrar.FlatAppearance.BorderSize = 0;

            btnCerrar.ForeColor =
                Color.White;

            btnCerrar.Location =
                new Point(235, 350);

            btnCerrar.Name =
                "btnCerrar";

            btnCerrar.Size =
                new Size(120, 40);

            btnCerrar.TabIndex = 10;

            btnCerrar.Text =
                "Cerrar";

            btnCerrar.UseVisualStyleBackColor = false;

            btnCerrar.Click +=
                btnCerrar_Click;

            // 
            // Controls
            // 
            Controls.Add(lblTitulo);

            Controls.Add(lblIdTitulo);
            Controls.Add(lblActorTitulo);
            Controls.Add(lblAccionTitulo);
            Controls.Add(lblFechaTitulo);
            Controls.Add(lblDescripcionTitulo);

            Controls.Add(lblId);
            Controls.Add(lblActor);
            Controls.Add(lblAccion);
            Controls.Add(lblFecha);
            Controls.Add(lblDescripcion);

            Controls.Add(btnCerrar);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}