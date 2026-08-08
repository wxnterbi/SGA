namespace SGA.Presentation.Desktop.Forms.Autobus
{
    partial class FrmNuevoAutobus
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private Label lblPlaca;
        private Label lblMarca;
        private Label lblModelo;
        private Label lblCapacidad;
        private Label lblEstado;

        private TextBox txtPlaca;
        private TextBox txtMarca;
        private TextBox txtModelo;

        private NumericUpDown numCapacidad;

        private ComboBox cmbEstado;

        private Button btnGuardar;
        private Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();

            lblPlaca = new Label();
            lblMarca = new Label();
            lblModelo = new Label();
            lblCapacidad = new Label();
            lblEstado = new Label();

            txtPlaca = new TextBox();
            txtMarca = new TextBox();
            txtModelo = new TextBox();

            numCapacidad = new NumericUpDown();

            cmbEstado = new ComboBox();

            btnGuardar = new Button();
            btnCancelar = new Button();

            ((System.ComponentModel.ISupportInitialize)numCapacidad).BeginInit();

            SuspendLayout();

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;

            lblTitulo.Font =
                new Font(
                    "Segoe UI",
                    18F,
                    FontStyle.Bold);

            lblTitulo.ForeColor =
                Color.FromArgb(40, 40, 40);

            lblTitulo.Location =
                new Point(40, 25);

            lblTitulo.Name =
                "lblTitulo";

            lblTitulo.Size =
                new Size(270, 41);

            lblTitulo.TabIndex =
                0;

            lblTitulo.Text =
                "NUEVO AUTOBÚS";

            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;

            lblPlaca.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            lblPlaca.Location =
                new Point(40, 95);

            lblPlaca.Name =
                "lblPlaca";

            lblPlaca.Size =
                new Size(55, 23);

            lblPlaca.TabIndex =
                1;

            lblPlaca.Text =
                "Placa";

            // 
            // txtPlaca
            // 
            txtPlaca.Font =
                new Font(
                    "Segoe UI",
                    10F);

            txtPlaca.Location =
                new Point(40, 120);

            txtPlaca.Name =
                "txtPlaca";

            txtPlaca.Size =
                new Size(420, 30);

            txtPlaca.TabIndex =
                2;

            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;

            lblMarca.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            lblMarca.Location =
                new Point(40, 175);

            lblMarca.Name =
                "lblMarca";

            lblMarca.Size =
                new Size(59, 23);

            lblMarca.TabIndex =
                3;

            lblMarca.Text =
                "Marca";

            // 
            // txtMarca
            // 
            txtMarca.Font =
                new Font(
                    "Segoe UI",
                    10F);

            txtMarca.Location =
                new Point(40, 200);

            txtMarca.Name =
                "txtMarca";

            txtMarca.Size =
                new Size(420, 30);

            txtMarca.TabIndex =
                4;

            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;

            lblModelo.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            lblModelo.Location =
                new Point(40, 255);

            lblModelo.Name =
                "lblModelo";

            lblModelo.Size =
                new Size(70, 23);

            lblModelo.TabIndex =
                5;

            lblModelo.Text =
                "Modelo";

            // 
            // txtModelo
            // 
            txtModelo.Font =
                new Font(
                    "Segoe UI",
                    10F);

            txtModelo.Location =
                new Point(40, 280);

            txtModelo.Name =
                "txtModelo";

            txtModelo.Size =
                new Size(420, 30);

            txtModelo.TabIndex =
                6;

            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;

            lblCapacidad.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            lblCapacidad.Location =
                new Point(40, 335);

            lblCapacidad.Name =
                "lblCapacidad";

            lblCapacidad.Size =
                new Size(91, 23);

            lblCapacidad.TabIndex =
                7;

            lblCapacidad.Text =
                "Capacidad";

            // 
            // numCapacidad
            // 
            numCapacidad.Font =
                new Font(
                    "Segoe UI",
                    10F);

            numCapacidad.Location =
                new Point(40, 360);

            numCapacidad.Maximum =
                new decimal(
                    new int[]
                    {
                        200,
                        0,
                        0,
                        0
                    });

            numCapacidad.Minimum =
                new decimal(
                    new int[]
                    {
                        1,
                        0,
                        0,
                        0
                    });

            numCapacidad.Name =
                "numCapacidad";

            numCapacidad.Size =
                new Size(150, 30);

            numCapacidad.TabIndex =
                8;

            numCapacidad.Value =
                new decimal(
                    new int[]
                    {
                        1,
                        0,
                        0,
                        0
                    });

            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;

            lblEstado.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            lblEstado.Location =
                new Point(260, 335);

            lblEstado.Name =
                "lblEstado";

            lblEstado.Size =
                new Size(61, 23);

            lblEstado.TabIndex =
                9;

            lblEstado.Text =
                "Estado";

            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbEstado.Font =
                new Font(
                    "Segoe UI",
                    10F);

            cmbEstado.Location =
                new Point(260, 360);

            cmbEstado.Name =
                "cmbEstado";

            cmbEstado.Size =
                new Size(200, 31);

            cmbEstado.TabIndex =
                10;

            // 
            // btnGuardar
            // 
            btnGuardar.BackColor =
                Color.FromArgb(40, 167, 69);

            btnGuardar.FlatStyle =
                FlatStyle.Flat;

            btnGuardar.FlatAppearance.BorderSize =
                0;

            btnGuardar.ForeColor =
                Color.White;

            btnGuardar.Location =
                new Point(80, 440);

            btnGuardar.Name =
                "btnGuardar";

            btnGuardar.Size =
                new Size(150, 42);

            btnGuardar.TabIndex =
                11;

            btnGuardar.Text =
                "Guardar";

            btnGuardar.UseVisualStyleBackColor =
                false;

            // 
            // btnCancelar
            // 
            btnCancelar.BackColor =
                Color.Firebrick;

            btnCancelar.FlatStyle =
                FlatStyle.Flat;

            btnCancelar.FlatAppearance.BorderSize =
                0;

            btnCancelar.ForeColor =
                Color.White;

            btnCancelar.Location =
                new Point(270, 440);

            btnCancelar.Name =
                "btnCancelar";

            btnCancelar.Size =
                new Size(150, 42);

            btnCancelar.TabIndex =
                12;

            btnCancelar.Text =
                "Cancelar";

            btnCancelar.UseVisualStyleBackColor =
                false;

            // 
            // FrmNuevoAutobus
            // 
            AutoScaleDimensions =
                new SizeF(9F, 23F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.White;

            ClientSize =
                new Size(500, 530);

            Controls.Add(lblTitulo);

            Controls.Add(lblPlaca);
            Controls.Add(txtPlaca);

            Controls.Add(lblMarca);
            Controls.Add(txtMarca);

            Controls.Add(lblModelo);
            Controls.Add(txtModelo);

            Controls.Add(lblCapacidad);
            Controls.Add(numCapacidad);

            Controls.Add(lblEstado);
            Controls.Add(cmbEstado);

            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);

            Font =
                new Font(
                    "Segoe UI",
                    10F);

            FormBorderStyle =
                FormBorderStyle.FixedDialog;

            MaximizeBox =
                false;

            MinimizeBox =
                false;

            Name =
                "FrmNuevoAutobus";

            StartPosition =
                FormStartPosition.CenterParent;

            Text =
                "Autobús";

            ((System.ComponentModel.ISupportInitialize)numCapacidad).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}