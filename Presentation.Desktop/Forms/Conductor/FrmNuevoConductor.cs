using SGA.Application.Dtos.Conductor;
using SGA.Presentation.Desktop.Interfaces;
using SGA.Domain.Enums.Configuration;
using System.Text.RegularExpressions;

namespace SGA.Presentation.Desktop.Forms.Conductor
{
    public partial class FrmNuevoConductor : Form
    {
        private readonly IConductorApiService _conductorApiService;

        private int _idConductor = 0;

        public FrmNuevoConductor(
            IConductorApiService conductorApiService)
        {
            InitializeComponent();

            _conductorApiService = conductorApiService;

            Load += FrmNuevoConductor_Load;

            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;


            txtTelefono.KeyPress += txtTelefono_KeyPress;


            txtCedula.KeyPress += txtCedula_KeyPress;


            txtLicencia.KeyPress += txtLicencia_KeyPress;


            txtNombre.KeyPress += txtNombre_KeyPress;
        }

        private void FrmNuevoConductor_Load(
            object sender,
            EventArgs e)
        {
            CargarEstados();
        }

        private void CargarEstados()
        {
            cmbEstado.DataSource =
                Enum.GetValues(typeof(EstadoLaboral));

            cmbEstado.SelectedIndex = 0;
        }

        public async void CargarConductor(int id)
        {
            _idConductor = id;

            var conductor =
                await _conductorApiService
                    .GetByIdAsync(id);

            if (conductor == null)
            {
                MessageBox.Show(
                    "No se encontró el conductor.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            txtNombre.Text = conductor.Nombre;
            txtCedula.Text = conductor.Cedula;
            txtLicencia.Text = conductor.Licencia;
            txtTelefono.Text = conductor.Telefono;

            cmbEstado.SelectedItem =
                (EstadoLaboral)conductor.EstadoConductorId;

            btnGuardar.Text = "Actualizar";
        }



        private void txtNombre_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                e.KeyChar == '\b')
            {
                return;
            }

            e.Handled = true;
        }


        private void txtCedula_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) ||
                e.KeyChar == '\b' ||
                e.KeyChar == '-')
            {
                return;
            }

            e.Handled = true;
        }


        private void txtTelefono_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) ||
                e.KeyChar == '\b')
            {
                return;
            }

            e.Handled = true;
        }



        private void txtLicencia_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) ||
                e.KeyChar == '\b' ||
                e.KeyChar == '-')
            {
                return;
            }

            e.Handled = true;
        }


        private async void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                string nombre =
                    txtNombre.Text.Trim();

                string cedula =
                    txtCedula.Text.Trim();

                string licencia =
                    txtLicencia.Text.Trim();

                string telefono =
                    txtTelefono.Text.Trim();

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show(
                        "El nombre es obligatorio.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(cedula))
                {
                    MessageBox.Show(
                        "La cédula es obligatoria.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtCedula.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(licencia))
                {
                    MessageBox.Show(
                        "La licencia es obligatoria.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtLicencia.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(telefono))
                {
                    MessageBox.Show(
                        "El teléfono es obligatorio.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtTelefono.Focus();
                    return;
                }

                if (cmbEstado.SelectedItem == null)
                {
                    MessageBox.Show(
                        "Debe seleccionar un estado.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbEstado.Focus();
                    return;
                }


                if (!Regex.IsMatch(
                    nombre,
                    @"^[\p{L}\s]+$"))
                {
                    MessageBox.Show(
                        "El nombre solamente puede contener letras y espacios.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre.Focus();
                    return;
                }



                if (!Regex.IsMatch(
                    cedula,
                    @"^\d{3}-\d{7}-\d$"))
                {
                    MessageBox.Show(
                        "La cédula debe tener el formato 000-0000000-0.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtCedula.Focus();
                    return;
                }



                if (!Regex.IsMatch(
                    telefono,
                    @"^\d{10}$"))
                {
                    MessageBox.Show(
                        "El teléfono debe contener exactamente 10 números.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtTelefono.Focus();
                    return;
                }


                if (!Regex.IsMatch(
                    licencia,
                    @"^[A-Za-z0-9-]{5,20}$"))
                {
                    MessageBox.Show(
                        "La licencia debe contener entre 5 y 20 caracteres y solamente puede utilizar letras, números y guiones.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtLicencia.Focus();
                    return;
                }


                var conductor = new ConductorDto
                {
                    Id = _idConductor,

                    Nombre = nombre,

                    Cedula = cedula,

                    Licencia = licencia,

                    Telefono = telefono,

                    EstadoConductorId =
                        (int)cmbEstado.SelectedItem
                };

                bool resultado;


                if (_idConductor == 0)
                {
                    resultado =
                        await _conductorApiService
                            .CreateAsync(conductor);
                }


                else
                {
                    resultado =
                        await _conductorApiService
                            .UpdateAsync(conductor);
                }


                if (resultado)
                {
                    MessageBox.Show(
                        _idConductor == 0
                            ? "Conductor registrado correctamente."
                            : "Conductor actualizado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    DialogResult =
                        DialogResult.OK;

                    Close();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo guardar la información.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
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

        private void FrmNuevoConductor_Load_1(
            object sender,
            EventArgs e)
        {
        }

        private void FrmNuevoConductor_Load_2(object sender, EventArgs e)
        {

        }
    }
}
