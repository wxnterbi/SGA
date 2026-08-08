namespace SGA.Presentation.Desktop.Forms.Incidencia
{
    partial class FrmIncidenciaPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private DataGridView dgvIncidencias;

        private Button btnNuevaIncidencia;
        private Button btnDetalles;
        private Button btnActualizar;
        private Button btnEliminar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();

            lblTitulo = new Label();

            dgvIncidencias = new DataGridView();

            btnNuevaIncidencia = new Button();
            btnDetalles = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvIncidencias).BeginInit();
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
                new Size(330, 41);

            lblTitulo.TabIndex = 0;

            lblTitulo.Text =
                "GESTIÓN DE INCIDENCIAS";

            // 
            // dgvIncidencias
            // 
            dgvIncidencias.AllowUserToAddRows = false;
            dgvIncidencias.AllowUserToDeleteRows = false;
            dgvIncidencias.AllowUserToResizeRows = false;

            dgvIncidencias.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvIncidencias.BackgroundColor =
                Color.White;

            dgvIncidencias.BorderStyle =
                BorderStyle.None;

            headerStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            headerStyle.BackColor =
                Color.FromArgb(33, 150, 243);

            headerStyle.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            headerStyle.ForeColor =
                Color.White;

            headerStyle.SelectionBackColor =
                Color.FromArgb(33, 150, 243);

            headerStyle.SelectionForeColor =
                Color.White;

            headerStyle.WrapMode =
                DataGridViewTriState.True;

            dgvIncidencias.ColumnHeadersDefaultCellStyle =
                headerStyle;

            dgvIncidencias.ColumnHeadersHeight =
                40;

            cellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            cellStyle.BackColor =
                SystemColors.Window;

            cellStyle.Font =
                new Font("Segoe UI", 10F);

            cellStyle.ForeColor =
                SystemColors.ControlText;

            cellStyle.SelectionBackColor =
                Color.FromArgb(210, 230, 255);

            cellStyle.SelectionForeColor =
                Color.Black;

            cellStyle.WrapMode =
                DataGridViewTriState.False;

            dgvIncidencias.DefaultCellStyle =
                cellStyle;

            dgvIncidencias.EnableHeadersVisualStyles =
                false;

            dgvIncidencias.Location =
                new Point(30, 85);

            dgvIncidencias.MultiSelect =
                false;

            dgvIncidencias.Name =
                "dgvIncidencias";

            dgvIncidencias.ReadOnly =
                true;

            dgvIncidencias.RowHeadersVisible =
                false;

            dgvIncidencias.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvIncidencias.Size =
                new Size(1100, 520);

            dgvIncidencias.TabIndex =
                1;

            dgvIncidencias.CellContentClick +=
                dgvIncidencias_CellContentClick;

            // 
            // btnNuevaIncidencia
            // 
            btnNuevaIncidencia.BackColor =
                Color.FromArgb(40, 167, 69);

            btnNuevaIncidencia.FlatStyle =
                FlatStyle.Flat;

            btnNuevaIncidencia.FlatAppearance.BorderSize =
                0;

            btnNuevaIncidencia.ForeColor =
                Color.White;

            btnNuevaIncidencia.Location =
                new Point(960, 20);

            btnNuevaIncidencia.Name =
                "btnNuevaIncidencia";

            btnNuevaIncidencia.Size =
                new Size(170, 42);

            btnNuevaIncidencia.TabIndex =
                2;

            btnNuevaIncidencia.Text =
                "+ Nueva Incidencia";

            btnNuevaIncidencia.UseVisualStyleBackColor =
                false;

            // 
            // btnDetalles
            // 
            btnDetalles.BackColor =
                Color.FromArgb(33, 150, 243);

            btnDetalles.FlatStyle =
                FlatStyle.Flat;

            btnDetalles.FlatAppearance.BorderSize =
                0;

            btnDetalles.ForeColor =
                Color.White;

            btnDetalles.Location =
                new Point(650, 630);

            btnDetalles.Name =
                "btnDetalles";

            btnDetalles.Size =
                new Size(120, 42);

            btnDetalles.TabIndex =
                3;

            btnDetalles.Text =
                "Detalles";

            btnDetalles.UseVisualStyleBackColor =
                false;

            // 
            // btnActualizar
            // 
            btnActualizar.BackColor =
                Color.Gray;

            btnActualizar.FlatStyle =
                FlatStyle.Flat;

            btnActualizar.FlatAppearance.BorderSize =
                0;

            btnActualizar.ForeColor =
                Color.White;

            btnActualizar.Location =
                new Point(790, 630);

            btnActualizar.Name =
                "btnActualizar";

            btnActualizar.Size =
                new Size(120, 42);

            btnActualizar.TabIndex =
                4;

            btnActualizar.Text =
                "Actualizar";

            btnActualizar.UseVisualStyleBackColor =
                false;

            // 
            // btnEliminar
            // 
            btnEliminar.BackColor =
                Color.Firebrick;

            btnEliminar.FlatStyle =
                FlatStyle.Flat;

            btnEliminar.FlatAppearance.BorderSize =
                0;

            btnEliminar.ForeColor =
                Color.White;

            btnEliminar.Location =
                new Point(930, 630);

            btnEliminar.Name =
                "btnEliminar";

            btnEliminar.Size =
                new Size(120, 42);

            btnEliminar.TabIndex =
                5;

            btnEliminar.Text =
                "Eliminar";

            btnEliminar.UseVisualStyleBackColor =
                false;

            // 
            // FrmIncidenciaPrincipal
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

            Controls.Add(btnNuevaIncidencia);

            Controls.Add(dgvIncidencias);

            Controls.Add(btnDetalles);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);

            Font =
                new Font("Segoe UI", 10F);

            Name =
                "FrmIncidenciaPrincipal";

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "Gestión de Incidencias";

            Load +=
                FrmIncidenciaPrincipal_Load;

            ((System.ComponentModel.ISupportInitialize)dgvIncidencias).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}