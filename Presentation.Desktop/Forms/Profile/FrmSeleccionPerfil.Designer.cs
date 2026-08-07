namespace SGA.Presentation.Desktop.Forms.Profile
{
    partial class FrmSeleccionPerfil
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
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnConductor;
        private System.Windows.Forms.Button btnAdministradorTransporte;
        private System.Windows.Forms.Button btnAdministradorAutorizaciones;
        private System.Windows.Forms.Button btnAuditor;
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            btnConductor = new Button();
            btnAdministradorTransporte = new Button();
            btnAdministradorAutorizaciones = new Button();
            btnAuditor = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(146, 50);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(518, 90);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SGA\nSistema de Gestión de Autobuses";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 12F);
            lblSubtitulo.Location = new Point(240, 160);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(319, 21);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Seleccione el perfil con el que desea ingresar";
            // 
            // btnConductor
            // 
            btnConductor.BackColor = SystemColors.ControlDark;
            btnConductor.FlatStyle = FlatStyle.Flat;
            btnConductor.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnConductor.Location = new Point(120, 230);
            btnConductor.Name = "btnConductor";
            btnConductor.Size = new Size(250, 80);
            btnConductor.TabIndex = 2;
            btnConductor.Text = "🚍 Conductor";
            btnConductor.UseVisualStyleBackColor = false;
            btnConductor.Click += btnConductor_Click;
            // 
            // btnAdministradorTransporte
            // 
            btnAdministradorTransporte.BackColor = SystemColors.ControlDark;
            btnAdministradorTransporte.FlatStyle = FlatStyle.Flat;
            btnAdministradorTransporte.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAdministradorTransporte.Location = new Point(430, 230);
            btnAdministradorTransporte.Name = "btnAdministradorTransporte";
            btnAdministradorTransporte.Size = new Size(250, 80);
            btnAdministradorTransporte.TabIndex = 3;
            btnAdministradorTransporte.Text = "🚌 Administrador Transporte";
            btnAdministradorTransporte.UseVisualStyleBackColor = false;
            btnAdministradorTransporte.Click += btnAdministradorTransporte_Click;
            // 
            // btnAdministradorAutorizaciones
            // 
            btnAdministradorAutorizaciones.BackColor = SystemColors.ControlDark;
            btnAdministradorAutorizaciones.FlatStyle = FlatStyle.Flat;
            btnAdministradorAutorizaciones.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAdministradorAutorizaciones.Location = new Point(120, 350);
            btnAdministradorAutorizaciones.Name = "btnAdministradorAutorizaciones";
            btnAdministradorAutorizaciones.Size = new Size(250, 80);
            btnAdministradorAutorizaciones.TabIndex = 4;
            btnAdministradorAutorizaciones.Text = "🔐 Administrador Autorizaciones";
            btnAdministradorAutorizaciones.UseVisualStyleBackColor = false;
            btnAdministradorAutorizaciones.Click += btnAdministradorAutorizaciones_Click;
            // 
            // btnAuditor
            // 
            btnAuditor.BackColor = SystemColors.ControlDark;
            btnAuditor.FlatStyle = FlatStyle.Flat;
            btnAuditor.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAuditor.Location = new Point(430, 350);
            btnAuditor.Name = "btnAuditor";
            btnAuditor.Size = new Size(250, 80);
            btnAuditor.TabIndex = 5;
            btnAuditor.Text = "📊 Auditor";
            btnAuditor.UseVisualStyleBackColor = false;
            btnAuditor.Click += btnAuditor_Click;
            // 
            // FrmSeleccionPerfil
            // 
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 500);
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(btnConductor);
            Controls.Add(btnAdministradorTransporte);
            Controls.Add(btnAdministradorAutorizaciones);
            Controls.Add(btnAuditor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmSeleccionPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selección de Perfil";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


    }
}