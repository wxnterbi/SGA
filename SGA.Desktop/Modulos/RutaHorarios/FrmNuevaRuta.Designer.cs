namespace SGA.Desktop.Modulos.RutaHorarios
{
    partial class FrmNuevaRuta
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(15, 33, 55);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(380, 60);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(163, 21);
            this.lblTitulo.Text = "Registrar Nueva Ruta";

            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(25, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(118, 15);
            this.lblNombre.Text = "Nombre de la Ruta:";

            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Location = new System.Drawing.Point(28, 95);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Ej: Ruta Santo Domingo - Santiago";
            this.txtNombre.Size = new System.Drawing.Size(320, 25);
            this.txtNombre.TabIndex = 1;

            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOrigen.Location = new System.Drawing.Point(25, 135);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(47, 15);
            this.lblOrigen.Text = "Origen:";

            // 
            // txtOrigen
            // 
            this.txtOrigen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOrigen.Location = new System.Drawing.Point(28, 155);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.PlaceholderText = "Ej: Santo Domingo";
            this.txtOrigen.Size = new System.Drawing.Size(320, 25);
            this.txtOrigen.TabIndex = 2;

            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDestino.Location = new System.Drawing.Point(25, 195);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(53, 15);
            this.lblDestino.Text = "Destino:";

            // 
            // txtDestino
            // 
            this.txtDestino.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDestino.Location = new System.Drawing.Point(28, 215);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.PlaceholderText = "Ej: Santiago";
            this.txtDestino.Size = new System.Drawing.Size(320, 25);
            this.txtDestino.TabIndex = 3;

            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(140, 260);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 35);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(248, 260);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // 
            // FrmNuevaRuta
            // 
            this.ClientSize = new System.Drawing.Size(380, 315);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SGA - Nueva Ruta";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}