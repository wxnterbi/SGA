namespace SGA.Presentation.Desktop.Forms.Conductor
{
    partial class FrmConductorPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private TextBox txtBuscarNombre;
        private ComboBox cmbEstado;

        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnNuevo;

        private DataGridView dgvConductores;

        private Button btnDetalles;
        private Button btnActualizar;
        private Button btnEliminar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle encabezado = new DataGridViewCellStyle();
            DataGridViewCellStyle filas = new DataGridViewCellStyle();

            lblTitulo = new Label();

            txtBuscarNombre = new TextBox();
            cmbEstado = new ComboBox();

            btnBuscar = new Button();
            btnLimpiar = new Button();
            btnNuevo = new Button();

            dgvConductores = new DataGridView();

            btnDetalles = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvConductores).BeginInit();
            SuspendLayout();

            
            // lblTitulo
            
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(40, 40, 40);
            lblTitulo.Location = new Point(30, 25);
            lblTitulo.Text = "GESTIÓN DE CONDUCTORES";

            
            // txtBuscarNombre
            
            txtBuscarNombre.Location = new Point(30, 82);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.PlaceholderText = "Buscar conductor...";
            txtBuscarNombre.Size = new Size(250, 30);

            
            // cmbEstado
            
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Location = new Point(300, 82);
            cmbEstado.Size = new Size(170, 31);

            
            // btnBuscar
            
            btnBuscar.BackColor = Color.FromArgb(33, 150, 243);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(490, 80);
            btnBuscar.Size = new Size(110, 36);
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;

            
            // btnLimpiar
            
            btnLimpiar.BackColor = Color.Gray;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(615, 80);
            btnLimpiar.Size = new Size(110, 36);
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;

            
            // btnNuevo
            
            btnNuevo.BackColor = Color.FromArgb(40, 167, 69);
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(960, 70);
            btnNuevo.Size = new Size(170, 42);
            btnNuevo.Text = "+ Nuevo Conductor";
            btnNuevo.UseVisualStyleBackColor = false;

            
            // dgvConductores
            
            dgvConductores.AllowUserToAddRows = false;
            dgvConductores.AllowUserToDeleteRows = false;
            dgvConductores.AllowUserToResizeRows = false;
            dgvConductores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConductores.BackgroundColor = Color.White;
            dgvConductores.BorderStyle = BorderStyle.None;

            encabezado.Alignment = DataGridViewContentAlignment.MiddleLeft;
            encabezado.BackColor = Color.FromArgb(33, 150, 243);
            encabezado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            encabezado.ForeColor = Color.White;

            dgvConductores.ColumnHeadersDefaultCellStyle = encabezado;
            dgvConductores.ColumnHeadersHeight = 40;
            dgvConductores.EnableHeadersVisualStyles = false;

            filas.Alignment = DataGridViewContentAlignment.MiddleLeft;
            filas.BackColor = SystemColors.Window;
            filas.Font = new Font("Segoe UI", 10F);
            filas.ForeColor = SystemColors.ControlText;
            filas.SelectionBackColor = Color.FromArgb(210, 230, 255);
            filas.SelectionForeColor = Color.Black;
            filas.WrapMode = DataGridViewTriState.False;

            dgvConductores.DefaultCellStyle = filas;
            dgvConductores.Location = new Point(30, 140);
            dgvConductores.MultiSelect = false;
            dgvConductores.ReadOnly = true;
            dgvConductores.RowHeadersVisible = false;
            dgvConductores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConductores.Size = new Size(1100, 450);

            
            // btnDetalles
            
            btnDetalles.BackColor = Color.FromArgb(33, 150, 243);
            btnDetalles.Cursor = Cursors.Hand;
            btnDetalles.FlatStyle = FlatStyle.Flat;
            btnDetalles.ForeColor = Color.White;
            btnDetalles.Location = new Point(30, 630);
            btnDetalles.Size = new Size(130, 42);
            btnDetalles.Text = "Detalles";
            btnDetalles.UseVisualStyleBackColor = false;

            
            // btnEliminar
            
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(180, 630);
            btnEliminar.Size = new Size(130, 42);
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;

            
            // btnActualizar
            
            btnActualizar.BackColor = Color.Gray;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(980, 630);
            btnActualizar.Size = new Size(150, 42);
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;

            
            // FrmConductorPrincipal
            
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1180, 720);

            Controls.Add(lblTitulo);
            Controls.Add(txtBuscarNombre);
            Controls.Add(cmbEstado);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvConductores);
            Controls.Add(btnDetalles);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);

            Font = new Font("Segoe UI", 10F);
            Name = "FrmConductorPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Conductores";

            Load += FrmConductorPrincipal_Load_1;

            ((System.ComponentModel.ISupportInitialize)dgvConductores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}