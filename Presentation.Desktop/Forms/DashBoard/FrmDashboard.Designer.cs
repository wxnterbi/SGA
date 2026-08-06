using System.Drawing;
using System.Windows.Forms;

namespace SGA.Presentation.Desktop.Forms.DashBoard
{
    partial class FrmDashboard
    {

        private Label lblTitulo;


        private void InitializeComponent()
        {
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(25, 42, 86);
            lblTitulo.Location = new Point(40, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(624, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Bienvenido al Sistema de Gestión de Autobuses";
            // 
            // FrmDashboard
            // 
            BackColor = Color.FromArgb(240, 242, 245);
            Controls.Add(lblTitulo);
            Name = "FrmDashboard";
            Size = new Size(1093, 501);
            ResumeLayout(false);
            PerformLayout();

        }

    }
}