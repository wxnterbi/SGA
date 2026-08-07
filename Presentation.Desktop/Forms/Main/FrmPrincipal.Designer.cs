namespace SGA.Presentation.Desktop.Forms.Main
{
    partial class FrmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlMenu;
        private Panel pnlTop;
        private Panel pnlContent;

        private PictureBox picLogo;

        private Label lblTitulo;
        private Label lblUsuario;
        private Label lblRol;

        private Button btnDashboard;
        private Button btnViajes;
        private Button btnAutobuses;
        private Button btnConductores;
        private Button btnRutas;
        private Button btnHorarios;
        private Button btnParadas;
        private Button btnUsuarios;
        private Button btnIncidencias;
        private Button btnAuditoria;
        private Button btnCerrarSesion;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            pnlMenu = new Panel();
            picLogo = new PictureBox();
            lblTitulo = new Label();
            btnDashboard = new Button();
            btnViajes = new Button();
            btnAutobuses = new Button();
            btnConductores = new Button();
            btnRutas = new Button();
            btnHorarios = new Button();
            btnParadas = new Button();
            btnUsuarios = new Button();
            btnIncidencias = new Button();
            btnAuditoria = new Button();
            btnCerrarSesion = new Button();
            pnlTop = new Panel();
            lblUsuario = new Label();
            lblRol = new Label();
            pnlContent = new Panel();
            label1 = new Label();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(25, 42, 86);
            pnlMenu.Controls.Add(label1);
            pnlMenu.Controls.Add(picLogo);
            pnlMenu.Controls.Add(lblTitulo);
            pnlMenu.Controls.Add(btnDashboard);
            pnlMenu.Controls.Add(btnViajes);
            pnlMenu.Controls.Add(btnAutobuses);
            pnlMenu.Controls.Add(btnConductores);
            pnlMenu.Controls.Add(btnRutas);
            pnlMenu.Controls.Add(btnHorarios);
            pnlMenu.Controls.Add(btnParadas);
            pnlMenu.Controls.Add(btnUsuarios);
            pnlMenu.Controls.Add(btnIncidencias);
            pnlMenu.Controls.Add(btnAuditoria);
            pnlMenu.Controls.Add(btnCerrarSesion);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(250, 800);
            pnlMenu.TabIndex = 2;
            pnlMenu.Paint += pnlMenu_Paint;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(81, 23);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(68, 69);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(53, 95);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(123, 32);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "SGA-ITLA";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(75, 23);
            btnDashboard.TabIndex = 2;
            // 
            // btnViajes
            // 
            btnViajes.Location = new Point(0, 0);
            btnViajes.Name = "btnViajes";
            btnViajes.Size = new Size(75, 23);
            btnViajes.TabIndex = 3;
            // 
            // btnAutobuses
            // 
            btnAutobuses.Location = new Point(0, 0);
            btnAutobuses.Name = "btnAutobuses";
            btnAutobuses.Size = new Size(75, 23);
            btnAutobuses.TabIndex = 4;
            // 
            // btnConductores
            // 
            btnConductores.Location = new Point(0, 0);
            btnConductores.Name = "btnConductores";
            btnConductores.Size = new Size(75, 23);
            btnConductores.TabIndex = 5;
            // 
            // btnRutas
            // 
            btnRutas.Location = new Point(0, 0);
            btnRutas.Name = "btnRutas";
            btnRutas.Size = new Size(75, 23);
            btnRutas.TabIndex = 6;
            // 
            // btnHorarios
            // 
            btnHorarios.Location = new Point(0, 0);
            btnHorarios.Name = "btnHorarios";
            btnHorarios.Size = new Size(75, 23);
            btnHorarios.TabIndex = 7;
            // 
            // btnParadas
            // 
            btnParadas.Location = new Point(0, 0);
            btnParadas.Name = "btnParadas";
            btnParadas.Size = new Size(75, 23);
            btnParadas.TabIndex = 8;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(0, 0);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(75, 23);
            btnUsuarios.TabIndex = 9;
            // 
            // btnIncidencias
            // 
            btnIncidencias.Location = new Point(0, 0);
            btnIncidencias.Name = "btnIncidencias";
            btnIncidencias.Size = new Size(75, 23);
            btnIncidencias.TabIndex = 10;
            // 
            // btnAuditoria
            // 
            btnAuditoria.Location = new Point(0, 0);
            btnAuditoria.Name = "btnAuditoria";
            btnAuditoria.Size = new Size(75, 23);
            btnAuditoria.TabIndex = 11;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(0, 0);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(75, 23);
            btnCerrarSesion.TabIndex = 12;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.White;
            pnlTop.Controls.Add(lblUsuario);
            pnlTop.Controls.Add(lblRol);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(250, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1150, 70);
            pnlTop.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(1050, 20);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(89, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario: Admin";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.ForeColor = Color.Gray;
            lblRol.Location = new Point(1050, 45);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(83, 15);
            lblRol.TabIndex = 1;
            lblRol.Text = "Administrador";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(240, 242, 245);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(250, 70);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1150, 730);
            pnlContent.TabIndex = 0;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(29, 127);
            label1.Name = "label1";
            label1.Size = new Size(181, 15);
            label1.TabIndex = 13;
            label1.Text = "Sistema de gestion de Autobuses";
            label1.Click += label1_Click;
            // 
            // FrmPrincipal
            // 
            ClientSize = new Size(1400, 800);
            Controls.Add(pnlContent);
            Controls.Add(pnlTop);
            Controls.Add(pnlMenu);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión de Autobuses";
            WindowState = FormWindowState.Maximized;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
        }

        private Label label1;
    }
}