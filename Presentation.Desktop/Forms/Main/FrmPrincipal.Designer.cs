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
            this.components = new System.ComponentModel.Container();


            this.pnlMenu = new Panel();
            this.pnlTop = new Panel();
            this.pnlContent = new Panel();


            this.picLogo = new PictureBox();


            this.lblTitulo = new Label();
            this.lblUsuario = new Label();
            this.lblRol = new Label();


            this.btnDashboard = new Button();
            this.btnViajes = new Button();
            this.btnAutobuses = new Button();
            this.btnConductores = new Button();
            this.btnRutas = new Button();
            this.btnHorarios = new Button();
            this.btnParadas = new Button();
            this.btnUsuarios = new Button();
            this.btnIncidencias = new Button();
            this.btnAuditoria = new Button();
            this.btnCerrarSesion = new Button();



            // FORMULARIO

            this.SuspendLayout();

            this.ClientSize = new Size(1400, 800);

            this.Text = "Sistema de Gestión de Autobuses";

            this.StartPosition = FormStartPosition.CenterScreen;

            this.WindowState = FormWindowState.Maximized;



            // PANEL MENU

            this.pnlMenu.Dock = DockStyle.Left;

            this.pnlMenu.Width = 250;

            this.pnlMenu.BackColor = Color.FromArgb(25, 42, 86);



            // PANEL SUPERIOR

            this.pnlTop.Dock = DockStyle.Top;

            this.pnlTop.Height = 70;

            this.pnlTop.BackColor = Color.White;



            // PANEL CONTENIDO

            this.pnlContent.Dock = DockStyle.Fill;

            this.pnlContent.BackColor = Color.FromArgb(240, 242, 245);



            // LOGO

            this.picLogo.Size = new Size(80, 80);

            this.picLogo.Location = new Point(85, 20);

            this.picLogo.SizeMode = PictureBoxSizeMode.Zoom;



            // TITULO

            this.lblTitulo.Text = "SGA";

            this.lblTitulo.ForeColor = Color.White;

            this.lblTitulo.Font = new Font(
                "Segoe UI",
                18,
                FontStyle.Bold
            );

            this.lblTitulo.AutoSize = true;

            this.lblTitulo.Location = new Point(95, 110);



            // USUARIO

            this.lblUsuario.Text = "Usuario: Admin";

            this.lblUsuario.AutoSize = true;

            this.lblUsuario.Location = new Point(1050, 20);



            // ROL

            this.lblRol.Text = "Administrador";

            this.lblRol.AutoSize = true;

            this.lblRol.ForeColor = Color.Gray;

            this.lblRol.Location = new Point(1050, 45);


            // AGREGAR CONTROLES

            this.pnlMenu.Controls.Add(this.picLogo);
            this.pnlMenu.Controls.Add(this.lblTitulo);

            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Controls.Add(this.btnViajes);
            this.pnlMenu.Controls.Add(this.btnAutobuses);
            this.pnlMenu.Controls.Add(this.btnConductores);
            this.pnlMenu.Controls.Add(this.btnRutas);
            this.pnlMenu.Controls.Add(this.btnHorarios);
            this.pnlMenu.Controls.Add(this.btnParadas);
            this.pnlMenu.Controls.Add(this.btnUsuarios);
            this.pnlMenu.Controls.Add(this.btnIncidencias);
            this.pnlMenu.Controls.Add(this.btnAuditoria);
            this.pnlMenu.Controls.Add(this.btnCerrarSesion);


            this.pnlTop.Controls.Add(this.lblUsuario);
            this.pnlTop.Controls.Add(this.lblRol);



            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMenu);



            this.ResumeLayout(false);
        }
    }
}