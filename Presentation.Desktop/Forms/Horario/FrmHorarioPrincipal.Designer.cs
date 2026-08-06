namespace SGA.Presentation.Desktop.Forms.Horario
{
    partial class FrmHorarioPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Button btnNuevoHorario;
        private Button btnDetalles;
        private Button btnEliminar;
        private Button btnActualizar;

        private DataGridView dgvHorarios;


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
            btnNuevoHorario = new Button();
            btnDetalles = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            dgvHorarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvHorarios).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(40, 40, 40);
            lblTitulo.Location = new Point(30, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(358, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE HORARIOS";
            // 
            // btnNuevoHorario
            // 
            btnNuevoHorario.BackColor = Color.FromArgb(40, 167, 69);
            btnNuevoHorario.Cursor = Cursors.Hand;
            btnNuevoHorario.FlatStyle = FlatStyle.Flat;
            btnNuevoHorario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevoHorario.ForeColor = Color.White;
            btnNuevoHorario.Location = new Point(960, 70);
            btnNuevoHorario.Name = "btnNuevoHorario";
            btnNuevoHorario.Size = new Size(170, 42);
            btnNuevoHorario.TabIndex = 1;
            btnNuevoHorario.Text = "+ Nuevo Horario";
            btnNuevoHorario.UseVisualStyleBackColor = false;
            // 
            // btnDetalles
            // 
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
            // 
            // btnEliminar
            // 
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
            // 
            // btnActualizar
            // 
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
            // 
            // dgvHorarios
            // 
            dgvHorarios.AllowUserToAddRows = false;
            dgvHorarios.AllowUserToDeleteRows = false;
            dgvHorarios.AllowUserToResizeRows = false;
            dgvHorarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHorarios.BackgroundColor = Color.White;
            dgvHorarios.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dgvHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHorarios.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(210, 230, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHorarios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHorarios.EnableHeadersVisualStyles = false;
            dgvHorarios.Location = new Point(30, 140);
            dgvHorarios.MultiSelect = false;
            dgvHorarios.Name = "dgvHorarios";
            dgvHorarios.ReadOnly = true;
            dgvHorarios.RowHeadersVisible = false;
            dgvHorarios.RowHeadersWidth = 51;
            dgvHorarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHorarios.Size = new Size(1100, 450);
            dgvHorarios.TabIndex = 2;
            dgvHorarios.CellContentClick += dgvHorarios_CellContentClick_1;
            // 
            // FrmHorarioPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1180, 720);
            Controls.Add(lblTitulo);
            Controls.Add(btnNuevoHorario);
            Controls.Add(dgvHorarios);
            Controls.Add(btnDetalles);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Font = new Font("Segoe UI", 10F);
            Name = "FrmHorarioPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Horarios";
            Load += FrmHorarioPrincipal_Load_2;
            ((System.ComponentModel.ISupportInitialize)dgvHorarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}