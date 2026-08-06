using SGA.Application.Dtos.Incidencia;
using SGA.Domain.Enums.Reservation;

namespace SGA.Presentation.Desktop.Forms.Incidencia
{
    public partial class FrmDetalleIncidencia : Form
    {
        private readonly IncidenciaDto _incidencia;


        public FrmDetalleIncidencia(
            IncidenciaDto incidencia)
        {
            InitializeComponent();

            _incidencia = incidencia;


            Load += FrmDetalleIncidencia_Load;


            btnCerrar.Click += btnCerrar_Click;
        }



        private void FrmDetalleIncidencia_Load(
            object sender,
            EventArgs e)
        {
            lblId.Text =
                _incidencia.Id.ToString();


            lblViaje.Text =
                _incidencia.ViajeId.ToString();


            lblConductor.Text =
                _incidencia.ConductorId.ToString();



            lblTipo.Text =
                ((TipoIncidencia)_incidencia.Tipo)
                .ToString();



            lblDescripcion.Text =
                _incidencia.Descripcion;



            lblFecha.Text =
                _incidencia.FechaHora
                .ToString("dd/MM/yyyy HH:mm");
        }




        private void btnCerrar_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }

        private void FrmDetalleIncidencia_Load_1(object sender, EventArgs e)
        {

        }
    }
}
