namespace SGA.Presentation.Desktop.Forms.Ruta
{
    partial class FrmNuevaRuta
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Label lblNombre;
        private TextBox txtNombre;

        private Label lblOrigen;
        private TextBox txtOrigen;

        private Label lblDestino;
        private TextBox txtDestino;

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
            txtNombre = new TextBox();
            lblOrigen = new Label();
            txtOrigen = new TextBox();
            lblDestino = new Label();
            txtDestino = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(120, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(186, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "NUEVA RUTA";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(40, 90);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(170, 85);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 27);
            txtNombre.TabIndex = 2;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(40, 140);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(57, 20);
            lblOrigen.TabIndex = 3;
            lblOrigen.Text = "Origen:";
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(170, 135);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(250, 27);
            txtOrigen.TabIndex = 4;
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(40, 190);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(63, 20);
            lblDestino.TabIndex = 5;
            lblDestino.Text = "Destino:";
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(170, 185);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(250, 27);
            txtDestino.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(40, 167, 69);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(100, 270);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 40);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Firebrick;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(240, 270);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 40);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmNuevaRuta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 360);
            Controls.Add(lblTitulo);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblOrigen);
            Controls.Add(txtOrigen);
            Controls.Add(lblDestino);
            Controls.Add(txtDestino);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Name = "FrmNuevaRuta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva Ruta";
            Load += FrmNuevaRuta_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}