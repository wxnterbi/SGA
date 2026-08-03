namespace SGA.Desktop
{
    partial class FrmMainDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            btnCerrarSesion = new Button();
            btnReportes = new Button();
            btnRutaHorarios = new Button();
            btnTransporte = new Button();
            btnUsuarios = new Button();
            btnViajes = new Button();
            pnlLogoContainer = new Panel();
            lblSubtituloLogo = new Label();
            lblTituloLogo = new Label();
            pnlHeader = new Panel();
            lblUsuarioLogueado = new Label();
            lblTituloSeccion = new Label();
            pnlContenedor = new Panel();
            pnlSidebar.SuspendLayout();
            pnlLogoContainer.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(0, 40, 85); // Azul Marino ITLA
            pnlSidebar.Controls.Add(btnCerrarSesion);
            pnlSidebar.Controls.Add(btnReportes);
            pnlSidebar.Controls.Add(btnRutaHorarios);
            pnlSidebar.Controls.Add(btnTransporte);
            pnlSidebar.Controls.Add(btnUsuarios);
            pnlSidebar.Controls.Add(btnViajes);
            pnlSidebar.Controls.Add(pnlLogoContainer);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(240, 681);
            pnlSidebar.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = Color.FromArgb(248, 113, 113);
            btnCerrarSesion.Location = new Point(0, 631);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Padding = new Padding(20, 0, 0, 0);
            btnCerrarSesion.Size = new Size(240, 50);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "🚪  Cerrar Sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnReportes
            // 
            btnReportes.Cursor = Cursors.Hand;
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnReportes.ForeColor = Color.FromArgb(226, 232, 240);
            btnReportes.Location = new Point(0, 280);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(20, 0, 0, 0);
            btnReportes.Size = new Size(240, 50);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "📊  Reportes y Auditoría";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnRutaHorarios
            // 
            btnRutaHorarios.Cursor = Cursors.Hand;
            btnRutaHorarios.Dock = DockStyle.Top;
            btnRutaHorarios.FlatAppearance.BorderSize = 0;
            btnRutaHorarios.FlatStyle = FlatStyle.Flat;
            btnRutaHorarios.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnRutaHorarios.ForeColor = Color.FromArgb(226, 232, 240);
            btnRutaHorarios.Location = new Point(0, 230);
            btnRutaHorarios.Name = "btnRutaHorarios";
            btnRutaHorarios.Padding = new Padding(20, 0, 0, 0);
            btnRutaHorarios.Size = new Size(240, 50);
            btnRutaHorarios.TabIndex = 4;
            btnRutaHorarios.Text = "🗺️  Rutas y Horarios";
            btnRutaHorarios.TextAlign = ContentAlignment.MiddleLeft;
            btnRutaHorarios.UseVisualStyleBackColor = true;
            btnRutaHorarios.Click += btnRutaHorarios_Click;
            // 
            // btnTransporte
            // 
            btnTransporte.Cursor = Cursors.Hand;
            btnTransporte.Dock = DockStyle.Top;
            btnTransporte.FlatAppearance.BorderSize = 0;
            btnTransporte.FlatStyle = FlatStyle.Flat;
            btnTransporte.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnTransporte.ForeColor = Color.FromArgb(226, 232, 240);
            btnTransporte.Location = new Point(0, 180);
            btnTransporte.Name = "btnTransporte";
            btnTransporte.Padding = new Padding(20, 0, 0, 0);
            btnTransporte.Size = new Size(240, 50);
            btnTransporte.TabIndex = 3;
            btnTransporte.Text = "🚌  Gestión Autobuses";
            btnTransporte.TextAlign = ContentAlignment.MiddleLeft;
            btnTransporte.UseVisualStyleBackColor = true;
            btnTransporte.Click += btnTransporte_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnUsuarios.ForeColor = Color.FromArgb(226, 232, 240);
            btnUsuarios.Location = new Point(0, 130);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(20, 0, 0, 0);
            btnUsuarios.Size = new Size(240, 50);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "👥  Gestión Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnViajes
            // 
            btnViajes.Cursor = Cursors.Hand;
            btnViajes.Dock = DockStyle.Top;
            btnViajes.FlatAppearance.BorderSize = 0;
            btnViajes.FlatStyle = FlatStyle.Flat;
            btnViajes.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnViajes.ForeColor = Color.White;
            btnViajes.Location = new Point(0, 80);
            btnViajes.Name = "btnViajes";
            btnViajes.Padding = new Padding(20, 0, 0, 0);
            btnViajes.Size = new Size(240, 50);
            btnViajes.TabIndex = 1;
            btnViajes.Text = "🚍  Control de Viajes";
            btnViajes.TextAlign = ContentAlignment.MiddleLeft;
            btnViajes.UseVisualStyleBackColor = true;
            btnViajes.Click += btnViajes_Click;
            // 
            // pnlLogoContainer
            // 
            pnlLogoContainer.Controls.Add(lblSubtituloLogo);
            pnlLogoContainer.Controls.Add(lblTituloLogo);
            pnlLogoContainer.Dock = DockStyle.Top;
            pnlLogoContainer.Location = new Point(0, 0);
            pnlLogoContainer.Name = "pnlLogoContainer";
            pnlLogoContainer.Size = new Size(240, 80);
            pnlLogoContainer.TabIndex = 0;
            // 
            // lblSubtituloLogo
            // 
            lblSubtituloLogo.AutoSize = true;
            lblSubtituloLogo.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblSubtituloLogo.ForeColor = Color.FromArgb(230, 81, 0); // Naranja ITLA
            lblSubtituloLogo.Location = new Point(20, 45);
            lblSubtituloLogo.Name = "lblSubtituloLogo";
            lblSubtituloLogo.Size = new Size(130, 13);
            lblSubtituloLogo.TabIndex = 1;
            lblSubtituloLogo.Text = "SISTEMA DE AUTOBUSES";
            // 
            // lblTituloLogo
            // 
            lblTituloLogo.AutoSize = true;
            lblTituloLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloLogo.ForeColor = Color.White;
            lblTituloLogo.Location = new Point(18, 15);
            lblTituloLogo.Name = "lblTituloLogo";
            lblTituloLogo.Size = new Size(122, 30);
            lblTituloLogo.TabIndex = 0;
            lblTituloLogo.Text = "SGA ITLA";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblUsuarioLogueado);
            pnlHeader.Controls.Add(lblTituloSeccion);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(240, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1024, 60);
            pnlHeader.TabIndex = 1;
            // 
            // lblUsuarioLogueado
            // 
            lblUsuarioLogueado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsuarioLogueado.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblUsuarioLogueado.ForeColor = Color.FromArgb(71, 85, 105);
            lblUsuarioLogueado.Location = new Point(704, 18);
            lblUsuarioLogueado.Name = "lblUsuarioLogueado";
            lblUsuarioLogueado.Size = new Size(300, 25);
            lblUsuarioLogueado.TabIndex = 1;
            lblUsuarioLogueado.Text = "👤 Admin | ITLA";
            lblUsuarioLogueado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTituloSeccion
            // 
            lblTituloSeccion.AutoSize = true;
            lblTituloSeccion.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTituloSeccion.ForeColor = Color.FromArgb(15, 23, 42);
            lblTituloSeccion.Location = new Point(25, 17);
            lblTituloSeccion.Name = "lblTituloSeccion";
            lblTituloSeccion.Size = new Size(150, 25);
            lblTituloSeccion.TabIndex = 0;
            lblTituloSeccion.Text = "Control de Viajes";
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.FromArgb(248, 250, 252);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(240, 60);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1024, 621);
            pnlContenedor.TabIndex = 2;
            // 
            // FrmMainDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            MinimumSize = new Size(1024, 600);
            Name = "FrmMainDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SGA - Sistema de Gestión de Autobuses ITLA";
            pnlSidebar.ResumeLayout(false);
            pnlLogoContainer.ResumeLayout(false);
            pnlLogoContainer.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlLogoContainer;
        private Label lblTituloLogo;
        private Label lblSubtituloLogo;
        private Button btnViajes;
        private Button btnUsuarios;
        private Button btnTransporte;
        private Button btnRutaHorarios;
        private Button btnReportes;
        private Button btnCerrarSesion;
        private Panel pnlHeader;
        private Label lblTituloSeccion;
        private Label lblUsuarioLogueado;
        private Panel pnlContenedor;
    }
}