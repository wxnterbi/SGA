namespace SGA.Presentation.Desktop.Forms.Parada
{
    partial class FrmDetalleParada
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Label lblIdTexto;
        private Label lblId;

        private Label lblNombreTexto;
        private Label lblNombre;

        private Label lblUbicacionTexto;
        private Label lblUbicacion;

        private Label lblOrdenTexto;
        private Label lblOrden;

        private Button btnCerrar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblIdTexto = new Label();
            lblId = new Label();
            lblNombreTexto = new Label();
            lblNombre = new Label();
            lblUbicacionTexto = new Label();
            lblUbicacion = new Label();
            lblOrdenTexto = new Label();
            lblOrden = new Label();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(105, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(244, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Detalle de Parada";
            // 
            // lblIdTexto
            // 
            lblIdTexto.AutoSize = true;
            lblIdTexto.Location = new Point(40, 95);
            lblIdTexto.Name = "lblIdTexto";
            lblIdTexto.Size = new Size(27, 20);
            lblIdTexto.TabIndex = 1;
            lblIdTexto.Text = "ID:";
            // 
            // lblId
            // 
            lblId.Location = new Point(170, 95);
            lblId.Name = "lblId";
            lblId.Size = new Size(220, 23);
            lblId.TabIndex = 2;
            // 
            // lblNombreTexto
            // 
            lblNombreTexto.AutoSize = true;
            lblNombreTexto.Location = new Point(40, 145);
            lblNombreTexto.Name = "lblNombreTexto";
            lblNombreTexto.Size = new Size(67, 20);
            lblNombreTexto.TabIndex = 3;
            lblNombreTexto.Text = "Nombre:";
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(170, 145);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(220, 23);
            lblNombre.TabIndex = 4;
            // 
            // lblUbicacionTexto
            // 
            lblUbicacionTexto.AutoSize = true;
            lblUbicacionTexto.Location = new Point(40, 195);
            lblUbicacionTexto.Name = "lblUbicacionTexto";
            lblUbicacionTexto.Size = new Size(78, 20);
            lblUbicacionTexto.TabIndex = 5;
            lblUbicacionTexto.Text = "Ubicación:";
            // 
            // lblUbicacion
            // 
            lblUbicacion.Location = new Point(170, 195);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(220, 23);
            lblUbicacion.TabIndex = 6;
            // 
            // lblOrdenTexto
            // 
            lblOrdenTexto.AutoSize = true;
            lblOrdenTexto.Location = new Point(40, 245);
            lblOrdenTexto.Name = "lblOrdenTexto";
            lblOrdenTexto.Size = new Size(53, 20);
            lblOrdenTexto.TabIndex = 7;
            lblOrdenTexto.Text = "Orden:";
            // 
            // lblOrden
            // 
            lblOrden.Location = new Point(170, 245);
            lblOrden.Name = "lblOrden";
            lblOrden.Size = new Size(220, 23);
            lblOrden.TabIndex = 8;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(33, 150, 243);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(170, 320);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(110, 38);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // FrmDetalleParada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(450, 400);
            Controls.Add(lblTitulo);
            Controls.Add(lblIdTexto);
            Controls.Add(lblId);
            Controls.Add(lblNombreTexto);
            Controls.Add(lblNombre);
            Controls.Add(lblUbicacionTexto);
            Controls.Add(lblUbicacion);
            Controls.Add(lblOrdenTexto);
            Controls.Add(lblOrden);
            Controls.Add(btnCerrar);
            Name = "FrmDetalleParada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle de Parada";
            Load += FrmDetalleParada_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}