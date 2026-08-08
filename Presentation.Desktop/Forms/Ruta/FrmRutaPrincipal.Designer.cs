namespace SGA.Presentation.Desktop.Forms.Ruta
{
    partial class FrmRutaPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Button btnNuevaRuta;
        private Button btnDetalles;
        private Button btnEliminar;
        private Button btnActualizar;

        private DataGridView dgvRutas;

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

            btnNuevaRuta = new Button();
            btnDetalles = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();

            dgvRutas = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)dgvRutas).BeginInit();
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
                new Size(280, 41);

            lblTitulo.TabIndex = 0;

            lblTitulo.Text =
                "GESTIÓN DE RUTAS";

            // 
            // btnNuevaRuta
            // 
            btnNuevaRuta.BackColor =
                Color.FromArgb(40, 167, 69);

            btnNuevaRuta.Cursor =
                Cursors.Hand;

            btnNuevaRuta.FlatStyle =
                FlatStyle.Flat;

            btnNuevaRuta.FlatAppearance.BorderSize =
                0;

            btnNuevaRuta.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            btnNuevaRuta.ForeColor =
                Color.White;

            btnNuevaRuta.Location =
                new Point(960, 80);

            btnNuevaRuta.Name =
                "btnNuevaRuta";

            btnNuevaRuta.Size =
                new Size(170, 42);

            btnNuevaRuta.TabIndex = 1;

            btnNuevaRuta.Text =
                "+ Nueva Ruta";

            btnNuevaRuta.UseVisualStyleBackColor =
                false;

            // 
            // dgvRutas
            // 
            dgvRutas.AllowUserToAddRows =
                false;

            dgvRutas.AllowUserToDeleteRows =
                false;

            dgvRutas.AllowUserToResizeRows =
                false;

            dgvRutas.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvRutas.BackgroundColor =
                Color.White;

            dgvRutas.BorderStyle =
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
                Color.FromArgb(33, 150, 243);

            dataGridViewCellStyle1.SelectionForeColor =
                Color.White;

            dataGridViewCellStyle1.WrapMode =
                DataGridViewTriState.True;

            dgvRutas.ColumnHeadersDefaultCellStyle =
                dataGridViewCellStyle1;

            dgvRutas.ColumnHeadersHeight =
                40;

            dataGridViewCellStyle2.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            dataGridViewCellStyle2.BackColor =
                Color.White;

            dataGridViewCellStyle2.Font =
                new Font(
                    "Segoe UI",
                    10F);

            dataGridViewCellStyle2.ForeColor =
                Color.Black;

            dataGridViewCellStyle2.SelectionBackColor =
                Color.FromArgb(210, 230, 255);

            dataGridViewCellStyle2.SelectionForeColor =
                Color.Black;

            dataGridViewCellStyle2.WrapMode =
                DataGridViewTriState.False;

            dgvRutas.DefaultCellStyle =
                dataGridViewCellStyle2;

            dgvRutas.EnableHeadersVisualStyles =
                false;

            dgvRutas.Location =
                new Point(30, 145);

            dgvRutas.MultiSelect =
                false;

            dgvRutas.Name =
                "dgvRutas";

            dgvRutas.ReadOnly =
                true;

            dgvRutas.RowHeadersVisible =
                false;

            dgvRutas.RowHeadersWidth =
                51;

            dgvRutas.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvRutas.Size =
                new Size(1100, 470);

            dgvRutas.TabIndex = 2;

            dgvRutas.CellClick +=
                dgvRutas_CellClick;

            dgvRutas.CellContentClick +=
                dgvRutas_CellContentClick;

            // 
            // btnDetalles
            // 
            btnDetalles.BackColor =
                Color.FromArgb(0, 120, 215);

            btnDetalles.Cursor =
                Cursors.Hand;

            btnDetalles.FlatStyle =
                FlatStyle.Flat;

            btnDetalles.FlatAppearance.BorderSize =
                0;

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

            btnEliminar.FlatAppearance.BorderSize =
                0;

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

            btnActualizar.FlatAppearance.BorderSize =
                0;

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
            // FrmRutaPrincipal
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

            Controls.Add(btnNuevaRuta);

            Controls.Add(dgvRutas);

            Controls.Add(btnDetalles);

            Controls.Add(btnEliminar);

            Controls.Add(btnActualizar);

            Font =
                new Font(
                    "Segoe UI",
                    10F);

            Name =
                "FrmRutaPrincipal";

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "Gestión de Rutas";

            Load +=
                FrmRutaPrincipal_Load_1;

            ((System.ComponentModel.ISupportInitialize)dgvRutas).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }

        private void dgvRutas_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }
    }
}