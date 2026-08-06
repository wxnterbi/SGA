namespace SGA.Presentation.Desktop.Forms.Ruta
{
    partial class FrmDetalleRuta
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Label lblIdTexto;
        private Label lblId;

        private Label lblNombreTexto;
        private Label lblNombre;

        private Label lblOrigenTexto;
        private Label lblOrigen;

        private Label lblDestinoTexto;
        private Label lblDestino;

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
            lblOrigenTexto = new Label();
            lblOrigen = new Label();
            lblDestinoTexto = new Label();
            lblDestino = new Label();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(110, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(245, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "DETALLE DE RUTA";
            // 
            // lblIdTexto
            // 
            lblIdTexto.AutoSize = true;
            lblIdTexto.Location = new Point(50, 90);
            lblIdTexto.Name = "lblIdTexto";
            lblIdTexto.Size = new Size(27, 20);
            lblIdTexto.TabIndex = 1;
            lblIdTexto.Text = "ID:";
            // 
            // lblId
            // 
            lblId.Location = new Point(180, 90);
            lblId.Name = "lblId";
            lblId.Size = new Size(200, 23);
            lblId.TabIndex = 2;
            // 
            // lblNombreTexto
            // 
            lblNombreTexto.AutoSize = true;
            lblNombreTexto.Location = new Point(50, 140);
            lblNombreTexto.Name = "lblNombreTexto";
            lblNombreTexto.Size = new Size(67, 20);
            lblNombreTexto.TabIndex = 3;
            lblNombreTexto.Text = "Nombre:";
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(180, 140);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(250, 23);
            lblNombre.TabIndex = 4;
            // 
            // lblOrigenTexto
            // 
            lblOrigenTexto.AutoSize = true;
            lblOrigenTexto.Location = new Point(50, 190);
            lblOrigenTexto.Name = "lblOrigenTexto";
            lblOrigenTexto.Size = new Size(57, 20);
            lblOrigenTexto.TabIndex = 5;
            lblOrigenTexto.Text = "Origen:";
            // 
            // lblOrigen
            // 
            lblOrigen.Location = new Point(180, 190);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(250, 23);
            lblOrigen.TabIndex = 6;
            // 
            // lblDestinoTexto
            // 
            lblDestinoTexto.AutoSize = true;
            lblDestinoTexto.Location = new Point(50, 240);
            lblDestinoTexto.Name = "lblDestinoTexto";
            lblDestinoTexto.Size = new Size(63, 20);
            lblDestinoTexto.TabIndex = 7;
            lblDestinoTexto.Text = "Destino:";
            // 
            // lblDestino
            // 
            lblDestino.Location = new Point(180, 240);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(250, 23);
            lblDestino.TabIndex = 8;
            lblDestino.Click += lblDestino_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Gray;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(170, 320);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(110, 40);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmDetalleRuta
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
            Controls.Add(lblOrigenTexto);
            Controls.Add(lblOrigen);
            Controls.Add(lblDestinoTexto);
            Controls.Add(lblDestino);
            Controls.Add(btnCerrar);
            Name = "FrmDetalleRuta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle Ruta";
            Load += FrmDetalleRuta_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}