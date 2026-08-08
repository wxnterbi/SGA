namespace SGA.Presentation.Desktop.Forms.Usuario
{
    partial class FrmDetalleUsuario
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Label lblIdentificadorTitulo;
        private Label lblNombreTitulo;
        private Label lblTipoUsuarioTitulo;
        private Label lblEstadoTitulo;

        private TextBox txtIdentificador;
        private TextBox txtNombre;
        private TextBox txtTipoUsuario;
        private TextBox txtEstado;

        private Button btnEditar;
        private Button btnCerrar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();

            lblIdentificadorTitulo = new Label();
            lblNombreTitulo = new Label();
            lblTipoUsuarioTitulo = new Label();
            lblEstadoTitulo = new Label();

            txtIdentificador = new TextBox();
            txtNombre = new TextBox();
            txtTipoUsuario = new TextBox();
            txtEstado = new TextBox();

            btnEditar = new Button();
            btnCerrar = new Button();

            SuspendLayout();

            // 
            // FrmDetalleUsuario
            // 
            AutoScaleDimensions =
                new SizeF(9F, 23F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.White;

            ClientSize =
                new Size(600, 430);

            FormBorderStyle =
                FormBorderStyle.FixedDialog;

            MaximizeBox =
                false;

            MinimizeBox =
                false;

            StartPosition =
                FormStartPosition.CenterParent;

            Text =
                "Detalle del Usuario";

            Font =
                new Font("Segoe UI", 10F);

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;

            lblTitulo.Font =
                new Font("Segoe UI", 18F, FontStyle.Bold);

            lblTitulo.ForeColor =
                Color.FromArgb(25, 42, 86);

            lblTitulo.Location =
                new Point(30, 20);

            lblTitulo.Name =
                "lblTitulo";

            lblTitulo.Text =
                "DETALLE DEL USUARIO";

            // 
            // Labels
            // 
            lblIdentificadorTitulo.AutoSize = true;
            lblIdentificadorTitulo.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);
            lblIdentificadorTitulo.Location =
                new Point(40, 90);
            lblIdentificadorTitulo.Text =
                "Identificador:";

            lblNombreTitulo.AutoSize = true;
            lblNombreTitulo.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNombreTitulo.Location =
                new Point(40, 145);
            lblNombreTitulo.Text =
                "Nombre:";

            lblTipoUsuarioTitulo.AutoSize = true;
            lblTipoUsuarioTitulo.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTipoUsuarioTitulo.Location =
                new Point(40, 200);
            lblTipoUsuarioTitulo.Text =
                "Tipo de usuario:";

            lblEstadoTitulo.AutoSize = true;
            lblEstadoTitulo.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);
            lblEstadoTitulo.Location =
                new Point(40, 255);
            lblEstadoTitulo.Text =
                "Estado:";

            // 
            // TextBoxes
            // 
            TextBox[] campos =
            {
                txtIdentificador,
                txtNombre,
                txtTipoUsuario,
                txtEstado
            };

            int y = 87;

            foreach (TextBox txt in campos)
            {
                txt.Location =
                    new Point(210, y);

                txt.Size =
                    new Size(320, 27);

                txt.ReadOnly = true;

                txt.BorderStyle =
                    BorderStyle.FixedSingle;

                y += 55;
            }

            txtIdentificador.Name =
                "txtIdentificador";

            txtNombre.Name =
                "txtNombre";

            txtTipoUsuario.Name =
                "txtTipoUsuario";

            txtEstado.Name =
                "txtEstado";

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
                new Point(150, 340);

            btnEditar.Size =
                new Size(120, 42);

            btnEditar.Name =
                "btnEditar";

            btnEditar.Text =
                "Editar";

            btnEditar.UseVisualStyleBackColor = false;

            // 
            // btnCerrar
            // 
            btnCerrar.BackColor =
                Color.Gray;

            btnCerrar.FlatStyle =
                FlatStyle.Flat;

            btnCerrar.FlatAppearance.BorderSize = 0;

            btnCerrar.ForeColor =
                Color.White;

            btnCerrar.Location =
                new Point(320, 340);

            btnCerrar.Size =
                new Size(120, 42);

            btnCerrar.Name =
                "btnCerrar";

            btnCerrar.Text =
                "Cerrar";

            btnCerrar.UseVisualStyleBackColor = false;

            // 
            // Controls
            // 
            Controls.Add(lblTitulo);

            Controls.Add(lblIdentificadorTitulo);
            Controls.Add(lblNombreTitulo);
            Controls.Add(lblTipoUsuarioTitulo);
            Controls.Add(lblEstadoTitulo);

            Controls.Add(txtIdentificador);
            Controls.Add(txtNombre);
            Controls.Add(txtTipoUsuario);
            Controls.Add(txtEstado);

            Controls.Add(btnEditar);
            Controls.Add(btnCerrar);

            Load +=
                FrmDetalleUsuario_Load;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}