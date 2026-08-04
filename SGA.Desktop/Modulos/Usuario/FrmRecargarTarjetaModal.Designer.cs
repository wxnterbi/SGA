namespace SGA.Desktop.Modulos.Usuario
{
    partial class FrmRecargarTarjetaModal
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
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.numMonto = new System.Windows.Forms.NumericUpDown();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonto)).BeginInit();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(15, 33, 55);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(350, 60);
            this.pnlHeader.TabIndex = 0;

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(151, 21);
            this.lblTitulo.Text = "Recarga Presencial";

            // lblNombreUsuario
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblNombreUsuario.Location = new System.Drawing.Point(25, 75);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(130, 17);
            this.lblNombreUsuario.Text = "Usuario: Cargando...";

            // lblMonto
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMonto.Location = new System.Drawing.Point(25, 115);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(107, 15);
            this.lblMonto.Text = "Monto a Recargar:";

            // numMonto
            this.numMonto.DecimalPlaces = 2;
            this.numMonto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numMonto.Location = new System.Drawing.Point(28, 135);
            this.numMonto.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numMonto.Name = "numMonto";
            this.numMonto.Size = new System.Drawing.Size(292, 29);
            this.numMonto.TabIndex = 1;
            this.numMonto.ThousandsSeparator = true;

            // btnConfirmar
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(110, 185);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 35);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;

            // btnCancelar
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(220, 185);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;

            // FrmRecargarTarjetaModal
            this.ClientSize = new System.Drawing.Size(350, 235);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.numMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SGA - Recargar Tarjeta";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.NumericUpDown numMonto;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
    }
}