namespace SGA.Presentation.Desktop.Forms.Conductor
{
    partial class FrmConductorPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private ComboBox cmbEstado;
        private TextBox txtBuscarNombre;

        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnNuevo;

        private DataGridView dgvConductores;

        private Button btnDetalles;
        private Button btnEliminar;
        private Button btnActualizar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 =
                new DataGridViewCellStyle();

            DataGridViewCellStyle dataGridViewCellStyle2 =
                new DataGridViewCellStyle();

            lblTitulo = new Label();

            cmbEstado = new ComboBox();
            txtBuscarNombre = new TextBox();

            btnBuscar = new Button();
            btnLimpiar = new Button();
            btnNuevo = new Button();

            dgvConductores = new DataGridView();

            btnDetalles = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvConductores).BeginInit();

            SuspendLayout();

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font(
                "Segoe UI",
                18F,
                FontStyle.Bold);

            lblTitulo.ForeColor =
                Color.FromArgb(40, 40, 40);

            lblTitulo.Location =
                new Point(25, 20);

            lblTitulo.Name =
                "lblTitulo";

            lblTitulo.Size =
                new Size(390, 41);

            lblTitulo.TabIndex = 0;

            lblTitulo.Text =
                "GESTIÓN DE CONDUCTORES";

            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbEstado.Font =
                new Font("Segoe UI", 10F);

            cmbEstado.Location =
                new Point(30, 85);

            cmbEstado.Name =
                "cmbEstado";

            cmbEstado.Size =
                new Size(160, 31);

            cmbEstado.TabIndex = 1;

            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Font =
                new Font("Segoe UI", 10F);

            txtBuscarNombre.Location =
                new Point(210, 85);

            txtBuscarNombre.Name =
                "txtBuscarNombre";

            txtBuscarNombre.PlaceholderText =
                "Buscar conductor...";

            txtBuscarNombre.Size =
                new Size(300, 30);

            txtBuscarNombre.TabIndex = 2;

            // 
            // btnBuscar
            // 
            btnBuscar.BackColor =
                Color.FromArgb(0, 120, 215);

            btnBuscar.Cursor =
                Cursors.Hand;

            btnBuscar.FlatStyle =
                FlatStyle.Flat;

            btnBuscar.ForeColor =
                Color.White;

            btnBuscar.Location =
                new Point(530, 82);

            btnBuscar.Name =
                "btnBuscar";

            btnBuscar.Size =
                new Size(95, 38);

            btnBuscar.TabIndex = 3;

            btnBuscar.Text =
                "Buscar";

            btnBuscar.UseVisualStyleBackColor =
                false;

            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor =
                Color.Gray;

            btnLimpiar.Cursor =
                Cursors.Hand;

            btnLimpiar.FlatStyle =
                FlatStyle.Flat;

            btnLimpiar.ForeColor =
                Color.White;

            btnLimpiar.Location =
                new Point(640, 82);

            btnLimpiar.Name =
                "btnLimpiar";

            btnLimpiar.Size =
                new Size(95, 38);

            btnLimpiar.TabIndex = 4;

            btnLimpiar.Text =
                "Limpiar";

            btnLimpiar.UseVisualStyleBackColor =
                false;

            // 
            // btnNuevo
            // 
            btnNuevo.BackColor =
                Color.FromArgb(40, 167, 69);

            btnNuevo.Cursor =
                Cursors.Hand;

            btnNuevo.FlatStyle =
                FlatStyle.Flat;

            btnNuevo.ForeColor =
                Color.White;

            btnNuevo.Location =
                new Point(960, 80);

            btnNuevo.Name =
                "btnNuevo";

            btnNuevo.Size =
                new Size(170, 42);

            btnNuevo.TabIndex = 5;

            btnNuevo.Text =
                "+ Nuevo Conductor";

            btnNuevo.UseVisualStyleBackColor =
                false;

            // 
            // dgvConductores
            // 
            dgvConductores.AllowUserToAddRows =
                false;

            dgvConductores.AllowUserToDeleteRows =
                false;

            dgvConductores.AllowUserToResizeRows =
                false;

            dgvConductores.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvConductores.BackgroundColor =
                Color.White;

            dgvConductores.BorderStyle =
                BorderStyle.None;

            // Encabezado
            dataGridViewCellStyle1.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            dataGridViewCellStyle1.BackColor =
                Color.FromArgb(33, 150, 243);

            dataGridViewCellStyle1.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            dataGridViewCellStyle1.ForeColor =
                Color.White;

            dataGridViewCellStyle1.SelectionBackColor =
                Color.FromArgb(33, 150, 243);

            dataGridViewCellStyle1.SelectionForeColor =
                Color.White;

            dataGridViewCellStyle1.WrapMode =
                DataGridViewTriState.True;

            dgvConductores.ColumnHeadersDefaultCellStyle =
                dataGridViewCellStyle1;

            dgvConductores.ColumnHeadersHeight =
                40;

            // Celdas
            dataGridViewCellStyle2.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            dataGridViewCellStyle2.BackColor =
                SystemColors.Window;

            dataGridViewCellStyle2.Font =
                new Font("Segoe UI", 10F);

            dataGridViewCellStyle2.ForeColor =
                SystemColors.ControlText;

            dataGridViewCellStyle2.SelectionBackColor =
                Color.FromArgb(210, 230, 255);

            dataGridViewCellStyle2.SelectionForeColor =
                Color.Black;

            dataGridViewCellStyle2.WrapMode =
                DataGridViewTriState.False;

            dgvConductores.DefaultCellStyle =
                dataGridViewCellStyle2;

            dgvConductores.EnableHeadersVisualStyles =
                false;

            dgvConductores.Location =
                new Point(30, 145);

            dgvConductores.MultiSelect =
                false;

            dgvConductores.Name =
                "dgvConductores";

            dgvConductores.ReadOnly =
                true;

            dgvConductores.RowHeadersVisible =
                false;

            dgvConductores.RowHeadersWidth =
                51;

            dgvConductores.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvConductores.Size =
                new Size(1100, 470);

            dgvConductores.TabIndex = 6;

            dgvConductores.CellContentClick +=
                dgvConductores_CellContentClick;

            // 
            // btnDetalles
            // 
            btnDetalles.BackColor =
                Color.FromArgb(0, 120, 215);

            btnDetalles.Cursor =
                Cursors.Hand;

            btnDetalles.FlatStyle =
                FlatStyle.Flat;

            btnDetalles.ForeColor =
                Color.White;

            btnDetalles.Location =
                new Point(810, 640);

            btnDetalles.Name =
                "btnDetalles";

            btnDetalles.Size =
                new Size(120, 42);

            btnDetalles.TabIndex = 7;

            btnDetalles.Text =
                "Detalles";

            btnDetalles.UseVisualStyleBackColor =
                false;

            // 
            // btnEliminar
            // 
            btnEliminar.BackColor =
                Color.Firebrick;

            btnEliminar.Cursor =
                Cursors.Hand;

            btnEliminar.FlatStyle =
                FlatStyle.Flat;

            btnEliminar.ForeColor =
                Color.White;

            btnEliminar.Location =
                new Point(30, 640);

            btnEliminar.Name =
                "btnEliminar";

            btnEliminar.Size =
                new Size(120, 42);

            btnEliminar.TabIndex = 8;

            btnEliminar.Text =
                "Eliminar";

            btnEliminar.UseVisualStyleBackColor =
                false;

            // 
            // btnActualizar
            // 
            btnActualizar.BackColor =
                Color.Gray;

            btnActualizar.Cursor =
                Cursors.Hand;

            btnActualizar.FlatStyle =
                FlatStyle.Flat;

            btnActualizar.ForeColor =
                Color.White;

            btnActualizar.Location =
                new Point(980, 640);

            btnActualizar.Name =
                "btnActualizar";

            btnActualizar.Size =
                new Size(150, 42);

            btnActualizar.TabIndex = 9;

            btnActualizar.Text =
                "Actualizar";

            btnActualizar.UseVisualStyleBackColor =
                false;

            // 
            // FrmConductorPrincipal
            // 
            AutoScaleDimensions =
                new SizeF(9F, 23F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.White;

            ClientSize =
                new Size(1180, 720);

            Controls.Add(lblTitulo);

            Controls.Add(cmbEstado);
            Controls.Add(txtBuscarNombre);

            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnNuevo);

            Controls.Add(dgvConductores);

            Controls.Add(btnDetalles);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);

            Font =
                new Font("Segoe UI", 10F);

            Name =
                "FrmConductorPrincipal";

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "Gestión de Conductores";

            Load +=
                FrmConductorPrincipal_Load;

            ((System.ComponentModel.ISupportInitialize)
                dgvConductores).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}