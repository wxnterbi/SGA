namespace SGA.Presentation.Desktop.Forms.Parada
{
    partial class FrmParadaPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Button btnNuevaParada;
        private Button btnDetalles;
        private Button btnEliminar;
        private Button btnActualizar;

        private DataGridView dgvParadas;

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

            btnNuevaParada = new Button();
            btnDetalles = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();

            dgvParadas = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)dgvParadas).BeginInit();

            SuspendLayout();

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font =
                new Font("Segoe UI", 18F, FontStyle.Bold);

            lblTitulo.ForeColor =
                Color.FromArgb(40, 40, 40);

            lblTitulo.Location =
                new Point(25, 20);

            lblTitulo.Name =
                "lblTitulo";

            lblTitulo.Size =
                new Size(320, 41);

            lblTitulo.TabIndex = 0;

            lblTitulo.Text =
                "GESTIÓN DE PARADAS";

            // 
            // btnNuevaParada
            // 
            btnNuevaParada.BackColor =
                Color.FromArgb(40, 167, 69);

            btnNuevaParada.Cursor =
                Cursors.Hand;

            btnNuevaParada.FlatStyle =
                FlatStyle.Flat;

            btnNuevaParada.ForeColor =
                Color.White;

            btnNuevaParada.Location =
                new Point(960, 80);

            btnNuevaParada.Name =
                "btnNuevaParada";

            btnNuevaParada.Size =
                new Size(170, 42);

            btnNuevaParada.TabIndex = 1;

            btnNuevaParada.Text =
                "+ Nueva Parada";

            btnNuevaParada.UseVisualStyleBackColor =
                false;

            // 
            // dgvParadas
            // 
            dgvParadas.AllowUserToAddRows =
                false;

            dgvParadas.AllowUserToDeleteRows =
                false;

            dgvParadas.AllowUserToResizeRows =
                false;

            dgvParadas.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvParadas.BackgroundColor =
                Color.White;

            dgvParadas.BorderStyle =
                BorderStyle.None;

            dataGridViewCellStyle1.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            dataGridViewCellStyle1.BackColor =
                Color.FromArgb(33, 150, 243);

            dataGridViewCellStyle1.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            dataGridViewCellStyle1.ForeColor =
                Color.White;

            dataGridViewCellStyle1.SelectionBackColor =
                SystemColors.Highlight;

            dataGridViewCellStyle1.SelectionForeColor =
                SystemColors.HighlightText;

            dataGridViewCellStyle1.WrapMode =
                DataGridViewTriState.True;

            dgvParadas.ColumnHeadersDefaultCellStyle =
                dataGridViewCellStyle1;

            dgvParadas.ColumnHeadersHeight =
                40;

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

            dgvParadas.DefaultCellStyle =
                dataGridViewCellStyle2;

            dgvParadas.EnableHeadersVisualStyles =
                false;

            dgvParadas.Location =
                new Point(30, 145);

            dgvParadas.MultiSelect =
                false;

            dgvParadas.Name =
                "dgvParadas";

            dgvParadas.ReadOnly =
                true;

            dgvParadas.RowHeadersVisible =
                false;

            dgvParadas.RowHeadersWidth =
                51;

            dgvParadas.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvParadas.Size =
                new Size(1100, 470);

            dgvParadas.TabIndex = 2;

            dgvParadas.CellContentClick +=
                dgvParadas_CellContentClick;

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

            btnDetalles.TabIndex = 3;

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

            btnEliminar.TabIndex = 4;

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

            btnActualizar.TabIndex = 5;

            btnActualizar.Text =
                "Actualizar";

            btnActualizar.UseVisualStyleBackColor =
                false;

            // 
            // FrmParadaPrincipal
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
            Controls.Add(btnNuevaParada);
            Controls.Add(dgvParadas);
            Controls.Add(btnDetalles);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);

            Font =
                new Font("Segoe UI", 10F);

            Name =
                "FrmParadaPrincipal";

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "Gestión de Paradas";

            Load +=
                FrmParadaPrincipal_Load_1;

            ((System.ComponentModel.ISupportInitialize)dgvParadas)
                .EndInit();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}