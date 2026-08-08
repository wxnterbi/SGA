using SGA.Application.Dtos.Parada;
using SGA.Presentation.Desktop.Interfaces;

namespace SGA.Presentation.Desktop.Forms.Parada
{
    public partial class FrmNuevaParada : Form
    {
        private readonly IParadaApiService _paradaApiService;

        private readonly ParadaDto? _paradaEditar;

        private bool _guardando = false;


        public FrmNuevaParada(
            IParadaApiService paradaApiService,
            ParadaDto? parada = null)
        {
            InitializeComponent();

            _paradaApiService = paradaApiService;
            _paradaEditar = parada;

            Load += FrmNuevaParada_Load;

            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
        }


        private void FrmNuevaParada_Load(
            object sender,
            EventArgs e)
        {
            ConfigurarFormulario();

            if (_paradaEditar == null)
                return;


            txtNombre.Text =
                _paradaEditar.Nombre;

            txtUbicacion.Text =
                _paradaEditar.Ubicacion;

            nudOrden.Value =
                _paradaEditar.Orden;


            lblTitulo.Text =
                "EDITAR PARADA";

            btnGuardar.Text =
                "Actualizar";
        }


        private void ConfigurarFormulario()
        {
            txtNombre.MaxLength = 100;
            txtUbicacion.MaxLength = 200;


            nudOrden.Minimum = 1;


            nudOrden.Maximum = 9999;

            nudOrden.Value =
                Math.Max(
                    nudOrden.Minimum,
                    Math.Min(
                        nudOrden.Maximum,
                        nudOrden.Value));
        }


        private bool ValidarFormulario()
        {
            string nombre =
                txtNombre.Text.Trim();

            string ubicacion =
                txtUbicacion.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show(
                    "Debe escribir el nombre de la parada.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombre.Focus();

                return false;
            }


            if (nombre.Length < 2)
            {
                MessageBox.Show(
                    "El nombre de la parada debe tener al menos 2 caracteres.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombre.Focus();

                return false;
            }


            if (nombre.Length > 100)
            {
                MessageBox.Show(
                    "El nombre de la parada no puede superar los 100 caracteres.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombre.Focus();

                return false;
            }


            if (nombre.All(char.IsDigit))
            {
                MessageBox.Show(
                    "El nombre de la parada no puede estar compuesto solamente por números.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombre.Focus();

                return false;
            }


            if (!nombre.Any(char.IsLetter))
            {
                MessageBox.Show(
                    "El nombre de la parada debe contener al menos una letra.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombre.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(ubicacion))
            {
                MessageBox.Show(
                    "Debe escribir la ubicación de la parada.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUbicacion.Focus();

                return false;
            }


            if (ubicacion.Length < 3)
            {
                MessageBox.Show(
                    "La ubicación debe tener al menos 3 caracteres.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUbicacion.Focus();

                return false;
            }


            if (ubicacion.Length > 200)
            {
                MessageBox.Show(
                    "La ubicación no puede superar los 200 caracteres.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUbicacion.Focus();

                return false;
            }


            if (ubicacion.All(char.IsDigit))
            {
                MessageBox.Show(
                    "La ubicación no puede estar compuesta solamente por números.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUbicacion.Focus();

                return false;
            }


            if (!ubicacion.Any(char.IsLetter))
            {
                MessageBox.Show(
                    "La ubicación debe contener información descriptiva.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUbicacion.Focus();

                return false;
            }

            if (nudOrden.Value < 1)
            {
                MessageBox.Show(
                    "El orden de la parada debe ser mayor que cero.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                nudOrden.Focus();

                return false;
            }


            if (nudOrden.Value > 9999)
            {
                MessageBox.Show(
                    "El orden de la parada no puede superar 9999.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                nudOrden.Focus();

                return false;
            }


            return true;
        }


        private async void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            if (_guardando)
                return;


            if (!ValidarFormulario())
                return;


            try
            {
                _guardando = true;

                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;


                string nombre =
                    txtNombre.Text.Trim();

                string ubicacion =
                    txtUbicacion.Text.Trim();

                int orden =
                    (int)nudOrden.Value;


                bool resultado;


                // =========================
                // NUEVA PARADA
                // =========================

                if (_paradaEditar == null)
                {
                    var dto =
                        new CreateParadaDto
                        {
                            Nombre = nombre,
                            Ubicacion = ubicacion,
                            Orden = orden
                        };


                    resultado =
                        await _paradaApiService
                        .CreateAsync(dto);
                }


                else
                {
                    var dto =
                        new UpdateParadaDto
                        {
                            Id = _paradaEditar.Id,
                            Nombre = nombre,
                            Ubicacion = ubicacion,
                            Orden = orden
                        };


                    resultado =
                        await _paradaApiService
                        .UpdateAsync(dto);
                }


                if (resultado)
                {
                    MessageBox.Show(
                        _paradaEditar == null
                            ? "Parada registrada correctamente."
                            : "Parada actualizada correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


                    DialogResult =
                        DialogResult.OK;

                    Close();

                    return;
                }


                MessageBox.Show(
                    "No fue posible guardar la parada. Verifique la información e inténtelo nuevamente.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ObtenerMensajeError(ex),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                _guardando = false;

                if (!IsDisposed)
                {
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                }
            }
        }


        private string ObtenerMensajeError(
            Exception ex)
        {
            if (string.IsNullOrWhiteSpace(ex.Message))
            {
                return "Ocurrió un error al procesar la parada.";
            }


            return ex.Message;
        }


        private void btnCancelar_Click(
            object sender,
            EventArgs e)
        {
            DialogResult =
                DialogResult.Cancel;

            Close();
        }


        private void FrmNuevaParada_Load_1(
            object sender,
            EventArgs e)
        {
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
