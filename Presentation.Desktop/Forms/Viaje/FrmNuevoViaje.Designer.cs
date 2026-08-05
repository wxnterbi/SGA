namespace SGA.Presentation.Desktop.Forms.Viaje
{
    partial class FrmNuevoViaje
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;
        private Label lblRuta;
        private Label lblHorario;
        private Label lblAutobus;
        private Label lblConductor;
        private Label lblEstado;

        private ComboBox cmbRuta;
        private ComboBox cmbHorario;
        private ComboBox cmbAutobus;
        private ComboBox cmbConductor;
        private ComboBox cmbEstado;

        private Button btnGuardar;
        private Button btnCancelar;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }



        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblRuta = new Label();
            lblHorario = new Label();
            lblAutobus = new Label();
            lblConductor = new Label();
            lblEstado = new Label();

            cmbRuta = new ComboBox();
            cmbHorario = new ComboBox();
            cmbAutobus = new ComboBox();
            cmbConductor = new ComboBox();
            cmbEstado = new ComboBox();

            btnGuardar = new Button();
            btnCancelar = new Button();


            SuspendLayout();



            // 
            // FrmNuevoViaje
            // 

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(500, 520);

            StartPosition = FormStartPosition.CenterScreen;

            Text = "Nuevo Viaje";

            FormBorderStyle = FormBorderStyle.FixedDialog;

            MaximizeBox = false;



            // 
            // lblTitulo
            //

            lblTitulo.AutoSize = true;

            lblTitulo.Font = new Font(
                "Segoe UI",
                16F,
                FontStyle.Bold);

            lblTitulo.Location = new Point(160, 30);

            lblTitulo.Text = "Registrar Viaje";



            // 
            // lblRuta
            //

            lblRuta.AutoSize = true;

            lblRuta.Location = new Point(70, 100);

            lblRuta.Text = "Ruta:";



            //
            // cmbRuta
            //

            cmbRuta.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbRuta.Location =
                new Point(170, 95);

            cmbRuta.Size =
                new Size(250, 23);



            //
            // lblHorario
            //

            lblHorario.AutoSize = true;

            lblHorario.Location =
                new Point(70, 150);

            lblHorario.Text =
                "Horario:";



            //
            // cmbHorario
            //

            cmbHorario.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbHorario.Location =
                new Point(170, 145);

            cmbHorario.Size =
                new Size(250, 23);



            //
            // lblAutobus
            //

            lblAutobus.AutoSize = true;

            lblAutobus.Location =
                new Point(70, 200);

            lblAutobus.Text =
                "Autobús:";



            //
            // cmbAutobus
            //

            cmbAutobus.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbAutobus.Location =
                new Point(170, 195);

            cmbAutobus.Size =
                new Size(250, 23);



            //
            // lblConductor
            //

            lblConductor.AutoSize = true;

            lblConductor.Location =
                new Point(70, 250);

            lblConductor.Text =
                "Conductor:";



            //
            // cmbConductor
            //

            cmbConductor.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbConductor.Location =
                new Point(170, 245);

            cmbConductor.Size =
                new Size(250, 23);



            //
            // lblEstado
            //

            lblEstado.AutoSize = true;

            lblEstado.Location =
                new Point(70, 300);

            lblEstado.Text =
                "Estado:";



            //
            // cmbEstado
            //

            cmbEstado.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbEstado.Location =
                new Point(170, 295);

            cmbEstado.Size =
                new Size(250, 23);



            //
            // btnGuardar
            //

            btnGuardar.Location =
                new Point(150, 380);

            btnGuardar.Size =
                new Size(90, 35);

            btnGuardar.Text =
                "Guardar";

            btnGuardar.UseVisualStyleBackColor =
                true;



            //
            // btnCancelar
            //

            btnCancelar.Location =
                new Point(260, 380);

            btnCancelar.Size =
                new Size(90, 35);

            btnCancelar.Text =
                "Cancelar";

            btnCancelar.UseVisualStyleBackColor =
                true;



            //
            // Agregar controles
            //

            Controls.Add(lblTitulo);

            Controls.Add(lblRuta);
            Controls.Add(cmbRuta);

            Controls.Add(lblHorario);
            Controls.Add(cmbHorario);

            Controls.Add(lblAutobus);
            Controls.Add(cmbAutobus);

            Controls.Add(lblConductor);
            Controls.Add(cmbConductor);

            Controls.Add(lblEstado);
            Controls.Add(cmbEstado);

            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);



            ResumeLayout(false);
            PerformLayout();
        }
    }
}