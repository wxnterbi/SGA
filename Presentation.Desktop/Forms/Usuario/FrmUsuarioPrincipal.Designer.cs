namespace SGA.Presentation.Desktop.Forms.Usuario
{
    partial class FrmUsuarioPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private ComboBox cmbEstado;
        private TextBox txtBuscarNombre;

        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnNuevoUsuario;

        private DataGridView dgvUsuarios;

        private Button btnEditar;
        private Button btnDetalles;
        private Button btnEliminar;

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

            cmbEstado = new ComboBox();
            txtBuscarNombre = new TextBox();

            btnBuscar = new Button();
            btnLimpiar = new Button();
            btnNuevoUsuario = new Button();

            dgvUsuarios = new DataGridView();

            btnEditar = new Button();
            btnDetalles = new Button();
            btnEliminar = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();

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
                new Size(310, 41);

            lblTitulo.TabIndex = 0;

            lblTitulo.Text =
                "GESTIÓN DE USUARIOS";

            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbEstado.Location =
                new Point(30, 85);

            cmbEstado.Name =
                "cmbEstado";

            cmbEstado.Size =
                new Size(160, 31);

            cmbEstado.TabIndex = 1;

            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Location =
                new Point(210, 85);

            txtBuscarNombre.Name =
                "txtBuscarNombre";

            txtBuscarNombre.PlaceholderText =
                "Buscar nombre...";

            txtBuscarNombre.Size =
                new Size(300, 30);

            txtBuscarNombre.TabIndex = 2;

            // 
            // btnBuscar
            // 
            btnBuscar.BackColor =
                Color.FromArgb(0, 120, 215);

            btnBuscar.FlatStyle =
                FlatStyle.Flat;

            btnBuscar.FlatAppearance.BorderSize = 0;

            btnBuscar.ForeColor =
                Color.White;

            btnBuscar.Location =
                new Point(530, 82);

            btnBuscar.Name =
                "btnBuscar";

            btnBuscar.Size =
                new Size(95, 38);

            btnBuscar.TabIndex = 3;

            btnBuscar.Text =
                "Buscar";

            btnBuscar.UseVisualStyleBackColor = false;

            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor =
                Color.Gray;

            btnLimpiar.FlatStyle =
                FlatStyle.Flat;

            btnLimpiar.FlatAppearance.BorderSize = 0;

            btnLimpiar.ForeColor =
                Color.White;

            btnLimpiar.Location =
                new Point(640, 82);

            btnLimpiar.Name =
                "btnLimpiar";

            btnLimpiar.Size =
                new Size(95, 38);

            btnLimpiar.TabIndex = 4;

            btnLimpiar.Text =
                "Limpiar";

            btnLimpiar.UseVisualStyleBackColor = false;

            // 
            // btnNuevoUsuario
            // 
            btnNuevoUsuario.BackColor =
                Color.FromArgb(40, 167, 69);

            btnNuevoUsuario.FlatStyle =
                FlatStyle.Flat;

            btnNuevoUsuario.FlatAppearance.BorderSize = 0;

            btnNuevoUsuario.ForeColor =
                Color.White;

            btnNuevoUsuario.Location =
                new Point(960, 80);

            btnNuevoUsuario.Name =
                "btnNuevoUsuario";

            btnNuevoUsuario.Size =
                new Size(170, 42);

            btnNuevoUsuario.TabIndex = 5;

            btnNuevoUsuario.Text =
                "+ Nuevo Usuario";

            btnNuevoUsuario.UseVisualStyleBackColor = false;

            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;

            dgvUsuarios.AllowUserToDeleteRows = false;

            dgvUsuarios.AllowUserToResizeRows = false;

            dgvUsuarios.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvUsuarios.BackgroundColor =
                Color.White;

            dgvUsuarios.BorderStyle =
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

            dgvUsuarios.ColumnHeadersDefaultCellStyle =
                dataGridViewCellStyle1;

            dgvUsuarios.ColumnHeadersHeight =
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

            dgvUsuarios.DefaultCellStyle =
                dataGridViewCellStyle2;

            dgvUsuarios.EnableHeadersVisualStyles =
                false;

            dgvUsuarios.Location =
                new Point(30, 145);

            dgvUsuarios.MultiSelect =
                false;

            dgvUsuarios.Name =
                "dgvUsuarios";

            dgvUsuarios.ReadOnly =
                true;

            dgvUsuarios.RowHeadersVisible =
                false;

            dgvUsuarios.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvUsuarios.Size =
                new Size(1100, 470);

            dgvUsuarios.TabIndex = 6;

            dgvUsuarios.CellClick +=
                dgvUsuarios_CellClick;

            // 
            // btnEditar
            // 
            btnEditar.BackColor =
                Color.FromArgb(0, 120, 215);

            btnEditar.FlatStyle =
                FlatStyle.Flat;

            btnEditar.FlatAppearance.BorderSize = 0;

            btnEditar.ForeColor =
                Color.White;

            btnEditar.Location =
                new Point(30, 640);

            btnEditar.Name =
                "btnEditar";

            btnEditar.Size =
                new Size(120, 42);

            btnEditar.TabIndex = 7;

            btnEditar.Text =
                "Editar";

            btnEditar.UseVisualStyleBackColor = false;

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
                new Point(170, 640);

            btnEliminar.Name =
                "btnEliminar";

            btnEliminar.Size =
                new Size(120, 42);

            btnEliminar.TabIndex = 8;

            btnEliminar.Text =
                "Eliminar";

            btnEliminar.UseVisualStyleBackColor = false;

            // 
            // btnDetalles
            // 
            btnDetalles.BackColor =
                Color.FromArgb(0, 120, 215);

            btnDetalles.FlatStyle =
                FlatStyle.Flat;

            btnDetalles.FlatAppearance.BorderSize = 0;

            btnDetalles.ForeColor =
                Color.White;

            btnDetalles.Location =
                new Point(810, 640);

            btnDetalles.Name =
                "btnDetalles";

            btnDetalles.Size =
                new Size(120, 42);

            btnDetalles.TabIndex = 9;

            btnDetalles.Text =
                "Detalles";

            btnDetalles.UseVisualStyleBackColor = false;

            // 
            // FrmUsuarioPrincipal
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

            Controls.Add(cmbEstado);
            Controls.Add(txtBuscarNombre);

            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnNuevoUsuario);

            Controls.Add(dgvUsuarios);

            Controls.Add(btnEditar);
            Controls.Add(btnDetalles);
            Controls.Add(btnEliminar);

            Font =
                new Font("Segoe UI", 10F);

            Name =
                "FrmUsuarioPrincipal";

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "Gestión de Usuarios";

            Load +=
                FrmUsuarioPrincipal_Load_1;

            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}