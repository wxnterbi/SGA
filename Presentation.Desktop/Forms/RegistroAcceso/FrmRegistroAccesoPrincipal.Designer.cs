namespace SGA.Presentation.Desktop.Forms.RegistroAcceso
{
    partial class FrmRegistroAccesoPrincipal
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblViaje;
        private System.Windows.Forms.ComboBox cmbViaje;
        private System.Windows.Forms.Label lblMatriculaTitulo;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button btnValidar;

        private System.Windows.Forms.GroupBox grpResultado;
        private System.Windows.Forms.Label lblMatriculaTexto;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNombreTexto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblResultado;

        private System.Windows.Forms.GroupBox grpRegistros;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Button btnDetalles;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados deben eliminarse.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

 
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblViaje = new Label();
            cmbViaje = new ComboBox();
            lblMatriculaTitulo = new Label();
            txtMatricula = new TextBox();
            btnValidar = new Button();
            grpResultado = new GroupBox();
            lblMatriculaTexto = new Label();
            lblMatricula = new Label();
            lblNombreTexto = new Label();
            lblNombre = new Label();
            lblEstado = new Label();
            lblResultado = new Label();
            grpRegistros = new GroupBox();
            dgvRegistros = new DataGridView();
            btnDetalles = new Button();
            grpResultado.SuspendLayout();
            grpRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            SuspendLayout();
            
            // lblTitulo
            
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.Location = new Point(34, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(498, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Control de Registro de Acceso";
            
            // lblViaje
            
            lblViaje.AutoSize = true;
            lblViaje.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblViaje.Location = new Point(40, 113);
            lblViaje.Name = "lblViaje";
            lblViaje.Size = new Size(54, 23);
            lblViaje.TabIndex = 1;
            lblViaje.Text = "Viaje:";
            
            // cmbViaje
            
            cmbViaje.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbViaje.Font = new Font("Segoe UI", 10F);
            cmbViaje.FormattingEnabled = true;
            cmbViaje.Location = new Point(40, 147);
            cmbViaje.Margin = new Padding(3, 4, 3, 4);
            cmbViaje.Name = "cmbViaje";
            cmbViaje.Size = new Size(491, 31);
            cmbViaje.TabIndex = 2;
            
            // lblMatriculaTitulo
            
            lblMatriculaTitulo.AutoSize = true;
            lblMatriculaTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMatriculaTitulo.Location = new Point(40, 207);
            lblMatriculaTitulo.Name = "lblMatriculaTitulo";
            lblMatriculaTitulo.Size = new Size(91, 23);
            lblMatriculaTitulo.TabIndex = 3;
            lblMatriculaTitulo.Text = "Matrícula:";
            
            // txtMatricula
            
            txtMatricula.Font = new Font("Segoe UI", 11F);
            txtMatricula.Location = new Point(40, 240);
            txtMatricula.Margin = new Padding(3, 4, 3, 4);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(342, 32);
            txtMatricula.TabIndex = 4;
            
            // btnValidar
            
            btnValidar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnValidar.Location = new Point(400, 237);
            btnValidar.Margin = new Padding(3, 4, 3, 4);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(131, 43);
            btnValidar.TabIndex = 5;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
          
            // grpResultado
            
            grpResultado.Controls.Add(lblMatriculaTexto);
            grpResultado.Controls.Add(lblMatricula);
            grpResultado.Controls.Add(lblNombreTexto);
            grpResultado.Controls.Add(lblNombre);
            grpResultado.Controls.Add(lblEstado);
            grpResultado.Controls.Add(lblResultado);
            grpResultado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpResultado.Location = new Point(40, 313);
            grpResultado.Margin = new Padding(3, 4, 3, 4);
            grpResultado.Name = "grpResultado";
            grpResultado.Padding = new Padding(3, 4, 3, 4);
            grpResultado.Size = new Size(491, 240);
            grpResultado.TabIndex = 6;
            grpResultado.TabStop = false;
            grpResultado.Text = "Resultado de Validación";
           
            // lblMatriculaTexto
           
            lblMatriculaTexto.AutoSize = true;
            lblMatriculaTexto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMatriculaTexto.Location = new Point(23, 47);
            lblMatriculaTexto.Name = "lblMatriculaTexto";
            lblMatriculaTexto.Size = new Size(79, 20);
            lblMatriculaTexto.TabIndex = 0;
            lblMatriculaTexto.Text = "Matrícula:";
            
            // lblMatricula
            
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Segoe UI", 9F);
            lblMatricula.Location = new Point(114, 47);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(0, 20);
            lblMatricula.TabIndex = 1;
            
            // lblNombreTexto
            
            lblNombreTexto.AutoSize = true;
            lblNombreTexto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombreTexto.Location = new Point(23, 87);
            lblNombreTexto.Name = "lblNombreTexto";
            lblNombreTexto.Size = new Size(71, 20);
            lblNombreTexto.TabIndex = 2;
            lblNombreTexto.Text = "Nombre:";
            
            // lblNombre
            
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F);
            lblNombre.Location = new Point(114, 87);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 20);
            lblNombre.TabIndex = 3;
            
            // lblEstado
            
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblEstado.Location = new Point(23, 127);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 30);
            lblEstado.TabIndex = 4;
            
            // lblResultado
            
            lblResultado.Font = new Font("Segoe UI", 9F);
            lblResultado.Location = new Point(23, 173);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(440, 47);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Ingrese una matrícula para validar el acceso.";
            
            // grpRegistros
            
            grpRegistros.Controls.Add(dgvRegistros);
            grpRegistros.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpRegistros.Location = new Point(571, 33);
            grpRegistros.Margin = new Padding(3, 4, 3, 4);
            grpRegistros.Name = "grpRegistros";
            grpRegistros.Padding = new Padding(3, 4, 3, 4);
            grpRegistros.Size = new Size(800, 520);
            grpRegistros.TabIndex = 7;
            grpRegistros.TabStop = false;
            grpRegistros.Text = "Registros de Acceso";
            
            // dgvRegistros
            
            dgvRegistros.AllowUserToAddRows = false;
            dgvRegistros.AllowUserToDeleteRows = false;
            dgvRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistros.BackgroundColor = SystemColors.Window;
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistros.Location = new Point(17, 40);
            dgvRegistros.Margin = new Padding(3, 4, 3, 4);
            dgvRegistros.MultiSelect = false;
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.ReadOnly = true;
            dgvRegistros.RowHeadersVisible = false;
            dgvRegistros.RowHeadersWidth = 51;
            dgvRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRegistros.Size = new Size(766, 453);
            dgvRegistros.TabIndex = 0;
            
            // btnDetalles
            
            btnDetalles.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDetalles.Location = new Point(571, 573);
            btnDetalles.Margin = new Padding(3, 4, 3, 4);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(149, 47);
            btnDetalles.TabIndex = 8;
            btnDetalles.Text = "Ver detalles";
            btnDetalles.UseVisualStyleBackColor = true;
            
            // FrmRegistroAccesoPrincipal
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 667);
            Controls.Add(btnDetalles);
            Controls.Add(grpRegistros);
            Controls.Add(grpResultado);
            Controls.Add(btnValidar);
            Controls.Add(txtMatricula);
            Controls.Add(lblMatriculaTitulo);
            Controls.Add(cmbViaje);
            Controls.Add(lblViaje);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmRegistroAccesoPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Acceso";
            Load += FrmRegistroAccesoPrincipal_Load_1;
            grpResultado.ResumeLayout(false);
            grpResultado.PerformLayout();
            grpRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}