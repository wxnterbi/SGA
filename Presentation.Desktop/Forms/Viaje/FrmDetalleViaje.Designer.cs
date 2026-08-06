namespace SGA.Presentation.Desktop.Forms.Viaje
{
    partial class FrmDetalleViaje
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;
        private Label lblRuta;
        private Label lblHorario;
        private Label lblAutobus;
        private Label lblConductor;
        private Label lblEstado;


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

            SuspendLayout();


            // Titulo

            lblTitulo.AutoSize = true;
            lblTitulo.Font =
                new Font("Segoe UI", 16, FontStyle.Bold);

            lblTitulo.Location =
                new Point(80, 30);

            lblTitulo.Text =
                "Detalle del Viaje";



            // Ruta

            lblRuta.AutoSize = true;

            lblRuta.Location =
                new Point(50, 100);

            lblRuta.Text =
                "Ruta:";



            // Horario

            lblHorario.AutoSize = true;

            lblHorario.Location =
                new Point(50, 150);

            lblHorario.Text =
                "Horario:";




            // Autobus

            lblAutobus.AutoSize = true;

            lblAutobus.Location =
                new Point(50, 200);

            lblAutobus.Text =
                "Autobús:";




            // Conductor

            lblConductor.AutoSize = true;

            lblConductor.Location =
                new Point(50, 250);

            lblConductor.Text =
                "Conductor:";





            // Estado

            lblEstado.AutoSize = true;

            lblEstado.Location =
                new Point(50, 300);

            lblEstado.Text =
                "Estado:";




            Controls.Add(lblTitulo);
            Controls.Add(lblRuta);
            Controls.Add(lblHorario);
            Controls.Add(lblAutobus);
            Controls.Add(lblConductor);
            Controls.Add(lblEstado);



            ClientSize =
                new Size(450, 380);


            StartPosition =
                FormStartPosition.CenterScreen;


            Text =
                "Detalles del Viaje";


            Load += FrmDetalleViaje_Load;


            ResumeLayout(false);
            PerformLayout();

        }
    }
}