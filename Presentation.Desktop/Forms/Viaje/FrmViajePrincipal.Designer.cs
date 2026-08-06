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
        private Button btnDetalles;

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
            btnDetalles = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvViajes).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(40, 40, 40);
            lblTitulo.Location = new Point(25, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(299, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE VIAJES";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Location = new Point(30, 85);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(160, 31);
            cmbEstado.TabIndex = 1;
            // 
            // txtBuscarRuta
            // 
            txtBuscarRuta.Location = new Point(210, 85);
            txtBuscarRuta.Name = "txtBuscarRuta";
            txtBuscarRuta.PlaceholderText = "Buscar ruta...";
            txtBuscarRuta.Size = new Size(260, 30);
            txtBuscarRuta.TabIndex = 2;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(490, 85);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(180, 30);
            dtpFecha.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 120, 215);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(690, 82);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(95, 38);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Gray;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(800, 82);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(95, 38);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnNuevoViaje
            // 
            btnNuevoViaje.BackColor = Color.FromArgb(40, 167, 69);
            btnNuevoViaje.FlatStyle = FlatStyle.Flat;
            btnNuevoViaje.ForeColor = Color.White;
            btnNuevoViaje.Location = new Point(960, 80);
            btnNuevoViaje.Name = "btnNuevoViaje";
            btnNuevoViaje.Size = new Size(170, 42);
            btnNuevoViaje.TabIndex = 6;
            btnNuevoViaje.Text = "+ Nuevo Viaje";
            btnNuevoViaje.UseVisualStyleBackColor = false;
            // 
            // dgvViajes
            // 
            dgvViajes.AllowUserToAddRows = false;
            dgvViajes.AllowUserToDeleteRows = false;
            dgvViajes.AllowUserToResizeRows = false;
            dgvViajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvViajes.BackgroundColor = Color.White;
            dgvViajes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvViajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvViajes.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(210, 230, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvViajes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvViajes.EnableHeadersVisualStyles = false;
            dgvViajes.Location = new Point(30, 145);
            dgvViajes.MultiSelect = false;
            dgvViajes.Name = "dgvViajes";
            dgvViajes.ReadOnly = true;
            dgvViajes.RowHeadersVisible = false;
            dgvViajes.RowHeadersWidth = 51;
            dgvViajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvViajes.Size = new Size(1100, 470);
            dgvViajes.TabIndex = 7;
            dgvViajes.CellContentClick += dgvViajes_CellContentClick;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.DeepSkyBlue;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(30, 640);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(120, 42);
            btnIniciar.TabIndex = 8;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.Green;
            btnFinalizar.FlatStyle = FlatStyle.Flat;
            btnFinalizar.ForeColor = Color.White;
            btnFinalizar.Location = new Point(170, 640);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(120, 42);
            btnFinalizar.TabIndex = 9;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Goldenrod;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(310, 640);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 42);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(450, 640);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 42);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Gray;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(980, 640);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(150, 42);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnDetalles
            // 
            btnDetalles.BackColor = Color.FromArgb(0, 120, 215);
            btnDetalles.FlatStyle = FlatStyle.Flat;
            btnDetalles.ForeColor = Color.White;
            btnDetalles.Location = new Point(810, 640);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(120, 42);
            btnDetalles.TabIndex = 13;
            btnDetalles.Text = "Detalles";
            btnDetalles.UseVisualStyleBackColor = false;
            // 
            // FrmViajePrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1180, 720);
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
            Controls.Add(btnDetalles);
            Font = new Font("Segoe UI", 10F);
            Name = "FrmViajePrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Viajes";
            Load += FrmViajePrincipal_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvViajes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}