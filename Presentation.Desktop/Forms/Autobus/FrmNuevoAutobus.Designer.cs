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
            components = new System.ComponentModel.Container();


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



            // FORMULARIO

            ClientSize = new Size(550, 500);

            Text = "Nuevo Autobús";

            StartPosition =
                FormStartPosition.CenterParent;

            BackColor = Color.White;



            // TITULO

            lblTitulo.Text =
                "Registrar Autobús";

            lblTitulo.Font =
                new Font(
                    "Segoe UI",
                    18,
                    FontStyle.Bold);

            lblTitulo.ForeColor =
                Color.FromArgb(25, 42, 86);

            lblTitulo.AutoSize = true;

            lblTitulo.Location =
                new Point(30, 25);



            // LABELS

            lblPlaca.Text = "Placa:";
            lblMarca.Text = "Marca:";
            lblModelo.Text = "Modelo:";
            lblCapacidad.Text = "Capacidad:";
            lblEstado.Text = "Estado:";


            Label[] labels =
            {
                lblPlaca,
                lblMarca,
                lblModelo,
                lblCapacidad,
                lblEstado
            };


            int y = 90;


            foreach (var label in labels)
            {
                label.AutoSize = true;

                label.Font =
                    new Font(
                        "Segoe UI",
                        10,
                        FontStyle.Bold);

                label.Location =
                    new Point(40, y);

                y += 55;
            }



            // TEXTBOX

            txtPlaca.Location =
                new Point(170, 85);

            txtPlaca.Width = 280;


            txtMarca.Location =
                new Point(170, 140);

            txtMarca.Width = 280;


            txtModelo.Location =
                new Point(170, 195);

            txtModelo.Width = 280;


            numCapacidad.Location =
                new Point(170, 250);

            numCapacidad.Width = 280;

            numCapacidad.Minimum = 1;

            numCapacidad.Maximum = 100;



            cmbEstado.Location =
                new Point(170, 305);

            cmbEstado.Width = 280;

            cmbEstado.DropDownStyle =
                ComboBoxStyle.DropDownList;



            // BOTON GUARDAR

            btnGuardar.Text =
                "Guardar";

            btnGuardar.Location =
                new Point(170, 380);

            btnGuardar.Size =
                new Size(120, 40);

            btnGuardar.BackColor =
                Color.FromArgb(40, 167, 69);

            btnGuardar.ForeColor =
                Color.White;

            btnGuardar.FlatStyle =
                FlatStyle.Flat;



            // BOTON CANCELAR

            btnCancelar.Text =
                "Cancelar";

            btnCancelar.Location =
                new Point(330, 380);

            btnCancelar.Size =
                new Size(120, 40);

            btnCancelar.BackColor =
                Color.FromArgb(220, 53, 69);

            btnCancelar.ForeColor =
                Color.White;

            btnCancelar.FlatStyle =
                FlatStyle.Flat;



            // CONTROLES

            Controls.Add(lblTitulo);

            Controls.Add(lblPlaca);
            Controls.Add(lblMarca);
            Controls.Add(lblModelo);
            Controls.Add(lblCapacidad);
            Controls.Add(lblEstado);


            Controls.Add(txtPlaca);
            Controls.Add(txtMarca);
            Controls.Add(txtModelo);
            Controls.Add(numCapacidad);
            Controls.Add(cmbEstado);


            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);



            ((System.ComponentModel.ISupportInitialize)numCapacidad).EndInit();

            ResumeLayout(false);

            PerformLayout();
        }
    }
}