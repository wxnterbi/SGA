using SGA.Application.Dtos.Ruta;

namespace SGA.Presentation.Desktop.Forms.Ruta
{
    public partial class FrmDetalleRuta : Form
    {
        private readonly RutaDto _ruta;


        public FrmDetalleRuta(RutaDto ruta)
        {
            InitializeComponent();

            _ruta = ruta;

            Load += FrmDetalleRuta_Load;
        }




        private void FrmDetalleRuta_Load(
            object sender,
            EventArgs e)
        {
            lblId.Text =
                _ruta.Id.ToString();


            lblNombre.Text =
                _ruta.Nombre;


            lblOrigen.Text =
                _ruta.Origen;


            lblDestino.Text =
                _ruta.Destino;
        }





        private void btnCerrar_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }

        private void lblDestino_Click(object sender, EventArgs e)
        {

        }

        private void FrmDetalleRuta_Load_1(object sender, EventArgs e)
        {

        }
    }
}
