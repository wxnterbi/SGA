namespace SGA.Desktop.Modulos.Transporte
{
    partial class FrmNuevoAutobusModal
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
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.numCapacidad = new System.Windows.Forms.NumericUpDown();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(33)))), ((int)(((byte)(55)))));
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(430, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(15, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(206, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REGISTRAR NUEVO AUTOBÚS";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPlaca.Location = new System.Drawing.Point(25, 70);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(38, 15);
            this.lblPlaca.TabIndex = 1;
            this.lblPlaca.Text = "Placa:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPlaca.Location = new System.Drawing.Point(25, 88);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(375, 25);
            this.txtPlaca.TabIndex = 2;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMarca.Location = new System.Drawing.Point(25, 125);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(44, 15);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMarca.Location = new System.Drawing.Point(25, 143);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(180, 25);
            this.txtMarca.TabIndex = 4;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblModelo.Location = new System.Drawing.Point(220, 125);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(52, 15);
            this.lblModelo.TabIndex = 5;
            this.lblModelo.Text = "Modelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtModelo.Location = new System.Drawing.Point(220, 143);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(180, 25);
            this.txtModelo.TabIndex = 6;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCapacidad.Location = new System.Drawing.Point(25, 180);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(66, 15);
            this.lblCapacidad.TabIndex = 7;
            this.lblCapacidad.Text = "Capacidad:";
            // 
            // numCapacidad
            // 
            this.numCapacidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numCapacidad.Location = new System.Drawing.Point(25, 198);
            this.numCapacidad.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numCapacidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numCapacidad.Name = "numCapacidad";
            this.numCapacidad.Size = new System.Drawing.Size(180, 25);
            this.numCapacidad.TabIndex = 8;
            this.numCapacidad.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Location = new System.Drawing.Point(220, 180);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(46, 15);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(220, 198);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(180, 25);
            this.cmbEstado.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(300, 250);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 35);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(190, 250);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmNuevoAutobusModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 310);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.numCapacidad);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevoAutobusModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Programar Nuevo Autobús";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.NumericUpDown numCapacidad;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}