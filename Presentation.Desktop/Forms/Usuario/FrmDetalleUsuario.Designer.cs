namespace SGA.Presentation.Desktop.Forms.Usuario
{
    partial class FrmDetalleUsuario
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
            lblIdentificador = new Label();
            txtIdentificador = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblTipoUsuario = new Label();
            txtTipoUsuario = new TextBox();
            lblEstado = new Label();
            txtEstado = new TextBox();
            btnEditar = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(120, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(171, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Detalle Usuario";
            // 
            // lblIdentificador
            // 
            lblIdentificador.AutoSize = true;
            lblIdentificador.Location = new Point(40, 80);
            lblIdentificador.Name = "lblIdentificador";
            lblIdentificador.Size = new Size(77, 15);
            lblIdentificador.TabIndex = 1;
            lblIdentificador.Text = "Identificador:";
            // 
            // txtIdentificador
            // 
            txtIdentificador.Location = new Point(40, 100);
            txtIdentificador.Name = "txtIdentificador";
            txtIdentificador.ReadOnly = true;
            txtIdentificador.Size = new Size(250, 23);
            txtIdentificador.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(40, 140);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(40, 160);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(250, 23);
            txtNombre.TabIndex = 4;
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Location = new Point(40, 200);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(76, 15);
            lblTipoUsuario.TabIndex = 5;
            lblTipoUsuario.Text = "Tipo Usuario:";
            // 
            // txtTipoUsuario
            // 
            txtTipoUsuario.Location = new Point(40, 220);
            txtTipoUsuario.Name = "txtTipoUsuario";
            txtTipoUsuario.ReadOnly = true;
            txtTipoUsuario.Size = new Size(250, 23);
            txtTipoUsuario.TabIndex = 6;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(40, 260);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "Estado:";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(40, 280);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(250, 23);
            txtEstado.TabIndex = 8;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(40, 350);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 35);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(180, 350);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 35);
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmDetalleUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 456);
            Controls.Add(lblTitulo);
            Controls.Add(lblIdentificador);
            Controls.Add(txtIdentificador);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblTipoUsuario);
            Controls.Add(txtTipoUsuario);
            Controls.Add(lblEstado);
            Controls.Add(txtEstado);
            Controls.Add(btnEditar);
            Controls.Add(btnCerrar);
            Name = "FrmDetalleUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle Usuario";
            ResumeLayout(false);
            PerformLayout();

        }


        #endregion



        private Label lblTitulo;


        private Label lblIdentificador;
        private TextBox txtIdentificador;


        private Label lblNombre;
        private TextBox txtNombre;


        private Label lblTipoUsuario;
        private TextBox txtTipoUsuario;


        private Label lblEstado;
        private TextBox txtEstado;


        private Button btnEditar;
        private Button btnCerrar;

    }
}