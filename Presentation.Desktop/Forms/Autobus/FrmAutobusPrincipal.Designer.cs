namespace SGA.Presentation.Desktop.Forms.Autobus
{
    partial class FrmAutobusPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;
        private DataGridView dgvAutobuses;

        private Button btnNuevoAutobus;
        private Button btnDetalle;
        private Button btnEditar;
        private Button btnEliminar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle encabezado = new DataGridViewCellStyle();
            DataGridViewCellStyle filas = new DataGridViewCellStyle();

            lblTitulo = new Label();
            dgvAutobuses = new DataGridView();

            btnNuevoAutobus = new Button();
            btnDetalle = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvAutobuses).BeginInit();

            SuspendLayout();

            //
            // Formulario
            //

            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1180, 720);
            Font = new Font("Segoe UI", 10F);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Autobuses";

            //
            // Titulo
            //

            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(40, 40, 40);
            lblTitulo.Location = new Point(30, 25);
            lblTitulo.Text = "GESTIÓN DE AUTOBUSES";

            //
            // DataGrid
            //

            dgvAutobuses.AllowUserToAddRows = false;
            dgvAutobuses.AllowUserToDeleteRows = false;
            dgvAutobuses.AllowUserToResizeRows = false;

            dgvAutobuses.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvAutobuses.BackgroundColor = Color.White;
            dgvAutobuses.BorderStyle = BorderStyle.None;

            encabezado.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            encabezado.BackColor =
                Color.FromArgb(33, 150, 243);

            encabezado.ForeColor = Color.White;

            encabezado.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            encabezado.WrapMode =
                DataGridViewTriState.True;

            dgvAutobuses.ColumnHeadersDefaultCellStyle =
                encabezado;

            dgvAutobuses.ColumnHeadersHeight = 42;

            filas.SelectionBackColor =
                Color.FromArgb(210, 230, 255);

            filas.SelectionForeColor = Color.Black;

            dgvAutobuses.DefaultCellStyle = filas;

            dgvAutobuses.EnableHeadersVisualStyles = false;

            dgvAutobuses.Location = new Point(30, 90);

            dgvAutobuses.MultiSelect = false;

            dgvAutobuses.Name = "dgvAutobuses";

            dgvAutobuses.ReadOnly = true;

            dgvAutobuses.RowHeadersVisible = false;

            dgvAutobuses.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvAutobuses.Size = new Size(1120, 500);

            //
            // Nuevo
            //

            btnNuevoAutobus.BackColor =
                Color.FromArgb(40, 167, 69);

            btnNuevoAutobus.FlatStyle = FlatStyle.Flat;

            btnNuevoAutobus.ForeColor = Color.White;

            btnNuevoAutobus.Location =
                new Point(30, 620);

            btnNuevoAutobus.Size =
                new Size(160, 45);

            btnNuevoAutobus.Text = "Nuevo";

            //
            // Detalle
            //

            btnDetalle.BackColor =
                Color.FromArgb(23, 162, 184);

            btnDetalle.FlatStyle = FlatStyle.Flat;

            btnDetalle.ForeColor = Color.White;

            btnDetalle.Location =
                new Point(210, 620);

            btnDetalle.Size =
                new Size(160, 45);

            btnDetalle.Text = "Detalle";

            //
            // Editar
            //

            btnEditar.BackColor =
                Color.FromArgb(255, 193, 7);

            btnEditar.FlatStyle = FlatStyle.Flat;

            btnEditar.ForeColor = Color.Black;

            btnEditar.Location =
                new Point(390, 620);

            btnEditar.Size =
                new Size(160, 45);

            btnEditar.Text = "Editar";

            //
            // Eliminar
            //

            btnEliminar.BackColor =
                Color.FromArgb(220, 53, 69);

            btnEliminar.FlatStyle = FlatStyle.Flat;

            btnEliminar.ForeColor = Color.White;

            btnEliminar.Location =
                new Point(570, 620);

            btnEliminar.Size =
                new Size(160, 45);

            btnEliminar.Text = "Eliminar";

            //
            // Controles
            //

            Controls.Add(lblTitulo);

            Controls.Add(dgvAutobuses);

            Controls.Add(btnNuevoAutobus);

            Controls.Add(btnDetalle);

            Controls.Add(btnEditar);

            Controls.Add(btnEliminar);

            ((System.ComponentModel.ISupportInitialize)dgvAutobuses).EndInit();

            ResumeLayout(false);

            PerformLayout();
        }
    }
}