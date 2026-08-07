namespace SGA.Presentation.Desktop.Forms
{
    partial class FrmRecargarSaldoPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelPrincipal;
        private Panel panelTitulo;

        private Label lblTitulo;
        private Label lblSubtitulo;

        private Label lblBuscarMatricula;
        private TextBox txtMatricula;
        private Button btnBuscar;

        private Panel panelTarjeta;
        private Label lblTituloTarjeta;
        private Label lblMatriculaTexto;
        private Label lblMatricula;
        private Label lblSaldoTexto;
        private Label lblSaldo;

        private Label lblTituloRecarga;
        private Label lblMonto;
        private TextBox txtMonto;
        private Label lblTipoPago;
        private ComboBox cmbTipoPago;
        private Button btnRecargar;

        private Label lblTituloHistorial;
        private DataGridView dgvHistorial;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelPrincipal = new Panel();
            dgvHistorial = new DataGridView();
            lblTituloHistorial = new Label();
            btnRecargar = new Button();
            cmbTipoPago = new ComboBox();
            lblTipoPago = new Label();
            txtMonto = new TextBox();
            lblMonto = new Label();
            lblTituloRecarga = new Label();
            panelTarjeta = new Panel();
            lblSaldo = new Label();
            lblSaldoTexto = new Label();
            lblMatricula = new Label();
            lblMatriculaTexto = new Label();
            lblTituloTarjeta = new Label();
            btnBuscar = new Button();
            txtMatricula = new TextBox();
            lblBuscarMatricula = new Label();
            panelTitulo = new Panel();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            panelTarjeta.SuspendLayout();
            panelTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(245, 247, 250);
            panelPrincipal.Controls.Add(dgvHistorial);
            panelPrincipal.Controls.Add(lblTituloHistorial);
            panelPrincipal.Controls.Add(btnRecargar);
            panelPrincipal.Controls.Add(cmbTipoPago);
            panelPrincipal.Controls.Add(lblTipoPago);
            panelPrincipal.Controls.Add(txtMonto);
            panelPrincipal.Controls.Add(lblMonto);
            panelPrincipal.Controls.Add(lblTituloRecarga);
            panelPrincipal.Controls.Add(panelTarjeta);
            panelPrincipal.Controls.Add(btnBuscar);
            panelPrincipal.Controls.Add(txtMatricula);
            panelPrincipal.Controls.Add(lblBuscarMatricula);
            panelPrincipal.Controls.Add(panelTitulo);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Margin = new Padding(3, 4, 3, 4);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Padding = new Padding(34, 40, 34, 40);
            panelPrincipal.Size = new Size(1122, 897);
            panelPrincipal.TabIndex = 0;
            panelPrincipal.Paint += panelPrincipal_Paint_1;
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.AllowUserToResizeRows = false;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.BackgroundColor = Color.White;
            dgvHistorial.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHistorial.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistorial.ColumnHeadersHeight = 38;
            dgvHistorial.EnableHeadersVisualStyles = false;
            dgvHistorial.Location = new Point(22, 680);
            dgvHistorial.Margin = new Padding(3, 4, 3, 4);
            dgvHistorial.MultiSelect = false;
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.RowTemplate.Height = 32;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.Size = new Size(1074, 204);
            dgvHistorial.TabIndex = 0;
            // 
            // lblTituloHistorial
            // 
            lblTituloHistorial.AutoSize = true;
            lblTituloHistorial.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblTituloHistorial.ForeColor = Color.FromArgb(31, 41, 55);
            lblTituloHistorial.Location = new Point(34, 633);
            lblTituloHistorial.Name = "lblTituloHistorial";
            lblTituloHistorial.Size = new Size(215, 30);
            lblTituloHistorial.TabIndex = 1;
            lblTituloHistorial.Text = "Historial de recargas";
            // 
            // btnRecargar
            // 
            btnRecargar.BackColor = Color.FromArgb(22, 163, 74);
            btnRecargar.Cursor = Cursors.Hand;
            btnRecargar.FlatAppearance.BorderSize = 0;
            btnRecargar.FlatStyle = FlatStyle.Flat;
            btnRecargar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnRecargar.ForeColor = Color.White;
            btnRecargar.Location = new Point(617, 555);
            btnRecargar.Margin = new Padding(3, 4, 3, 4);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(177, 45);
            btnRecargar.TabIndex = 2;
            btnRecargar.Text = "Recargar saldo";
            btnRecargar.UseVisualStyleBackColor = false;
            // 
            // cmbTipoPago
            // 
            cmbTipoPago.BackColor = Color.White;
            cmbTipoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPago.Font = new Font("Segoe UI", 10F);
            cmbTipoPago.FormattingEnabled = true;
            cmbTipoPago.Location = new Point(326, 556);
            cmbTipoPago.Margin = new Padding(3, 4, 3, 4);
            cmbTipoPago.Name = "cmbTipoPago";
            cmbTipoPago.Size = new Size(262, 31);
            cmbTipoPago.TabIndex = 3;
            // 
            // lblTipoPago
            // 
            lblTipoPago.AutoSize = true;
            lblTipoPago.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTipoPago.ForeColor = Color.FromArgb(55, 65, 81);
            lblTipoPago.Location = new Point(326, 520);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(111, 23);
            lblTipoPago.TabIndex = 4;
            lblTipoPago.Text = "Tipo de pago";
            // 
            // txtMonto
            // 
            txtMonto.BackColor = Color.White;
            txtMonto.BorderStyle = BorderStyle.FixedSingle;
            txtMonto.Font = new Font("Segoe UI", 11F);
            txtMonto.Location = new Point(34, 556);
            txtMonto.Margin = new Padding(3, 4, 3, 4);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(263, 32);
            txtMonto.TabIndex = 5;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblMonto.ForeColor = Color.FromArgb(55, 65, 81);
            lblMonto.Location = new Point(34, 520);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(62, 23);
            lblMonto.TabIndex = 6;
            lblMonto.Text = "Monto";
            // 
            // lblTituloRecarga
            // 
            lblTituloRecarga.AutoSize = true;
            lblTituloRecarga.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblTituloRecarga.ForeColor = Color.FromArgb(31, 41, 55);
            lblTituloRecarga.Location = new Point(34, 473);
            lblTituloRecarga.Name = "lblTituloRecarga";
            lblTituloRecarga.Size = new Size(169, 30);
            lblTituloRecarga.TabIndex = 7;
            lblTituloRecarga.Text = "Realizar recarga";
            // 
            // panelTarjeta
            // 
            panelTarjeta.BackColor = Color.White;
            panelTarjeta.BorderStyle = BorderStyle.FixedSingle;
            panelTarjeta.Controls.Add(lblSaldo);
            panelTarjeta.Controls.Add(lblSaldoTexto);
            panelTarjeta.Controls.Add(lblMatricula);
            panelTarjeta.Controls.Add(lblMatriculaTexto);
            panelTarjeta.Controls.Add(lblTituloTarjeta);
            panelTarjeta.Location = new Point(34, 300);
            panelTarjeta.Margin = new Padding(3, 4, 3, 4);
            panelTarjeta.Name = "panelTarjeta";
            panelTarjeta.Size = new Size(1074, 139);
            panelTarjeta.TabIndex = 8;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblSaldo.ForeColor = Color.FromArgb(22, 163, 74);
            lblSaldo.Location = new Point(789, 63);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(142, 41);
            lblSaldo.TabIndex = 0;
            lblSaldo.Text = "RD$ 0.00";
            // 
            // lblSaldoTexto
            // 
            lblSaldoTexto.AutoSize = true;
            lblSaldoTexto.Font = new Font("Segoe UI", 9F);
            lblSaldoTexto.ForeColor = Color.FromArgb(107, 114, 128);
            lblSaldoTexto.Location = new Point(629, 73);
            lblSaldoTexto.Name = "lblSaldoTexto";
            lblSaldoTexto.Size = new Size(124, 20);
            lblSaldoTexto.TabIndex = 1;
            lblSaldoTexto.Text = "Saldo disponible:";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblMatricula.ForeColor = Color.FromArgb(31, 41, 55);
            lblMatricula.Location = new Point(120, 69);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(20, 28);
            lblMatricula.TabIndex = 2;
            lblMatricula.Text = "-";
            // 
            // lblMatriculaTexto
            // 
            lblMatriculaTexto.AutoSize = true;
            lblMatriculaTexto.Font = new Font("Segoe UI", 9F);
            lblMatriculaTexto.ForeColor = Color.FromArgb(107, 114, 128);
            lblMatriculaTexto.Location = new Point(23, 73);
            lblMatriculaTexto.Name = "lblMatriculaTexto";
            lblMatriculaTexto.Size = new Size(74, 20);
            lblMatriculaTexto.TabIndex = 3;
            lblMatriculaTexto.Text = "Matrícula:";
            // 
            // lblTituloTarjeta
            // 
            lblTituloTarjeta.AutoSize = true;
            lblTituloTarjeta.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTituloTarjeta.ForeColor = Color.FromArgb(31, 41, 55);
            lblTituloTarjeta.Location = new Point(23, 16);
            lblTituloTarjeta.Name = "lblTituloTarjeta";
            lblTituloTarjeta.Size = new Size(216, 25);
            lblTituloTarjeta.TabIndex = 4;
            lblTituloTarjeta.Text = "Información del usuario";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(37, 99, 235);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(463, 228);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(137, 45);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtMatricula
            // 
            txtMatricula.BackColor = Color.White;
            txtMatricula.BorderStyle = BorderStyle.FixedSingle;
            txtMatricula.Font = new Font("Segoe UI", 11F);
            txtMatricula.ForeColor = Color.FromArgb(31, 41, 55);
            txtMatricula.Location = new Point(34, 229);
            txtMatricula.Margin = new Padding(3, 4, 3, 4);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(411, 32);
            txtMatricula.TabIndex = 10;
            // 
            // lblBuscarMatricula
            // 
            lblBuscarMatricula.AutoSize = true;
            lblBuscarMatricula.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblBuscarMatricula.ForeColor = Color.FromArgb(55, 65, 81);
            lblBuscarMatricula.Location = new Point(34, 193);
            lblBuscarMatricula.Name = "lblBuscarMatricula";
            lblBuscarMatricula.Size = new Size(82, 23);
            lblBuscarMatricula.TabIndex = 11;
            lblBuscarMatricula.Text = "Matrícula";
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(31, 41, 55);
            panelTitulo.Controls.Add(lblSubtitulo);
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Location = new Point(34, 33);
            panelTitulo.Margin = new Padding(3, 4, 3, 4);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1074, 133);
            panelTitulo.TabIndex = 12;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(209, 213, 219);
            lblSubtitulo.Location = new Point(31, 80);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(443, 23);
            lblSubtitulo.TabIndex = 0;
            lblSubtitulo.Text = "Busca un usuario, consulta su saldo y realiza una recarga";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(29, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(290, 54);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Recargar saldo";
            // 
            // FrmRecargarSaldoPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1122, 897);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(1140, 944);
            MinimumSize = new Size(1140, 944);
            Name = "FrmRecargarSaldoPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recargar saldo";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            panelTarjeta.ResumeLayout(false);
            panelTarjeta.PerformLayout();
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            ResumeLayout(false);
        }
    }
}