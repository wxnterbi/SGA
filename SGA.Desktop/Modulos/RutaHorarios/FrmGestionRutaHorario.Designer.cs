namespace SGA.Desktop.Modulos.RutaHorarios
{
    partial class FrmGestionRutaHorario
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
            pnlMainContainer = new TableLayoutPanel();
            pnlRutas = new Panel();
            dgvRutas = new DataGridView();
            pnlTopRutas = new Panel();
            lblTituloRutas = new Label();
            txtBuscarRuta = new TextBox();
            btnEditarRuta = new Button();
            btnNuevaRuta = new Button();
            pnlHorarios = new Panel();
            dgvHorarios = new DataGridView();
            pnlTopHorarios = new Panel();
            lblTituloHorarios = new Label();
            lblRutaSeleccionada = new Label();
            btnNuevoHorario = new Button();
            pnlMainContainer.SuspendLayout();
            pnlRutas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRutas).BeginInit();
            pnlTopRutas.SuspendLayout();
            pnlHorarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHorarios).BeginInit();
            pnlTopHorarios.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMainContainer
            // 
            pnlMainContainer.ColumnCount = 2;
            pnlMainContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68F));
            pnlMainContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            pnlMainContainer.Controls.Add(pnlRutas, 0, 0);
            pnlMainContainer.Controls.Add(pnlHorarios, 1, 0);
            pnlMainContainer.Dock = DockStyle.Fill;
            pnlMainContainer.Location = new Point(20, 20);
            pnlMainContainer.Name = "pnlMainContainer";
            pnlMainContainer.RowCount = 1;
            pnlMainContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlMainContainer.Size = new Size(1100, 600);
            pnlMainContainer.TabIndex = 0;
            // 
            // pnlRutas
            // 
            pnlRutas.Controls.Add(dgvRutas);
            pnlRutas.Controls.Add(pnlTopRutas);
            pnlRutas.Dock = DockStyle.Fill;
            pnlRutas.Location = new Point(0, 0);
            pnlRutas.Margin = new Padding(0, 0, 15, 0);
            pnlRutas.Name = "pnlRutas";
            pnlRutas.Size = new Size(733, 600);
            pnlRutas.TabIndex = 0;
            // 
            // dgvRutas
            // 
            dgvRutas.AllowUserToAddRows = false;
            dgvRutas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRutas.BackgroundColor = Color.White;
            dgvRutas.BorderStyle = BorderStyle.None;
            dgvRutas.Dock = DockStyle.Fill;
            dgvRutas.Location = new Point(0, 85);
            dgvRutas.MultiSelect = false;
            dgvRutas.Name = "dgvRutas";
            dgvRutas.ReadOnly = true;
            dgvRutas.RowHeadersVisible = false;
            dgvRutas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRutas.Size = new Size(733, 515);
            dgvRutas.TabIndex = 0;
            // 
            // pnlTopRutas
            // 
            pnlTopRutas.Controls.Add(lblTituloRutas);
            pnlTopRutas.Controls.Add(txtBuscarRuta);
            pnlTopRutas.Controls.Add(btnEditarRuta);
            pnlTopRutas.Controls.Add(btnNuevaRuta);
            pnlTopRutas.Dock = DockStyle.Top;
            pnlTopRutas.Location = new Point(0, 0);
            pnlTopRutas.Name = "pnlTopRutas";
            pnlTopRutas.Size = new Size(733, 85);
            pnlTopRutas.TabIndex = 1;
            // 
            // lblTituloRutas
            // 
            lblTituloRutas.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloRutas.ForeColor = Color.FromArgb(15, 33, 55);
            lblTituloRutas.Location = new Point(0, 5);
            lblTituloRutas.Name = "lblTituloRutas";
            lblTituloRutas.Size = new Size(100, 23);
            lblTituloRutas.TabIndex = 0;
            lblTituloRutas.Text = "Gestión de Rutas";
            // 
            // txtBuscarRuta
            // 
            txtBuscarRuta.Font = new Font("Segoe UI", 10F);
            txtBuscarRuta.Location = new Point(0, 45);
            txtBuscarRuta.Name = "txtBuscarRuta";
            txtBuscarRuta.PlaceholderText = "🔍 Buscar por nombre o destino...";
            txtBuscarRuta.Size = new Size(280, 25);
            txtBuscarRuta.TabIndex = 1;
            // 
            // btnEditarRuta
            // 
            btnEditarRuta.BackColor = Color.FromArgb(0, 122, 255);
            btnEditarRuta.FlatStyle = FlatStyle.Flat;
            btnEditarRuta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditarRuta.ForeColor = Color.White;
            btnEditarRuta.Location = new Point(432, 42);
            btnEditarRuta.Name = "btnEditarRuta";
            btnEditarRuta.Size = new Size(100, 32);
            btnEditarRuta.TabIndex = 2;
            btnEditarRuta.Text = "Editar";
            btnEditarRuta.UseVisualStyleBackColor = false;
            // 
            // btnNuevaRuta
            // 
            btnNuevaRuta.BackColor = Color.FromArgb(40, 167, 69);
            btnNuevaRuta.FlatStyle = FlatStyle.Flat;
            btnNuevaRuta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNuevaRuta.ForeColor = Color.White;
            btnNuevaRuta.Location = new Point(538, 42);
            btnNuevaRuta.Name = "btnNuevaRuta";
            btnNuevaRuta.Size = new Size(120, 32);
            btnNuevaRuta.TabIndex = 3;
            btnNuevaRuta.Text = "+ Nueva Ruta";
            btnNuevaRuta.UseVisualStyleBackColor = false;
            btnNuevaRuta.Click += btnNuevaRuta_Click;
            // 
            // pnlHorarios
            // 
            pnlHorarios.Controls.Add(dgvHorarios);
            pnlHorarios.Controls.Add(pnlTopHorarios);
            pnlHorarios.Dock = DockStyle.Fill;
            pnlHorarios.Location = new Point(751, 3);
            pnlHorarios.Name = "pnlHorarios";
            pnlHorarios.Size = new Size(346, 594);
            pnlHorarios.TabIndex = 1;
            // 
            // dgvHorarios
            // 
            dgvHorarios.AllowUserToAddRows = false;
            dgvHorarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHorarios.BackgroundColor = Color.White;
            dgvHorarios.BorderStyle = BorderStyle.None;
            dgvHorarios.Dock = DockStyle.Fill;
            dgvHorarios.Location = new Point(0, 85);
            dgvHorarios.MultiSelect = false;
            dgvHorarios.Name = "dgvHorarios";
            dgvHorarios.ReadOnly = true;
            dgvHorarios.RowHeadersVisible = false;
            dgvHorarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHorarios.Size = new Size(346, 509);
            dgvHorarios.TabIndex = 0;
            // 
            // pnlTopHorarios
            // 
            pnlTopHorarios.Controls.Add(lblTituloHorarios);
            pnlTopHorarios.Controls.Add(lblRutaSeleccionada);
            pnlTopHorarios.Controls.Add(btnNuevoHorario);
            pnlTopHorarios.Dock = DockStyle.Top;
            pnlTopHorarios.Location = new Point(0, 0);
            pnlTopHorarios.Name = "pnlTopHorarios";
            pnlTopHorarios.Size = new Size(346, 85);
            pnlTopHorarios.TabIndex = 1;
            // 
            // lblTituloHorarios
            // 
            lblTituloHorarios.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloHorarios.ForeColor = Color.FromArgb(15, 33, 55);
            lblTituloHorarios.Location = new Point(0, 5);
            lblTituloHorarios.Name = "lblTituloHorarios";
            lblTituloHorarios.Size = new Size(100, 23);
            lblTituloHorarios.TabIndex = 0;
            lblTituloHorarios.Text = "Horarios de Salida";
            // 
            // lblRutaSeleccionada
            // 
            lblRutaSeleccionada.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblRutaSeleccionada.ForeColor = Color.Gray;
            lblRutaSeleccionada.Location = new Point(0, 50);
            lblRutaSeleccionada.Name = "lblRutaSeleccionada";
            lblRutaSeleccionada.Size = new Size(100, 23);
            lblRutaSeleccionada.TabIndex = 1;
            lblRutaSeleccionada.Text = "Seleccione una ruta...";
            // 
            // btnNuevoHorario
            // 
            btnNuevoHorario.BackColor = Color.FromArgb(40, 167, 69);
            btnNuevoHorario.FlatStyle = FlatStyle.Flat;
            btnNuevoHorario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNuevoHorario.ForeColor = Color.White;
            btnNuevoHorario.Location = new Point(200, 42);
            btnNuevoHorario.Name = "btnNuevoHorario";
            btnNuevoHorario.Size = new Size(90, 32);
            btnNuevoHorario.TabIndex = 2;
            btnNuevoHorario.Text = "+ Horario";
            btnNuevoHorario.UseVisualStyleBackColor = false;
            btnNuevoHorario.Click += btnNuevoHorario_Click;
            // 
            // FrmGestionRutaHorario
            // 
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1140, 640);
            Controls.Add(pnlMainContainer);
            Name = "FrmGestionRutaHorario";
            Padding = new Padding(20);
            Text = "Gestión de Rutas y Horarios";
            pnlMainContainer.ResumeLayout(false);
            pnlRutas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRutas).EndInit();
            pnlTopRutas.ResumeLayout(false);
            pnlTopRutas.PerformLayout();
            pnlHorarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHorarios).EndInit();
            pnlTopHorarios.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMainContainer;
        private System.Windows.Forms.Panel pnlRutas;
        private System.Windows.Forms.Panel pnlTopRutas;
        private System.Windows.Forms.Label lblTituloRutas;
        private System.Windows.Forms.TextBox txtBuscarRuta;
        private System.Windows.Forms.Button btnNuevaRuta;
        private System.Windows.Forms.Button btnEditarRuta;
        private System.Windows.Forms.DataGridView dgvRutas;
        private System.Windows.Forms.Panel pnlHorarios;
        private System.Windows.Forms.Panel pnlTopHorarios;
        private System.Windows.Forms.Label lblTituloHorarios;
        private System.Windows.Forms.Label lblRutaSeleccionada;
        private System.Windows.Forms.Button btnNuevoHorario;
        private System.Windows.Forms.DataGridView dgvHorarios;
    }
}