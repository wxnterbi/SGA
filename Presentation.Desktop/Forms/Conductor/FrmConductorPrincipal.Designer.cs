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
            lblTitulo.Location = new Point(22, 17);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(423, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE CONDUCTORES";
            lblTitulo.Click += lblTitulo_Click;
            
            // txtBuscarNombre
            
            txtBuscarNombre.Location = new Point(27, 74);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.PlaceholderText = "Buscar conductor...";
            txtBuscarNombre.Size = new Size(232, 27);
            txtBuscarNombre.TabIndex = 1;
            
            // cmbEstado
            
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Location = new Point(284, 74);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(152, 28);
            cmbEstado.TabIndex = 2;
            
            // btnBuscar
            
            btnBuscar.BackColor = Color.FromArgb(0, 120, 215);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(462, 71);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(84, 33);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            
            // btnLimpiar
            
            btnLimpiar.BackColor = Color.Gray;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(560, 71);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(84, 33);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            
            // btnNuevo
            
            btnNuevo.BackColor = Color.FromArgb(40, 167, 69);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(853, 70);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(151, 37);
            btnNuevo.TabIndex = 5;
            btnNuevo.Text = "+ Nuevo Conductor";
            btnNuevo.UseVisualStyleBackColor = false;
            
            // dgvConductores
            
            dgvConductores.AllowUserToAddRows = false;
            dgvConductores.ColumnHeadersHeight = 29;
            dgvConductores.Location = new Point(27, 126);
            dgvConductores.MultiSelect = false;
            dgvConductores.Name = "dgvConductores";
            dgvConductores.ReadOnly = true;
            dgvConductores.RowHeadersVisible = false;
            dgvConductores.RowHeadersWidth = 51;
            dgvConductores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConductores.Size = new Size(978, 409);
            dgvConductores.TabIndex = 6;
            
            // btnDetalles
            
            btnDetalles.BackColor = Color.DeepSkyBlue;
            btnDetalles.ForeColor = Color.White;
            btnDetalles.Location = new Point(27, 557);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(107, 37);
            btnDetalles.TabIndex = 7;
            btnDetalles.Text = "Detalles";
            btnDetalles.UseVisualStyleBackColor = false;
            
            // btnActualizar
            
            btnActualizar.BackColor = Color.Gray;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(151, 557);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(107, 37);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            
            // btnEliminar
            
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(276, 557);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(107, 37);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            
            // FrmConductorPrincipal
   
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 626);
            Controls.Add(lblTitulo);
            Controls.Add(txtBuscarNombre);
            Controls.Add(cmbEstado);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvConductores);
            Controls.Add(btnDetalles);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
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