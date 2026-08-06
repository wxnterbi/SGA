namespace SGA.Presentation.Desktop.Forms.Usuario
{
    partial class FrmUsuarioPrincipal
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
            lblTitulo = new Label();

            lblBuscarNombre = new Label();
            txtBuscarNombre = new TextBox();

            lblEstado = new Label();
            cmbEstado = new ComboBox();

            btnBuscar = new Button();
            btnLimpiar = new Button();

            dgvUsuarios = new DataGridView();

            btnNuevoUsuario = new Button();
            btnEditar = new Button();
            btnDetalles = new Button();
            btnEliminar = new Button();


            ((System.ComponentModel.ISupportInitialize)dgvUsuarios)
                .BeginInit();


            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font(
                "Segoe UI",
                16F,
                FontStyle.Bold);

            lblTitulo.Location = new Point(350, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(120, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Usuarios";


            //
            // lblBuscarNombre
            //
            lblBuscarNombre.AutoSize = true;
            lblBuscarNombre.Location = new Point(40, 80);
            lblBuscarNombre.Name = "lblBuscarNombre";
            lblBuscarNombre.Size = new Size(100, 15);
            lblBuscarNombre.TabIndex = 1;
            lblBuscarNombre.Text = "Buscar Nombre";


            //
            // txtBuscarNombre
            //
            txtBuscarNombre.Location =
                new Point(40, 100);

            txtBuscarNombre.Name =
                "txtBuscarNombre";

            txtBuscarNombre.Size =
                new Size(220, 23);

            txtBuscarNombre.TabIndex = 2;



            //
            // lblEstado
            //
            lblEstado.AutoSize = true;

            lblEstado.Location =
                new Point(300, 80);

            lblEstado.Name =
                "lblEstado";

            lblEstado.Size =
                new Size(45, 15);

            lblEstado.TabIndex = 3;

            lblEstado.Text =
                "Estado";



            //
            // cmbEstado
            //
            cmbEstado.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbEstado.FormattingEnabled =
                true;

            cmbEstado.Location =
                new Point(300, 100);

            cmbEstado.Name =
                "cmbEstado";

            cmbEstado.Size =
                new Size(180, 23);

            cmbEstado.TabIndex = 4;



            //
            // btnBuscar
            //
            btnBuscar.Location =
                new Point(520, 95);

            btnBuscar.Name =
                "btnBuscar";

            btnBuscar.Size =
                new Size(100, 35);

            btnBuscar.TabIndex = 5;

            btnBuscar.Text =
                "Buscar";

            btnBuscar.UseVisualStyleBackColor =
                true;



            //
            // btnLimpiar
            //
            btnLimpiar.Location =
                new Point(640, 95);

            btnLimpiar.Name =
                "btnLimpiar";

            btnLimpiar.Size =
                new Size(100, 35);

            btnLimpiar.TabIndex = 6;

            btnLimpiar.Text =
                "Limpiar";

            btnLimpiar.UseVisualStyleBackColor =
                true;

            //
            // dgvUsuarios
            //
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvUsuarios.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgvUsuarios.Location =
                new Point(40, 160);

            dgvUsuarios.Name =
                "dgvUsuarios";

            dgvUsuarios.ReadOnly = true;

            dgvUsuarios.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvUsuarios.MultiSelect = false;

            dgvUsuarios.Size =
                new Size(700, 280);

            dgvUsuarios.TabIndex = 7;



            //
            // btnNuevoUsuario
            //
            btnNuevoUsuario.Location =
                new Point(40, 470);

            btnNuevoUsuario.Name =
                "btnNuevoUsuario";

            btnNuevoUsuario.Size =
                new Size(120, 40);

            btnNuevoUsuario.TabIndex = 8;

            btnNuevoUsuario.Text =
                "Nuevo";

            btnNuevoUsuario.UseVisualStyleBackColor =
                true;



            //
            // btnEditar
            //
            btnEditar.Location =
                new Point(180, 470);

            btnEditar.Name =
                "btnEditar";

            btnEditar.Size =
                new Size(120, 40);

            btnEditar.TabIndex = 9;

            btnEditar.Text =
                "Editar";

            btnEditar.UseVisualStyleBackColor =
                true;



            //
            // btnDetalles
            //
            btnDetalles.Location =
                new Point(320, 470);

            btnDetalles.Name =
                "btnDetalles";

            btnDetalles.Size =
                new Size(120, 40);

            btnDetalles.TabIndex = 10;

            btnDetalles.Text =
                "Detalles";

            btnDetalles.UseVisualStyleBackColor =
                true;



            //
            // btnEliminar
            //
            btnEliminar.Location =
                new Point(460, 470);

            btnEliminar.Name =
                "btnEliminar";

            btnEliminar.Size =
                new Size(120, 40);

            btnEliminar.TabIndex = 11;

            btnEliminar.Text =
                "Eliminar";

            btnEliminar.UseVisualStyleBackColor =
                true;
            //
            // FrmUsuarioPrincipal
            //
            AutoScaleDimensions =
                new SizeF(7F, 15F);

            AutoScaleMode =
                AutoScaleMode.Font;

            ClientSize =
                new Size(800, 560);


            Controls.Add(lblTitulo);


            Controls.Add(lblBuscarNombre);
            Controls.Add(txtBuscarNombre);


            Controls.Add(lblEstado);
            Controls.Add(cmbEstado);


            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);


            Controls.Add(dgvUsuarios);


            Controls.Add(btnNuevoUsuario);
            Controls.Add(btnEditar);
            Controls.Add(btnDetalles);
            Controls.Add(btnEliminar);


            Name =
                "FrmUsuarioPrincipal";


            StartPosition =
                FormStartPosition.CenterScreen;


            Text =
                "Gestión de Usuarios";


            ((System.ComponentModel.ISupportInitialize)dgvUsuarios)
                .EndInit();


            ResumeLayout(false);

            PerformLayout();

        }


        #endregion



        private Label lblTitulo;


        private Label lblBuscarNombre;
        private TextBox txtBuscarNombre;


        private Label lblEstado;
        private ComboBox cmbEstado;


        private Button btnBuscar;
        private Button btnLimpiar;


        private DataGridView dgvUsuarios;


        private Button btnNuevoUsuario;
        private Button btnEditar;
        private Button btnDetalles;
        private Button btnEliminar;

    }
}