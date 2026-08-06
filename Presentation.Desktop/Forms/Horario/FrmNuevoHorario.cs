using SGA.Application.Dtos.Horario;
using SGA.Presentation.Desktop.Interfaces;
using SGA.Presentation.Desktop.Helpers;

namespace SGA.Presentation.Desktop.Forms.Horario
{
    public partial class FrmNuevoHorario : Form
    {
        private readonly IHorarioApiService _horarioApiService;
        private readonly IRutaApiService _rutaApiService;


        private HorarioDto? _horarioEditar;


        public FrmNuevoHorario(
            IHorarioApiService horarioApiService,
            IRutaApiService rutaApiService)
        {
            InitializeComponent();

            ButtonStyleHelper.AplicarEstilo(
               btnGuardar,
               Color.FromArgb(40, 167, 69));


            ButtonStyleHelper.AplicarEstilo(
                btnCancelar,
                Color.Gray);

            _horarioApiService = horarioApiService;
            _rutaApiService = rutaApiService;


            Load += FrmNuevoHorario_Load;


            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
        }


        public FrmNuevoHorario(
            IHorarioApiService horarioApiService,
            IRutaApiService rutaApiService,
            HorarioDto horario)
        {
            InitializeComponent();


            _horarioApiService = horarioApiService;
            _rutaApiService = rutaApiService;


            _horarioEditar = horario;


            Load += FrmNuevoHorario_Load;


            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
        }



        private async void FrmNuevoHorario_Load(
            object sender,
            EventArgs e)
        {
            CargarDiasOperacion();


            await CargarRutas();



            if (_horarioEditar != null)
            {
                CargarDatosHorario();
            }
        }


        private void CargarDiasOperacion()
        {
            cmbDiasOperacion.Items.Clear();

            cmbDiasOperacion.Items.AddRange(new object[]
            {
        "Lunes",
        "Martes",
        "Miércoles",
        "Jueves",
        "Viernes",
        "Sábado",
        "Domingo",

        "Lunes a Viernes",
        "Lunes a Sábado",
        "Lunes a Domingo",

        "Martes a Sábado",
        "Miércoles a Domingo",

        "Fines de semana",

        "Todos los días"
            });

            cmbDiasOperacion.SelectedIndex = -1;
        }



        private async Task CargarRutas()
        {
            try
            {
                var rutas =
                    await _rutaApiService.GetAllAsync();



                cmbRuta.DataSource = rutas;


                cmbRuta.DisplayMember =
                    "Nombre";


                cmbRuta.ValueMember =
                    "Id";


                cmbRuta.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error cargando rutas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void CargarDatosHorario()
        {
            cmbDiasOperacion.Text =
                _horarioEditar!.DiasOperacion;



            dtpHoraSalida.Value =
                DateTime.Today
                .Add(_horarioEditar.HoraSalida);



            cmbRuta.SelectedValue =
                _horarioEditar.RutaId;



            btnGuardar.Text =
                "Actualizar";


            Text =
                "Actualizar Horario";
        }



        private async void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            try
            {

                if (cmbDiasOperacion.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione los días de operación.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }



                if (cmbRuta.SelectedValue == null)
                {
                    MessageBox.Show(
                        "Seleccione una ruta.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }





                var horario =
                    new HorarioDto
                    {
                        DiasOperacion =
                            cmbDiasOperacion.Text,


                        HoraSalida =
                            dtpHoraSalida
                            .Value.TimeOfDay,


                        RutaId =
                            Convert.ToInt32(
                                cmbRuta.SelectedValue)
                    };


                bool resultado;



                if (_horarioEditar == null)
                {
                    resultado =
                        await _horarioApiService
                        .CreateAsync(horario);
                }
                else
                {
                    horario.Id =
                        _horarioEditar.Id;


                    resultado =
                        await _horarioApiService
                        .UpdateAsync(horario);
                }


                if (resultado)
                {
                    MessageBox.Show(
                        "Horario guardado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);



                    DialogResult =
                        DialogResult.OK;


                    Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void btnCancelar_Click(
            object sender,
            EventArgs e)
        {
            DialogResult =
                DialogResult.Cancel;


            Close();
        }

        private void cmbDiasOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmNuevoHorario_Load_1(object sender, EventArgs e)
        {

        }

        private void FrmNuevoHorario_Load_2(object sender, EventArgs e)
        {

        }
    }
}