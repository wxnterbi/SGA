namespace SGA.Desktop.Modulos.Viaje
{
    partial class FrmViajePrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtBuscarRuta = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.btnNuevoViaje = new System.Windows.Forms.Button();
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            this.btnIniciarViaje = new System.Windows.Forms.Button();
            this.btnCompletarViaje = new System.Windows.Forms.Button();
            this.btnCancelarViaje = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
            this.SuspendLayout();

            // 
            // cmbEstado (Filtro)
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(12, 15);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(130, 23);
            this.cmbEstado.TabIndex = 0;

            // 
            // txtBuscarRuta (Filtro)
            // 
            this.txtBuscarRuta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuscarRuta.Location = new System.Drawing.Point(148, 15);
            this.txtBuscarRuta.Name = "txtBuscarRuta";
            this.txtBuscarRuta.PlaceholderText = "Buscar por ruta...";
            this.txtBuscarRuta.Size = new System.Drawing.Size(140, 23);
            this.txtBuscarRuta.TabIndex = 1;

            // 
            // dtpFecha (Filtro)
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(294, 15);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(110, 23);
            this.dtpFecha.TabIndex = 2;

            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(410, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 25);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;

            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnLimpiarFiltros.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiarFiltros.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(490, 14);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(75, 25);
            this.btnLimpiarFiltros.TabIndex = 4;
            this.btnLimpiarFiltros.Text = "Limpiar";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;

            // 
            // btnNuevoViaje (+ Programar Viaje)
            // 
            this.btnNuevoViaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnNuevoViaje.FlatAppearance.BorderSize = 0;
            this.btnNuevoViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoViaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNuevoViaje.ForeColor = System.Drawing.Color.White;
            this.btnNuevoViaje.Location = new System.Drawing.Point(622, 11);
            this.btnNuevoViaje.Name = "btnNuevoViaje";
            this.btnNuevoViaje.Size = new System.Drawing.Size(150, 30);
            this.btnNuevoViaje.TabIndex = 5;
            this.btnNuevoViaje.Text = "+ Programar Viaje";
            this.btnNuevoViaje.UseVisualStyleBackColor = false;
            this.btnNuevoViaje.Click += new System.EventHandler(this.btnNuevoViaje_Click);

            // 
            // dgvViajes (Tabla)
            // 
            this.dgvViajes.AllowUserToAddRows = false;
            this.dgvViajes.AllowUserToDeleteRows = false;
            this.dgvViajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.Location = new System.Drawing.Point(12, 50);
            this.dgvViajes.MultiSelect = false;
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.ReadOnly = true;
            this.dgvViajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViajes.Size = new System.Drawing.Size(760, 350);
            this.dgvViajes.TabIndex = 6;

            // 
            // Botones de Acción (Pie de página)
            // 
            // btnIniciarViaje
            // 
            this.btnIniciarViaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnIniciarViaje.FlatAppearance.BorderSize = 0;
            this.btnIniciarViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarViaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIniciarViaje.ForeColor = System.Drawing.Color.White;
            this.btnIniciarViaje.Location = new System.Drawing.Point(12, 412);
            this.btnIniciarViaje.Name = "btnIniciarViaje";
            this.btnIniciarViaje.Size = new System.Drawing.Size(100, 32);
            this.btnIniciarViaje.TabIndex = 7;
            this.btnIniciarViaje.Text = "Iniciar Viaje";
            this.btnIniciarViaje.UseVisualStyleBackColor = false;
            this.btnIniciarViaje.Click += new System.EventHandler(this.btnIniciarViaje_Click);

            // 
            // btnCompletarViaje
            // 
            this.btnCompletarViaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnCompletarViaje.FlatAppearance.BorderSize = 0;
            this.btnCompletarViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompletarViaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCompletarViaje.ForeColor = System.Drawing.Color.White;
            this.btnCompletarViaje.Location = new System.Drawing.Point(120, 412);
            this.btnCompletarViaje.Name = "btnCompletarViaje";
            this.btnCompletarViaje.Size = new System.Drawing.Size(120, 32);
            this.btnCompletarViaje.TabIndex = 8;
            this.btnCompletarViaje.Text = "Completar Viaje";
            this.btnCompletarViaje.UseVisualStyleBackColor = false;
            this.btnCompletarViaje.Click += new System.EventHandler(this.btnCompletarViaje_Click);

            // 
            // btnCancelarViaje
            // 
            this.btnCancelarViaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancelarViaje.FlatAppearance.BorderSize = 0;
            this.btnCancelarViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarViaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarViaje.ForeColor = System.Drawing.Color.White;
            this.btnCancelarViaje.Location = new System.Drawing.Point(248, 412);
            this.btnCancelarViaje.Name = "btnCancelarViaje";
            this.btnCancelarViaje.Size = new System.Drawing.Size(110, 32);
            this.btnCancelarViaje.TabIndex = 9;
            this.btnCancelarViaje.Text = "Cancelar Viaje";
            this.btnCancelarViaje.UseVisualStyleBackColor = false;
            this.btnCancelarViaje.Click += new System.EventHandler(this.btnCancelarViaje_Click);

            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnRefrescar.FlatAppearance.BorderSize = 0;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefrescar.ForeColor = System.Drawing.Color.White;
            this.btnRefrescar.Location = new System.Drawing.Point(672, 412);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(100, 32);
            this.btnRefrescar.TabIndex = 10;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);

            // 
            // FrmViajePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);

            // AQUÍ AGREGAMOS TODOS LOS CONTROLES AL FORMULARIO
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnCancelarViaje);
            this.Controls.Add(this.btnCompletarViaje);
            this.Controls.Add(this.btnIniciarViaje);
            this.Controls.Add(this.dgvViajes);
            this.Controls.Add(this.btnNuevoViaje);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtBuscarRuta);
            this.Controls.Add(this.cmbEstado);

            this.Name = "FrmViajePrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Viajes - SGA ITLA";
            this.Load += new System.EventHandler(this.FrmViajePrincipal_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtBuscarRuta;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvViajes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Button btnNuevoViaje;
        private System.Windows.Forms.Button btnIniciarViaje;
        private System.Windows.Forms.Button btnCompletarViaje;
        private System.Windows.Forms.Button btnCancelarViaje;
        private System.Windows.Forms.Button btnRefrescar;
    }
}