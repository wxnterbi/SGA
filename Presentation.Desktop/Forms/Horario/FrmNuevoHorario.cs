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

            ButtonStyleHelper.AplicarEstilo(btnGuardar, Color.FromArgb(40, 167, 69));
            ButtonStyleHelper.AplicarEstilo(btnCancelar, Color.Gray);

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

        private async void FrmNuevoHorario_Load(object sender, EventArgs e)
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
                "Lunes","Martes","Miércoles","Jueves","Viernes","Sábado","Domingo",
                "Lunes a Viernes","Lunes a Sábado","Lunes a Domingo",
                "Fines de semana","Todos los días"
            });

            cmbDiasOperacion.SelectedIndex = -1;
        }

        private async Task CargarRutas()
        {
            try
            {
                var rutas = await _rutaApiService.GetAllAsync();

                cmbRuta.DataSource = rutas;
                cmbRuta.DisplayMember = "Nombre";
                cmbRuta.ValueMember = "Id";
                cmbRuta.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MostrarError("Error cargando rutas:\n" + ex.Message);
            }
        }

        private void CargarDatosHorario()
        {
            cmbDiasOperacion.Text = _horarioEditar!.DiasOperacion;

            dtpHoraSalida.Value = DateTime.Today.Add(_horarioEditar.HoraSalida);

            cmbRuta.SelectedValue = _horarioEditar.RutaId;

            btnGuardar.Text = "Actualizar";
            Text = "Actualizar Horario";
        }

        private async Task<bool> ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(cmbDiasOperacion.Text))
            {
                MostrarAdvertencia("Seleccione los días de operación.");
                return false;
            }

            if (cmbRuta.SelectedValue == null)
            {
                MostrarAdvertencia("Seleccione una ruta.");
                return false;
            }

            if (dtpHoraSalida.Value.TimeOfDay == TimeSpan.Zero)
            {
                MostrarAdvertencia("Seleccione una hora válida.");
                return false;
            }

            var horarios = await _horarioApiService.GetAllAsync();

            bool existe = horarios.Any(h =>
                h.RutaId == Convert.ToInt32(cmbRuta.SelectedValue) &&
                h.DiasOperacion == cmbDiasOperacion.Text &&
                h.HoraSalida == dtpHoraSalida.Value.TimeOfDay &&
                (_horarioEditar == null || h.Id != _horarioEditar.Id));

            if (existe)
            {
                MostrarAdvertencia("Ya existe un horario con esos datos.");
                return false;
            }

            return true;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!await ValidarFormulario())
                    return;

                var horario = new HorarioDto
                {
                    DiasOperacion = cmbDiasOperacion.Text,
                    HoraSalida = dtpHoraSalida.Value.TimeOfDay,
                    RutaId = Convert.ToInt32(cmbRuta.SelectedValue)
                };

                bool resultado;

                if (_horarioEditar == null)
                {
                    resultado = await _horarioApiService.CreateAsync(horario);
                }
                else
                {
                    horario.Id = _horarioEditar.Id;
                    resultado = await _horarioApiService.UpdateAsync(horario);
                }

                if (resultado)
                {
                    MostrarExito("Horario guardado correctamente.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MostrarError("No se pudo guardar el horario.");
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error:\n" + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void MostrarExito(string msg)
        {
            MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MostrarError(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MostrarAdvertencia(string msg)
        {
            MessageBox.Show(msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FrmNuevoHorario_Load_1(object sender, EventArgs e)
        {

        }
    }
}