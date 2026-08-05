namespace SGA.Presentation.Desktop.Forms.Viaje
{
    partial class FrmViajePrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private ComboBox cmbEstado;
        private TextBox txtBuscarRuta;
        private DateTimePicker dtpFecha;

        private Button btnBuscar;
        private Button btnLimpiar;

        private Button btnNuevoViaje;

        private DataGridView dgvViajes;

        private Button btnIniciar;
        private Button btnFinalizar;
        private Button btnCancelar;
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
            lblTitulo = new Label();

            cmbEstado = new ComboBox();
            txtBuscarRuta = new TextBox();
            dtpFecha = new DateTimePicker();

            btnBuscar = new Button();
            btnLimpiar = new Button();

            btnNuevoViaje = new Button();

            dgvViajes = new DataGridView();

            btnIniciar = new Button();
            btnFinalizar = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvViajes).BeginInit();

            SuspendLayout();

            //
            // FORM
            //

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 720);
            BackColor = Color.White;
            Font = new Font("Segoe UI", 10F);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Viajes";

            //
            // TITULO
            //

            lblTitulo.Text = "GESTIÓN DE VIAJES";
            lblTitulo.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(40, 40, 40);
            lblTitulo.Location = new Point(25, 20);
            lblTitulo.AutoSize = true;

            //
            // COMBO ESTADO
            //

            cmbEstado.Location = new Point(30, 85);
            cmbEstado.Size = new Size(160, 35);
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            //
            // BUSCAR RUTA
            //

            txtBuscarRuta.Location = new Point(210, 85);
            txtBuscarRuta.Size = new Size(260, 35);
            txtBuscarRuta.PlaceholderText = "Buscar ruta...";

            //
            // FECHA
            //

            dtpFecha.Location = new Point(490, 85);
            dtpFecha.Size = new Size(180, 35);

            //
            // BUSCAR
            //

            btnBuscar.Text = "Buscar";
            btnBuscar.Location = new Point(690, 82);
            btnBuscar.Size = new Size(95, 38);

            btnBuscar.BackColor = Color.FromArgb(0, 120, 215);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Flat;

            //
            // LIMPIAR
            //

            btnLimpiar.Text = "Limpiar";

            btnLimpiar.Location = new Point(800, 82);
            btnLimpiar.Size = new Size(95, 38);

            btnLimpiar.BackColor = Color.Gray;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.FlatStyle = FlatStyle.Flat;

            //
            // NUEVO VIAJE
            //

            btnNuevoViaje.Text = "+ Nuevo Viaje";

            btnNuevoViaje.Location = new Point(960, 80);

            btnNuevoViaje.Size = new Size(170, 42);

            btnNuevoViaje.BackColor = Color.FromArgb(40, 167, 69);

            btnNuevoViaje.ForeColor = Color.White;

            btnNuevoViaje.FlatStyle = FlatStyle.Flat;

            //
            // DATAGRID
            //

            dgvViajes.Location = new Point(30, 145);

            dgvViajes.Size = new Size(1100, 470);

            dgvViajes.AllowUserToAddRows = false;

            dgvViajes.AllowUserToDeleteRows = false;

            dgvViajes.AllowUserToResizeRows = false;

            dgvViajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvViajes.MultiSelect = false;

            dgvViajes.ReadOnly = true;

            dgvViajes.RowHeadersVisible = false;

            dgvViajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvViajes.BackgroundColor = Color.White;

            dgvViajes.BorderStyle = BorderStyle.None;

            dgvViajes.EnableHeadersVisualStyles = false;

            dgvViajes.ColumnHeadersHeight = 40;

            dgvViajes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);

            dgvViajes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvViajes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvViajes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 230, 255);

            dgvViajes.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvViajes.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            //
            // BOTONES
            //

            btnIniciar.Text = "Iniciar";
            btnIniciar.Location = new Point(30, 640);
            btnIniciar.Size = new Size(120, 42);

            btnIniciar.BackColor = Color.DeepSkyBlue;
            btnIniciar.ForeColor = Color.White;
            btnIniciar.FlatStyle = FlatStyle.Flat;

            btnFinalizar.Text = "Finalizar";
            btnFinalizar.Location = new Point(170, 640);
            btnFinalizar.Size = new Size(120, 42);

            btnFinalizar.BackColor = Color.Green;
            btnFinalizar.ForeColor = Color.White;
            btnFinalizar.FlatStyle = FlatStyle.Flat;

            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(310, 640);
            btnCancelar.Size = new Size(120, 42);

            btnCancelar.BackColor = Color.Goldenrod;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Flat;

            btnEliminar.Text = "Eliminar";
            btnEliminar.Location = new Point(450, 640);
            btnEliminar.Size = new Size(120, 42);

            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.FlatStyle = FlatStyle.Flat;

            btnActualizar.Text = "Actualizar";

            btnActualizar.Location = new Point(980, 640);

            btnActualizar.Size = new Size(150, 42);

            btnActualizar.BackColor = Color.Gray;

            btnActualizar.ForeColor = Color.White;

            btnActualizar.FlatStyle = FlatStyle.Flat;

            Controls.Add(lblTitulo);

            Controls.Add(cmbEstado);
            Controls.Add(txtBuscarRuta);
            Controls.Add(dtpFecha);

            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);

            Controls.Add(btnNuevoViaje);

            Controls.Add(dgvViajes);

            Controls.Add(btnIniciar);
            Controls.Add(btnFinalizar);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);

            ((System.ComponentModel.ISupportInitialize)dgvViajes).EndInit();

            ResumeLayout(false);

            PerformLayout();
        }
    }
}