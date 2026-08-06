using SGA.Application.Dtos.Autobus;

namespace SGA.Presentation.Desktop.Forms.Autobus
{
    public partial class FrmDetalleAutobus : Form
    {
        private readonly AutobusDto _autobus;

        public FrmDetalleAutobus(AutobusDto autobus)
        {
            InitializeComponent();

            _autobus = autobus;

            Load += FrmDetalleAutobus_Load;
            btnCerrar.Click += BtnCerrar_Click;
        }

        private void FrmDetalleAutobus_Load(object? sender, EventArgs e)
        {
            lblTitulo.Text = "Detalle del Autobús";

            lblPlacaTitulo.Text = "Placa:";
            lblMarcaTitulo.Text = "Marca:";
            lblModeloTitulo.Text = "Modelo:";
            lblCapacidadTitulo.Text = "Capacidad:";
            lblEstadoTitulo.Text = "Estado:";

            lblPlaca.Text = _autobus.Placa;
            lblMarca.Text = _autobus.Marca;
            lblModelo.Text = _autobus.Modelo;
            lblCapacidad.Text = _autobus.Capacidad.ToString();
            lblEstado.Text = _autobus.EstadoDescripcion;

            btnCerrar.Text = "Cerrar";
        }

        private void BtnCerrar_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}