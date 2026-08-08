namespace SGA.Presentation.Desktop.Forms.Autobus
{
    partial class FrmAutobusPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Button btnNuevoAutobus;

        private DataGridView dgvAutobuses;

        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnDetalle;
        private Button btnEditar;

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

            btnNuevoAutobus = new Button();

            dgvAutobuses = new DataGridView();

            btnEliminar = new Button();
            btnActualizar = new Button();
            btnDetalle = new Button();
            btnEditar = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvAutobuses).BeginInit();

            SuspendLayout();

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;

            lblTitulo.Font =
                new Font(
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
                new Size(340, 41);

            lblTitulo.TabIndex =
                0;

            lblTitulo.Text =
                "GESTIÓN DE AUTOBUSES";

            // 
            // btnNuevoAutobus
            // 
            btnNuevoAutobus.BackColor =
                Color.FromArgb(40, 167, 69);

            btnNuevoAutobus.FlatStyle =
                FlatStyle.Flat;

            btnNuevoAutobus.FlatAppearance.BorderSize = 0;

            btnNuevoAutobus.ForeColor =
                Color.White;

            btnNuevoAutobus.Location =
                new Point(940, 80);

            btnNuevoAutobus.Name =
                "btnNuevoAutobus";

            btnNuevoAutobus.Size =
                new Size(190, 42);

            btnNuevoAutobus.TabIndex =
                1;

            btnNuevoAutobus.Text =
                "+ Nuevo Autobús";

            btnNuevoAutobus.UseVisualStyleBackColor =
                false;

            // 
            // dgvAutobuses
            // 
            dgvAutobuses.AllowUserToAddRows =
                false;

            dgvAutobuses.AllowUserToDeleteRows =
                false;

            dgvAutobuses.AllowUserToResizeRows =
                false;

            dgvAutobuses.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvAutobuses.BackgroundColor =
                Color.White;

            dgvAutobuses.BorderStyle =
                BorderStyle.None;

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
                SystemColors.Highlight;

            dataGridViewCellStyle1.SelectionForeColor =
                SystemColors.HighlightText;

            dataGridViewCellStyle1.WrapMode =
                DataGridViewTriState.True;

            dgvAutobuses.ColumnHeadersDefaultCellStyle =
                dataGridViewCellStyle1;

            dgvAutobuses.ColumnHeadersHeight =
                40;

            dataGridViewCellStyle2.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            dataGridViewCellStyle2.BackColor =
                SystemColors.Window;

            dataGridViewCellStyle2.Font =
                new Font(
                    "Segoe UI",
                    10F);

            dataGridViewCellStyle2.ForeColor =
                SystemColors.ControlText;

            dataGridViewCellStyle2.SelectionBackColor =
                Color.FromArgb(210, 230, 255);

            dataGridViewCellStyle2.SelectionForeColor =
                Color.Black;

            dataGridViewCellStyle2.WrapMode =
                DataGridViewTriState.False;

            dgvAutobuses.DefaultCellStyle =
                dataGridViewCellStyle2;

            dgvAutobuses.EnableHeadersVisualStyles =
                false;

            dgvAutobuses.Location =
                new Point(30, 145);

            dgvAutobuses.MultiSelect =
                false;

            dgvAutobuses.Name =
                "dgvAutobuses";

            dgvAutobuses.ReadOnly =
                true;

            dgvAutobuses.RowHeadersVisible =
                false;

            dgvAutobuses.RowHeadersWidth =
                51;

            dgvAutobuses.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvAutobuses.Size =
                new Size(1100, 470);

            dgvAutobuses.TabIndex =
                2;

            dgvAutobuses.CellContentClick +=
                dgvAutobuses_CellContentClick;

            // 
            // btnEliminar
            // 
            btnEliminar.BackColor =
                Color.Firebrick;

            btnEliminar.FlatStyle =
                FlatStyle.Flat;

            btnEliminar.FlatAppearance.BorderSize = 0;

            btnEliminar.ForeColor =
                Color.White;

            btnEliminar.Location =
                new Point(30, 640);

            btnEliminar.Name =
                "btnEliminar";

            btnEliminar.Size =
                new Size(120, 42);

            btnEliminar.TabIndex =
                3;

            btnEliminar.Text =
                "Eliminar";

            btnEliminar.UseVisualStyleBackColor =
                false;

            // 
            // btnActualizar
            // 
            btnActualizar.BackColor =
                Color.Gray;

            btnActualizar.FlatStyle =
                FlatStyle.Flat;

            btnActualizar.FlatAppearance.BorderSize = 0;

            btnActualizar.ForeColor =
                Color.White;

            btnActualizar.Location =
                new Point(980, 640);

            btnActualizar.Name =
                "btnActualizar";

            btnActualizar.Size =
                new Size(150, 42);

            btnActualizar.TabIndex =
                4;

            btnActualizar.Text =
                "Actualizar";

            btnActualizar.UseVisualStyleBackColor =
                false;

            // 
            // btnDetalle
            // 
            btnDetalle.BackColor =
                Color.FromArgb(0, 120, 215);

            btnDetalle.FlatStyle =
                FlatStyle.Flat;

            btnDetalle.FlatAppearance.BorderSize = 0;

            btnDetalle.ForeColor =
                Color.White;

            btnDetalle.Location =
                new Point(810, 640);

            btnDetalle.Name =
                "btnDetalle";

            btnDetalle.Size =
                new Size(120, 42);

            btnDetalle.TabIndex =
                5;

            btnDetalle.Text =
                "Detalles";

            btnDetalle.UseVisualStyleBackColor =
                false;

            // 
            // btnEditar
            // 
            btnEditar.BackColor =
                Color.Goldenrod;

            btnEditar.FlatStyle =
                FlatStyle.Flat;

            btnEditar.FlatAppearance.BorderSize = 0;

            btnEditar.ForeColor =
                Color.White;

            btnEditar.Location =
                new Point(650, 640);

            btnEditar.Name =
                "btnEditar";

            btnEditar.Size =
                new Size(120, 42);

            btnEditar.TabIndex =
                6;

            btnEditar.Text =
                "Editar";

            btnEditar.UseVisualStyleBackColor =
                false;

            // 
            // FrmAutobusPrincipal
            // 
            AutoScaleDimensions =
                new SizeF(9F, 23F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.White;

            ClientSize =
                new Size(1180, 720);

            Controls.Add(
                lblTitulo);

            Controls.Add(
                btnNuevoAutobus);

            Controls.Add(
                dgvAutobuses);

            Controls.Add(
                btnEliminar);

            Controls.Add(
                btnActualizar);

            Controls.Add(
                btnDetalle);

            Controls.Add(
                btnEditar);

            Font =
                new Font(
                    "Segoe UI",
                    10F);

            Name =
                "FrmAutobusPrincipal";

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "Gestión de Autobuses";

            ((System.ComponentModel.ISupportInitialize)dgvAutobuses).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}