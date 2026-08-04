namespace SGA.Desktop.Modulos.Usuario
{
    partial class FrmDetalleUsuario
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.gbSaldo = new System.Windows.Forms.GroupBox();
            this.lblSaldoValor = new System.Windows.Forms.Label();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.gbSaldo.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(15, 33, 55);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(420, 60);
            this.pnlHeader.TabIndex = 0;

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(155, 21);
            this.lblTitulo.Text = "Detalles de Usuario";

            // lblId
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblId.Location = new System.Drawing.Point(25, 75);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 15);
            this.lblId.Text = "ID:";

            // txtId
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtId.Location = new System.Drawing.Point(28, 93);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(80, 25);
            this.txtId.TabIndex = 0;

            // lblIdentificador
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdentificador.Location = new System.Drawing.Point(130, 75);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(98, 15);
            this.lblIdentificador.Text = "ID Institucional:";

            // txtIdentificador
            this.txtIdentificador.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIdentificador.Location = new System.Drawing.Point(133, 93);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(255, 25);
            this.txtIdentificador.TabIndex = 1;

            // lblNombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(25, 130);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(113, 15);
            this.lblNombre.Text = "Nombre Completo:";

            // txtNombre
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Location = new System.Drawing.Point(28, 148);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(360, 25);
            this.txtNombre.TabIndex = 2;

            // lblTipo
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTipo.Location = new System.Drawing.Point(25, 185);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(96, 15);
            this.lblTipo.Text = "Tipo de Usuario:";

            // cboTipoUsuario
            this.cboTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTipoUsuario.FormattingEnabled = true;
            this.cboTipoUsuario.Location = new System.Drawing.Point(28, 203);
            this.cboTipoUsuario.Name = "cboTipoUsuario";
            this.cboTipoUsuario.Size = new System.Drawing.Size(165, 25);
            this.cboTipoUsuario.TabIndex = 3;

            // lblEstado
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Location = new System.Drawing.Point(220, 185);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(46, 15);
            this.lblEstado.Text = "Estado:";

            // cboEstado
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(223, 203);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(165, 25);
            this.cboEstado.TabIndex = 4;

            // gbSaldo
            this.gbSaldo.Controls.Add(this.lblSaldoValor);
            this.gbSaldo.Controls.Add(this.btnRecargar);
            this.gbSaldo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbSaldo.Location = new System.Drawing.Point(28, 245);
            this.gbSaldo.Name = "gbSaldo";
            this.gbSaldo.Size = new System.Drawing.Size(360, 70);
            this.gbSaldo.TabIndex = 5;
            this.gbSaldo.TabStop = false;
            this.gbSaldo.Text = "Tarjeta Recargable";

            // lblSaldoValor
            this.lblSaldoValor.AutoSize = true;
            this.lblSaldoValor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSaldoValor.ForeColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.lblSaldoValor.Location = new System.Drawing.Point(15, 28);
            this.lblSaldoValor.Name = "lblSaldoValor";
            this.lblSaldoValor.Size = new System.Drawing.Size(92, 25);
            this.lblSaldoValor.Text = "RD$ 0.00";

            // btnRecargar
            this.btnRecargar.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecargar.ForeColor = System.Drawing.Color.White;
            this.btnRecargar.Location = new System.Drawing.Point(240, 25);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(105, 32);
            this.btnRecargar.TabIndex = 0;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = false;

            // btnEditar
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(178, 335);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 35);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;

            // btnGuardar
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(288, 335);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 35);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;

            // FrmDetalleUsuario
            this.ClientSize = new System.Drawing.Size(420, 390);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gbSaldo);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cboTipoUsuario);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtIdentificador);
            this.Controls.Add(this.lblIdentificador);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SGA - Detalles de Usuario";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.gbSaldo.ResumeLayout(false);
            this.gbSaldo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipoUsuario;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.GroupBox gbSaldo;
        private System.Windows.Forms.Label lblSaldoValor;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
    }
}