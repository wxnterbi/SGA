namespace SGA.Presentation.Desktop.Forms.Parada
{
    partial class FrmParadaPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;
        private Button btnNuevaParada;
        private Button btnDetalles;
        private Button btnActualizar;
        private Button btnEliminar;
        private DataGridView dgvParadas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            btnNuevaParada = new Button();
            btnDetalles = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dgvParadas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvParadas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Location = new Point(25, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(339, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE PARADAS";
            // 
            // btnNuevaParada
            // 
            btnNuevaParada.BackColor = Color.FromArgb(40, 167, 69);
            btnNuevaParada.FlatStyle = FlatStyle.Flat;
            btnNuevaParada.ForeColor = Color.White;
            btnNuevaParada.Location = new Point(820, 70);
            btnNuevaParada.Name = "btnNuevaParada";
            btnNuevaParada.Size = new Size(170, 38);
            btnNuevaParada.TabIndex = 1;
            btnNuevaParada.Text = "+ Nueva Parada";
            btnNuevaParada.UseVisualStyleBackColor = false;
            // 
            // btnDetalles
            // 
            btnDetalles.BackColor = Color.FromArgb(33, 150, 243);
            btnDetalles.FlatStyle = FlatStyle.Flat;
            btnDetalles.ForeColor = Color.White;
            btnDetalles.Location = new Point(25, 560);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(110, 38);
            btnDetalles.TabIndex = 2;
            btnDetalles.Text = "Detalles";
            btnDetalles.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Gray;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(860, 560);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(130, 38);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(150, 560);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 38);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dgvParadas
            // 
            dgvParadas.AllowUserToAddRows = false;
            dgvParadas.AllowUserToDeleteRows = false;
            dgvParadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvParadas.BackgroundColor = Color.White;
            dgvParadas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dgvParadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvParadas.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(210, 230, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvParadas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvParadas.EnableHeadersVisualStyles = false;
            dgvParadas.Location = new Point(25, 125);
            dgvParadas.Name = "dgvParadas";
            dgvParadas.ReadOnly = true;
            dgvParadas.RowHeadersVisible = false;
            dgvParadas.RowHeadersWidth = 51;
            dgvParadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParadas.Size = new Size(965, 410);
            dgvParadas.TabIndex = 5;
            dgvParadas.CellContentClick += dgvParadas_CellContentClick;
            // 
            // FrmParadaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1020, 620);
            Controls.Add(lblTitulo);
            Controls.Add(btnNuevaParada);
            Controls.Add(btnDetalles);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvParadas);
            Name = "FrmParadaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Paradas";
            Load += FrmParadaPrincipal_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvParadas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}