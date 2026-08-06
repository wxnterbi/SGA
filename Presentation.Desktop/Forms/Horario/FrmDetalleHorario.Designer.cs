namespace SGA.Presentation.Desktop.Forms.Horario
{
    partial class FrmDetalleHorario
    {
        private System.ComponentModel.IContainer components = null;


        private Label lblTitulo;


        private Label lblIdTexto;
        private Label lblId;

        private Label lblDiasTexto;
        private Label lblDias;

        private Label lblHoraTexto;
        private Label lblHora;

        private Label lblRutaTexto;
        private Label lblRuta;


        private Button btnCerrar;



        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }




        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblIdTexto = new Label();
            lblId = new Label();
            lblDiasTexto = new Label();
            lblDias = new Label();
            lblHoraTexto = new Label();
            lblHora = new Label();
            lblRutaTexto = new Label();
            lblRuta = new Label();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(40, 40, 40);
            lblTitulo.Location = new Point(170, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(348, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "DETALLE DEL HORARIO";
            // 
            // lblIdTexto
            // 
            lblIdTexto.AutoSize = true;
            lblIdTexto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblIdTexto.Location = new Point(80, 120);
            lblIdTexto.Name = "lblIdTexto";
            lblIdTexto.Size = new Size(37, 25);
            lblIdTexto.TabIndex = 1;
            lblIdTexto.Text = "ID:";
            // 
            // lblId
            // 
            lblId.Font = new Font("Segoe UI", 11F);
            lblId.Location = new Point(250, 120);
            lblId.Name = "lblId";
            lblId.Size = new Size(250, 30);
            lblId.TabIndex = 2;
            lblId.Click += lblId_Click;
            // 
            // lblDiasTexto
            // 
            lblDiasTexto.AutoSize = true;
            lblDiasTexto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDiasTexto.Location = new Point(80, 170);
            lblDiasTexto.Name = "lblDiasTexto";
            lblDiasTexto.Size = new Size(149, 25);
            lblDiasTexto.TabIndex = 3;
            lblDiasTexto.Text = "Días operación:";
            // 
            // lblDias
            // 
            lblDias.Font = new Font("Segoe UI", 11F);
            lblDias.Location = new Point(250, 170);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(250, 30);
            lblDias.TabIndex = 4;
            // 
            // lblHoraTexto
            // 
            lblHoraTexto.AutoSize = true;
            lblHoraTexto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblHoraTexto.Location = new Point(80, 220);
            lblHoraTexto.Name = "lblHoraTexto";
            lblHoraTexto.Size = new Size(117, 25);
            lblHoraTexto.TabIndex = 5;
            lblHoraTexto.Text = "Hora salida:";
            // 
            // lblHora
            // 
            lblHora.Font = new Font("Segoe UI", 11F);
            lblHora.Location = new Point(250, 220);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(250, 30);
            lblHora.TabIndex = 6;
            // 
            // lblRutaTexto
            // 
            lblRutaTexto.AutoSize = true;
            lblRutaTexto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRutaTexto.Location = new Point(80, 270);
            lblRutaTexto.Name = "lblRutaTexto";
            lblRutaTexto.Size = new Size(58, 25);
            lblRutaTexto.TabIndex = 7;
            lblRutaTexto.Text = "Ruta:";
            // 
            // lblRuta
            // 
            lblRuta.Font = new Font("Segoe UI", 11F);
            lblRuta.Location = new Point(250, 270);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(250, 30);
            lblRuta.TabIndex = 8;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Gray;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(230, 360);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(140, 45);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmDetalleHorario
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 450);
            Controls.Add(lblTitulo);
            Controls.Add(lblIdTexto);
            Controls.Add(lblId);
            Controls.Add(lblDiasTexto);
            Controls.Add(lblDias);
            Controls.Add(lblHoraTexto);
            Controls.Add(lblHora);
            Controls.Add(lblRutaTexto);
            Controls.Add(lblRuta);
            Controls.Add(btnCerrar);
            Font = new Font("Segoe UI", 10F);
            Name = "FrmDetalleHorario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle del Horario";
            Load += FrmDetalleHorario_Load_2;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}