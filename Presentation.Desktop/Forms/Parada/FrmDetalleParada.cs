using SGA.Application.Dtos.Parada;

namespace SGA.Presentation.Desktop.Forms.Parada
{
    public partial class FrmDetalleParada : Form
    {
        private readonly ParadaDto _parada;

        public FrmDetalleParada(ParadaDto parada)
        {
            InitializeComponent();

            _parada = parada;

            Load += FrmDetalleParada_Load;

            btnCerrar.Click += btnCerrar_Click;
        }

        private void FrmDetalleParada_Load(
            object sender,
            EventArgs e)
        {
            lblId.Text = _parada.Id.ToString();

            lblNombre.Text = _parada.Nombre;

            lblUbicacion.Text = _parada.Ubicacion;

            lblOrden.Text = _parada.Orden.ToString();
        }

        private void btnCerrar_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }

        private void FrmDetalleParada_Load_1(object sender, EventArgs e)
        {

        }
    }
}
