using SGA.Application.Dtos.Horario;
using SGA.Presentation.Desktop.Helpers;

namespace SGA.Presentation.Desktop.Forms.Horario
{
    public partial class FrmDetalleHorario : Form
    {
        private readonly HorarioDto _horario;


        public FrmDetalleHorario(HorarioDto horario)
        {
            InitializeComponent();

            ButtonStyleHelper.AplicarEstilo(
               btnCerrar,
               Color.Gray);

            _horario = horario;

            Load += FrmDetalleHorario_Load;
        }



        private void FrmDetalleHorario_Load(
            object sender,
            EventArgs e)
        {
            lblId.Text =
                _horario.Id.ToString();


            lblDias.Text =
                _horario.DiasOperacion;


            lblHora.Text =
                _horario.HoraSalida
                .ToString(@"hh\:mm");


            lblRuta.Text =
                _horario.NombreRuta;
        }




        private void btnCerrar_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }

        private void FrmDetalleHorario_Load_1(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void FrmDetalleHorario_Load_2(object sender, EventArgs e)
        {

        }
    }
}
