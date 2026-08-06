namespace SGA.Presentation.Desktop.Forms.Ruta
{
    partial class FrmRutaPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;
        private Button btnNuevaRuta;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnDetalles;
        private DataGridView dgvRutas;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }



        private void InitializeComponent()
        {
            lblTitulo = new Label();
            btnNuevaRuta = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnDetalles = new Button();
            dgvRutas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRutas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Location = new Point(25, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(297, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE RUTAS";
            // 
            // btnNuevaRuta
            // 
            btnNuevaRuta.BackColor = Color.FromArgb(40, 167, 69);
            btnNuevaRuta.FlatStyle = FlatStyle.Flat;
            btnNuevaRuta.ForeColor = Color.White;
            btnNuevaRuta.Location = new Point(850, 70);
            btnNuevaRuta.Name = "btnNuevaRuta";
            btnNuevaRuta.Size = new Size(160, 40);
            btnNuevaRuta.TabIndex = 1;
            btnNuevaRuta.Text = "+ Nueva Ruta";
            btnNuevaRuta.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Gray;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(880, 550);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(130, 40);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(25, 550);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 40);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnDetalles
            // 
            btnDetalles.BackColor = Color.FromArgb(33, 150, 243);
            btnDetalles.FlatStyle = FlatStyle.Flat;
            btnDetalles.ForeColor = Color.White;
            btnDetalles.Location = new Point(160, 550);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(110, 40);
            btnDetalles.TabIndex = 4;
            btnDetalles.Text = "Detalles";
            btnDetalles.UseVisualStyleBackColor = false;
            // 
            // dgvRutas
            // 
            dgvRutas.AllowUserToAddRows = false;
            dgvRutas.AllowUserToDeleteRows = false;
            dgvRutas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRutas.BackgroundColor = Color.White;
            dgvRutas.ColumnHeadersHeight = 29;
            dgvRutas.Location = new Point(25, 130);
            dgvRutas.Name = "dgvRutas";
            dgvRutas.ReadOnly = true;
            dgvRutas.RowHeadersVisible = false;
            dgvRutas.RowHeadersWidth = 51;
            dgvRutas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRutas.Size = new Size(985, 390);
            dgvRutas.TabIndex = 2;
            // 
            // FrmRutaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1045, 620);
            Controls.Add(lblTitulo);
            Controls.Add(btnNuevaRuta);
            Controls.Add(dgvRutas);
            Controls.Add(btnEliminar);
            Controls.Add(btnDetalles);
            Controls.Add(btnActualizar);
            Name = "FrmRutaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Rutas";
            Load += FrmRutaPrincipal_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvRutas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}