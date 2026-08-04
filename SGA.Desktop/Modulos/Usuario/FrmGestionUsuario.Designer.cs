namespace SGA.Desktop.Modulos.Usuario
{
    partial class FrmGestionUsuario
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
            pnlMainContainer = new Panel();
            pnlGridContainer = new Panel();
            dgvUsuarios = new DataGridView();
            pnlGridFooter = new Panel();
            lblTotalRegistros = new Label();
            pnlGridHeader = new Panel();
            lblTablaTitulo = new Label();
            pnlFiltros = new Panel();
            btnLimpiarFiltros = new Button();
            cmbEstado = new ComboBox();
            lblEstado = new Label();
            cmbTipoUsuario = new ComboBox();
            lblTipo = new Label();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            tlpCards = new TableLayoutPanel();
            pnlCard1 = new Panel();
            lblCard1Valor = new Label();
            lblCard1Titulo = new Label();
            pnlCard2 = new Panel();
            lblCard2Valor = new Label();
            lblCard2Titulo = new Label();
            pnlCard3 = new Panel();
            lblCard3Valor = new Label();
            lblCard3Titulo = new Label();
            pnlCard4 = new Panel();
            lblCard4Valor = new Label();
            lblCard4Titulo = new Label();
            pnlHeader = new Panel();
            btnNuevoUsuario = new Button();
            btnRefrescar = new Button();
            lblSubtituloHeader = new Label();
            lblTituloHeader = new Label();
            pnlMainContainer.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            pnlGridFooter.SuspendLayout();
            pnlGridHeader.SuspendLayout();
            pnlFiltros.SuspendLayout();
            tlpCards.SuspendLayout();
            pnlCard1.SuspendLayout();
            pnlCard2.SuspendLayout();
            pnlCard3.SuspendLayout();
            pnlCard4.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMainContainer
            // 
            pnlMainContainer.AutoScroll = true;
            pnlMainContainer.BackColor = Color.FromArgb(244, 246, 249);
            pnlMainContainer.Controls.Add(pnlGridContainer);
            pnlMainContainer.Controls.Add(pnlFiltros);
            pnlMainContainer.Controls.Add(tlpCards);
            pnlMainContainer.Controls.Add(pnlHeader);
            pnlMainContainer.Dock = DockStyle.Fill;
            pnlMainContainer.Location = new Point(0, 0);
            pnlMainContainer.Name = "pnlMainContainer";
            pnlMainContainer.Padding = new Padding(25);
            pnlMainContainer.Size = new Size(1200, 750);
            pnlMainContainer.TabIndex = 0;
            // 
            // pnlGridContainer
            // 
            pnlGridContainer.BackColor = Color.White;
            pnlGridContainer.Controls.Add(dgvUsuarios);
            pnlGridContainer.Controls.Add(pnlGridFooter);
            pnlGridContainer.Controls.Add(pnlGridHeader);
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.Location = new Point(25, 270);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Size = new Size(1150, 455);
            pnlGridContainer.TabIndex = 0;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.Location = new Point(0, 45);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowTemplate.Height = 35;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(1150, 375);
            dgvUsuarios.TabIndex = 0;
            // 
            // pnlGridFooter
            // 
            pnlGridFooter.Controls.Add(lblTotalRegistros);
            pnlGridFooter.Dock = DockStyle.Bottom;
            pnlGridFooter.Location = new Point(0, 420);
            pnlGridFooter.Name = "pnlGridFooter";
            pnlGridFooter.Size = new Size(1150, 35);
            pnlGridFooter.TabIndex = 1;
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.Font = new Font("Segoe UI", 9F);
            lblTotalRegistros.ForeColor = Color.Gray;
            lblTotalRegistros.Location = new Point(15, 8);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(100, 23);
            lblTotalRegistros.TabIndex = 0;
            lblTotalRegistros.Text = "Mostrando 0 usuarios registrados";
            // 
            // pnlGridHeader
            // 
            pnlGridHeader.Controls.Add(lblTablaTitulo);
            pnlGridHeader.Dock = DockStyle.Top;
            pnlGridHeader.Location = new Point(0, 0);
            pnlGridHeader.Name = "pnlGridHeader";
            pnlGridHeader.Size = new Size(1150, 45);
            pnlGridHeader.TabIndex = 2;
            // 
            // lblTablaTitulo
            // 
            lblTablaTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTablaTitulo.ForeColor = Color.FromArgb(15, 33, 55);
            lblTablaTitulo.Location = new Point(15, 12);
            lblTablaTitulo.Name = "lblTablaTitulo";
            lblTablaTitulo.Size = new Size(100, 23);
            lblTablaTitulo.TabIndex = 0;
            lblTablaTitulo.Text = "Listado General de Usuarios";
            // 
            // pnlFiltros
            // 
            pnlFiltros.BackColor = Color.White;
            pnlFiltros.Controls.Add(btnLimpiarFiltros);
            pnlFiltros.Controls.Add(cmbEstado);
            pnlFiltros.Controls.Add(lblEstado);
            pnlFiltros.Controls.Add(cmbTipoUsuario);
            pnlFiltros.Controls.Add(lblTipo);
            pnlFiltros.Controls.Add(txtBuscar);
            pnlFiltros.Controls.Add(lblBuscar);
            pnlFiltros.Dock = DockStyle.Top;
            pnlFiltros.Location = new Point(25, 205);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Size = new Size(1150, 65);
            pnlFiltros.TabIndex = 2;
            // 
            // btnLimpiarFiltros
            // 
            btnLimpiarFiltros.BackColor = Color.FromArgb(240, 242, 245);
            btnLimpiarFiltros.FlatAppearance.BorderSize = 0;
            btnLimpiarFiltros.FlatStyle = FlatStyle.Flat;
            btnLimpiarFiltros.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimpiarFiltros.Location = new Point(690, 26);
            btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            btnLimpiarFiltros.Size = new Size(110, 28);
            btnLimpiarFiltros.TabIndex = 0;
            btnLimpiarFiltros.Text = "Limpiar Filtros";
            btnLimpiarFiltros.UseVisualStyleBackColor = false;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Font = new Font("Segoe UI", 9.5F);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(520, 28);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(150, 25);
            cmbEstado.TabIndex = 1;
            // 
            // lblEstado
            // 
            lblEstado.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblEstado.ForeColor = Color.DimGray;
            lblEstado.Location = new Point(517, 8);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(100, 23);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Estado:";
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoUsuario.Font = new Font("Segoe UI", 9.5F);
            cmbTipoUsuario.FormattingEnabled = true;
            cmbTipoUsuario.Location = new Point(320, 28);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(180, 25);
            cmbTipoUsuario.TabIndex = 3;
            // 
            // lblTipo
            // 
            lblTipo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTipo.ForeColor = Color.DimGray;
            lblTipo.Location = new Point(317, 8);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(100, 23);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Tipo de Usuario:";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 10F);
            txtBuscar.Location = new Point(18, 28);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(280, 25);
            txtBuscar.TabIndex = 5;
            // 
            // lblBuscar
            // 
            lblBuscar.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblBuscar.ForeColor = Color.DimGray;
            lblBuscar.Location = new Point(15, 8);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(100, 23);
            lblBuscar.TabIndex = 6;
            lblBuscar.Text = "Buscar por nombre / ID:";
            // 
            // tlpCards
            // 
            tlpCards.ColumnCount = 4;
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.Controls.Add(pnlCard1, 0, 0);
            tlpCards.Controls.Add(pnlCard2, 1, 0);
            tlpCards.Controls.Add(pnlCard3, 2, 0);
            tlpCards.Controls.Add(pnlCard4, 3, 0);
            tlpCards.Dock = DockStyle.Top;
            tlpCards.Location = new Point(25, 105);
            tlpCards.Name = "tlpCards";
            tlpCards.RowCount = 1;
            tlpCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCards.Size = new Size(1150, 100);
            tlpCards.TabIndex = 1;
            // 
            // pnlCard1
            // 
            pnlCard1.BackColor = Color.White;
            pnlCard1.Controls.Add(lblCard1Valor);
            pnlCard1.Controls.Add(lblCard1Titulo);
            pnlCard1.Dock = DockStyle.Fill;
            pnlCard1.Location = new Point(0, 15);
            pnlCard1.Margin = new Padding(0, 15, 10, 15);
            pnlCard1.Name = "pnlCard1";
            pnlCard1.Size = new Size(277, 70);
            pnlCard1.TabIndex = 0;
            // 
            // lblCard1Valor
            // 
            lblCard1Valor.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCard1Valor.ForeColor = Color.FromArgb(15, 33, 55);
            lblCard1Valor.Location = new Point(15, 30);
            lblCard1Valor.Name = "lblCard1Valor";
            lblCard1Valor.Size = new Size(100, 40);
            lblCard1Valor.TabIndex = 0;
            lblCard1Valor.Text = "0";
            // 
            // lblCard1Titulo
            // 
            lblCard1Titulo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCard1Titulo.ForeColor = Color.Gray;
            lblCard1Titulo.Location = new Point(15, 12);
            lblCard1Titulo.Name = "lblCard1Titulo";
            lblCard1Titulo.Size = new Size(100, 23);
            lblCard1Titulo.TabIndex = 1;
            lblCard1Titulo.Text = "TOTAL USUARIOS";
            // 
            // pnlCard2
            // 
            pnlCard2.BackColor = Color.White;
            pnlCard2.Controls.Add(lblCard2Valor);
            pnlCard2.Controls.Add(lblCard2Titulo);
            pnlCard2.Dock = DockStyle.Fill;
            pnlCard2.Location = new Point(292, 15);
            pnlCard2.Margin = new Padding(5, 15, 5, 15);
            pnlCard2.Name = "pnlCard2";
            pnlCard2.Size = new Size(277, 70);
            pnlCard2.TabIndex = 1;
            // 
            // lblCard2Valor
            // 
            lblCard2Valor.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCard2Valor.ForeColor = Color.FromArgb(40, 167, 69);
            lblCard2Valor.Location = new Point(15, 30);
            lblCard2Valor.Name = "lblCard2Valor";
            lblCard2Valor.Size = new Size(100, 40);
            lblCard2Valor.TabIndex = 0;
            lblCard2Valor.Text = "0";
            // 
            // lblCard2Titulo
            // 
            lblCard2Titulo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCard2Titulo.ForeColor = Color.Gray;
            lblCard2Titulo.Location = new Point(15, 12);
            lblCard2Titulo.Name = "lblCard2Titulo";
            lblCard2Titulo.Size = new Size(100, 23);
            lblCard2Titulo.TabIndex = 1;
            lblCard2Titulo.Text = "USUARIOS ACTIVOS";
            // 
            // pnlCard3
            // 
            pnlCard3.BackColor = Color.White;
            pnlCard3.Controls.Add(lblCard3Valor);
            pnlCard3.Controls.Add(lblCard3Titulo);
            pnlCard3.Dock = DockStyle.Fill;
            pnlCard3.Location = new Point(579, 15);
            pnlCard3.Margin = new Padding(5, 15, 5, 15);
            pnlCard3.Name = "pnlCard3";
            pnlCard3.Size = new Size(277, 70);
            pnlCard3.TabIndex = 2;
            // 
            // lblCard3Valor
            // 
            lblCard3Valor.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCard3Valor.ForeColor = Color.FromArgb(0, 122, 255);
            lblCard3Valor.Location = new Point(15, 30);
            lblCard3Valor.Name = "lblCard3Valor";
            lblCard3Valor.Size = new Size(100, 40);
            lblCard3Valor.TabIndex = 0;
            lblCard3Valor.Text = "0";
            // 
            // lblCard3Titulo
            // 
            lblCard3Titulo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCard3Titulo.ForeColor = Color.Gray;
            lblCard3Titulo.Location = new Point(15, 12);
            lblCard3Titulo.Name = "lblCard3Titulo";
            lblCard3Titulo.Size = new Size(100, 23);
            lblCard3Titulo.TabIndex = 1;
            lblCard3Titulo.Text = "ESTUDIANTES";
            // 
            // pnlCard4
            // 
            pnlCard4.BackColor = Color.White;
            pnlCard4.Controls.Add(lblCard4Valor);
            pnlCard4.Controls.Add(lblCard4Titulo);
            pnlCard4.Dock = DockStyle.Fill;
            pnlCard4.Location = new Point(871, 15);
            pnlCard4.Margin = new Padding(10, 15, 0, 15);
            pnlCard4.Name = "pnlCard4";
            pnlCard4.Size = new Size(279, 70);
            pnlCard4.TabIndex = 3;
            // 
            // lblCard4Valor
            // 
            lblCard4Valor.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCard4Valor.ForeColor = Color.FromArgb(220, 53, 69);
            lblCard4Valor.Location = new Point(15, 30);
            lblCard4Valor.Name = "lblCard4Valor";
            lblCard4Valor.Size = new Size(100, 40);
            lblCard4Valor.TabIndex = 0;
            lblCard4Valor.Text = "0";
            // 
            // lblCard4Titulo
            // 
            lblCard4Titulo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCard4Titulo.ForeColor = Color.Gray;
            lblCard4Titulo.Location = new Point(15, 12);
            lblCard4Titulo.Name = "lblCard4Titulo";
            lblCard4Titulo.Size = new Size(100, 23);
            lblCard4Titulo.TabIndex = 1;
            lblCard4Titulo.Text = "INACTIVOS";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(btnNuevoUsuario);
            pnlHeader.Controls.Add(btnRefrescar);
            pnlHeader.Controls.Add(lblSubtituloHeader);
            pnlHeader.Controls.Add(lblTituloHeader);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(25, 25);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(20);
            pnlHeader.Size = new Size(1150, 80);
            pnlHeader.TabIndex = 0;
            // 
            // btnNuevoUsuario
            // 
            btnNuevoUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoUsuario.BackColor = Color.FromArgb(15, 33, 55);
            btnNuevoUsuario.FlatAppearance.BorderSize = 0;
            btnNuevoUsuario.FlatStyle = FlatStyle.Flat;
            btnNuevoUsuario.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNuevoUsuario.ForeColor = Color.White;
            btnNuevoUsuario.Location = new Point(990, 20);
            btnNuevoUsuario.Name = "btnNuevoUsuario";
            btnNuevoUsuario.Size = new Size(140, 40);
            btnNuevoUsuario.TabIndex = 2;
            btnNuevoUsuario.Text = "+ Nuevo Usuario";
            btnNuevoUsuario.UseVisualStyleBackColor = false;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefrescar.BackColor = Color.FromArgb(230, 235, 242);
            btnRefrescar.FlatAppearance.BorderSize = 0;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRefrescar.ForeColor = Color.FromArgb(15, 33, 55);
            btnRefrescar.Location = new Point(870, 20);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(110, 40);
            btnRefrescar.TabIndex = 3;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = false;
            // 
            // lblSubtituloHeader
            // 
            lblSubtituloHeader.AutoSize = true;
            lblSubtituloHeader.Font = new Font("Segoe UI", 9.5F);
            lblSubtituloHeader.ForeColor = Color.Gray;
            lblSubtituloHeader.Location = new Point(17, 45);
            lblSubtituloHeader.Name = "lblSubtituloHeader";
            lblSubtituloHeader.Size = new Size(420, 17);
            lblSubtituloHeader.TabIndex = 1;
            lblSubtituloHeader.Text = "Administra cuentas institucionales, estados, roles y tarjetas de recarga.";
            // 
            // lblTituloHeader
            // 
            lblTituloHeader.AutoSize = true;
            lblTituloHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloHeader.ForeColor = Color.FromArgb(15, 33, 55);
            lblTituloHeader.Location = new Point(15, 12);
            lblTituloHeader.Name = "lblTituloHeader";
            lblTituloHeader.Size = new Size(219, 30);
            lblTituloHeader.TabIndex = 0;
            lblTituloHeader.Text = "Gestión de Usuarios";
            // 
            // FrmGestionUsuario
            // 
            ClientSize = new Size(1200, 750);
            Controls.Add(pnlMainContainer);
            Name = "FrmGestionUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Usuarios - SGA";
            pnlMainContainer.ResumeLayout(false);
            pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            pnlGridFooter.ResumeLayout(false);
            pnlGridHeader.ResumeLayout(false);
            pnlFiltros.ResumeLayout(false);
            pnlFiltros.PerformLayout();
            tlpCards.ResumeLayout(false);
            pnlCard1.ResumeLayout(false);
            pnlCard2.ResumeLayout(false);
            pnlCard3.ResumeLayout(false);
            pnlCard4.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMainContainer;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTituloHeader;
        private System.Windows.Forms.Label lblSubtituloHeader;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.Button btnRefrescar;

        private System.Windows.Forms.TableLayoutPanel tlpCards;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblCard1Titulo;
        private System.Windows.Forms.Label lblCard1Valor;

        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblCard2Titulo;
        private System.Windows.Forms.Label lblCard2Valor;

        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblCard3Titulo;
        private System.Windows.Forms.Label lblCard3Valor;

        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Label lblCard4Titulo;
        private System.Windows.Forms.Label lblCard4Valor;

        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnLimpiarFiltros;

        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.Panel pnlGridHeader;
        private System.Windows.Forms.Label lblTablaTitulo;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Panel pnlGridFooter;
        private System.Windows.Forms.Label lblTotalRegistros;
    }
}