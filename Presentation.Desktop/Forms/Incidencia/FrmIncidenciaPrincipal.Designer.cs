namespace SGA.Presentation.Desktop.Forms.Incidencia
{
    partial class FrmIncidenciaPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Button btnNuevaIncidencia;
        private Button btnDetalles;
        private Button btnEliminar;
        private Button btnActualizar;

        private DataGridView dgvIncidencias;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            btnNuevaIncidencia = new Button();
            btnDetalles = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            dgvIncidencias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvIncidencias).BeginInit();
            SuspendLayout();
            // lblTitulo
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(40, 40, 40);
            lblTitulo.Location = new Point(30, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(396, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE INCIDENCIAS";
            // btnNuevaIncidencia
            btnNuevaIncidencia.BackColor = Color.FromArgb(40, 167, 69);
            btnNuevaIncidencia.Cursor = Cursors.Hand;
            btnNuevaIncidencia.FlatStyle = FlatStyle.Flat;
            btnNuevaIncidencia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevaIncidencia.ForeColor = Color.White;
            btnNuevaIncidencia.Location = new Point(950, 70);
            btnNuevaIncidencia.Name = "btnNuevaIncidencia";
            btnNuevaIncidencia.Size = new Size(180, 42);
            btnNuevaIncidencia.TabIndex = 1;
            btnNuevaIncidencia.Text = "+ Nueva Incidencia";
            btnNuevaIncidencia.UseVisualStyleBackColor = false;
            // dgvIncidencias
            dgvIncidencias.AllowUserToAddRows = false;
            dgvIncidencias.AllowUserToDeleteRows = false;
            dgvIncidencias.AllowUserToResizeRows = false;
            dgvIncidencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIncidencias.BackgroundColor = Color.White;
            dgvIncidencias.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dgvIncidencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvIncidencias.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(210, 230, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvIncidencias.DefaultCellStyle = dataGridViewCellStyle2;
            dgvIncidencias.EnableHeadersVisualStyles = false;
            dgvIncidencias.Location = new Point(30, 140);
            dgvIncidencias.MultiSelect = false;
            dgvIncidencias.Name = "dgvIncidencias";
            dgvIncidencias.ReadOnly = true;
            dgvIncidencias.RowHeadersVisible = false;
            dgvIncidencias.RowHeadersWidth = 51;
            dgvIncidencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIncidencias.Size = new Size(1100, 450);
            dgvIncidencias.TabIndex = 2;
            dgvIncidencias.CellContentClick += dgvIncidencias_CellContentClick;
            // btnDetalles
            btnDetalles.BackColor = Color.FromArgb(33, 150, 243);
            btnDetalles.Cursor = Cursors.Hand;
            btnDetalles.FlatStyle = FlatStyle.Flat;
            btnDetalles.ForeColor = Color.White;
            btnDetalles.Location = new Point(30, 630);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(130, 42);
            btnDetalles.TabIndex = 3;
            btnDetalles.Text = "Detalles";
            btnDetalles.UseVisualStyleBackColor = false;
            // btnEliminar
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(180, 630);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 42);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // btnActualizar
            btnActualizar.BackColor = Color.Gray;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(980, 630);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(150, 42);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // FrmIncidenciaPrincipal
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1180, 720);
            Controls.Add(lblTitulo);
            Controls.Add(btnNuevaIncidencia);
            Controls.Add(dgvIncidencias);
            Controls.Add(btnDetalles);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Font = new Font("Segoe UI", 10F);
            Name = "FrmIncidenciaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Incidencias";
            Load += FrmIncidenciaPrincipal_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvIncidencias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}