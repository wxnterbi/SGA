namespace SGA.Presentation.Desktop.Forms.Horario
{
    partial class FrmDetalleHorario
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Label lblIdTitulo;
        private Label lblDiasTitulo;
        private Label lblHoraTitulo;
        private Label lblRutaTitulo;

        private Label lblId;
        private Label lblDias;
        private Label lblHora;
        private Label lblRuta;

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
            lblDiasTitulo = new Label();
            lblHoraTitulo = new Label();
            lblRutaTitulo = new Label();

            lblId = new Label();
            lblDias = new Label();
            lblHora = new Label();
            lblRuta = new Label();

            btnCerrar = new Button();

            SuspendLayout();

            // 
            // FrmDetalleHorario
            // 
            ClientSize =
                new Size(600, 380);

            Text =
                "Detalle del Horario";

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
                new Font("Segoe UI", 18F, FontStyle.Bold);

            lblTitulo.ForeColor =
                Color.FromArgb(25, 42, 86);

            lblTitulo.Location =
                new Point(30, 20);

            lblTitulo.Name =
                "lblTitulo";

            lblTitulo.Size =
                new Size(280, 41);

            lblTitulo.TabIndex = 0;

            lblTitulo.Text =
                "DETALLE DEL HORARIO";

            // 
            // Títulos
            // 
            Label[] titulos =
            {
                lblIdTitulo,
                lblDiasTitulo,
                lblHoraTitulo,
                lblRutaTitulo
            };

            string[] textos =
            {
                "ID",
                "Días de operación",
                "Hora de salida",
                "Ruta"
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
                    textos[i];

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
                lblDias,
                lblHora,
                lblRuta
            };

            y = 90;

            foreach (Label lbl in valores)
            {
                lbl.AutoSize = true;

                lbl.Font =
                    new Font("Segoe UI", 11F);

                lbl.Location =
                    new Point(220, y);

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
                new Point(235, 305);

            btnCerrar.Name =
                "btnCerrar";

            btnCerrar.Size =
                new Size(120, 40);

            btnCerrar.TabIndex = 9;

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
            Controls.Add(lblDiasTitulo);
            Controls.Add(lblHoraTitulo);
            Controls.Add(lblRutaTitulo);

            Controls.Add(lblId);
            Controls.Add(lblDias);
            Controls.Add(lblHora);
            Controls.Add(lblRuta);

            Controls.Add(btnCerrar);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}