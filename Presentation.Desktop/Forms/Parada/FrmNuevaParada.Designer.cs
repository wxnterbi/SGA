namespace SGA.Presentation.Desktop.Forms.Parada
{
    partial class FrmNuevaParada
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblUbicacion;
        private Label lblOrden;

        private TextBox txtNombre;
        private TextBox txtUbicacion;
        private NumericUpDown nudOrden;

        private Button btnGuardar;
        private Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblNombre = new Label();
            lblUbicacion = new Label();
            lblOrden = new Label();
            txtNombre = new TextBox();
            txtUbicacion = new TextBox();
            nudOrden = new NumericUpDown();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudOrden).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(120, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(225, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "NUEVA PARADA";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(40, 95);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Location = new Point(40, 170);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(75, 20);
            lblUbicacion.TabIndex = 3;
            lblUbicacion.Text = "Ubicación";
            // 
            // lblOrden
            // 
            lblOrden.AutoSize = true;
            lblOrden.Location = new Point(40, 245);
            lblOrden.Name = "lblOrden";
            lblOrden.Size = new Size(50, 20);
            lblOrden.TabIndex = 5;
            lblOrden.Text = "Orden";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(40, 120);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(340, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(40, 195);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(340, 27);
            txtUbicacion.TabIndex = 4;
            // 
            // nudOrden
            // 
            nudOrden.Location = new Point(40, 270);
            nudOrden.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudOrden.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudOrden.Name = "nudOrden";
            nudOrden.Size = new Size(120, 27);
            nudOrden.TabIndex = 6;
            nudOrden.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(40, 167, 69);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(70, 340);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 38);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Firebrick;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(220, 340);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 38);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmNuevaParada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(430, 420);
            Controls.Add(lblTitulo);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblUbicacion);
            Controls.Add(txtUbicacion);
            Controls.Add(lblOrden);
            Controls.Add(nudOrden);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Name = "FrmNuevaParada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parada";
            Load += FrmNuevaParada_Load_1;
            ((System.ComponentModel.ISupportInitialize)nudOrden).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}