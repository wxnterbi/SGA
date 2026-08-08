using SGA.Application.Dtos.Ruta;
using SGA.Presentation.Desktop.Interfaces;
using System.Text.RegularExpressions;

namespace SGA.Presentation.Desktop.Forms.Ruta
{
    public partial class FrmNuevaRuta : Form
    {
        private readonly IRutaApiService _rutaApiService;

        private readonly RutaDto? _rutaEditar;

        public FrmNuevaRuta(IRutaApiService rutaApiService)
        {
            InitializeComponent();

            _rutaApiService = rutaApiService;

            Load += FrmNuevaRuta_Load;

            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;

            txtNombre.KeyPress += txtNombre_KeyPress;
            txtOrigen.KeyPress += txtOrigen_KeyPress;
            txtDestino.KeyPress += txtDestino_KeyPress;
        }

        public FrmNuevaRuta(
            IRutaApiService rutaApiService,
            RutaDto ruta)
        {
            InitializeComponent();

            _rutaApiService = rutaApiService;
            _rutaEditar = ruta;

            Load += FrmNuevaRuta_Load;

            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;

            txtNombre.KeyPress += txtNombre_KeyPress;
            txtOrigen.KeyPress += txtOrigen_KeyPress;
            txtDestino.KeyPress += txtDestino_KeyPress;
        }

        private void FrmNuevaRuta_Load(object sender, EventArgs e)
        {
            if (_rutaEditar != null)
            {
                txtNombre.Text = _rutaEditar.Nombre;
                txtOrigen.Text = _rutaEditar.Origen;
                txtDestino.Text = _rutaEditar.Destino;

                lblTitulo.Text = "EDITAR RUTA";
            }
        }

        // =========================
        // 🔥 VALIDACIONES EN TIEMPO REAL
        // =========================

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                e.KeyChar == '\b')
                return;

            e.Handled = true;
        }

        private void txtOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                e.KeyChar == '\b')
                return;

            e.Handled = true;
        }

        private void txtDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                e.KeyChar == '\b')
                return;

            e.Handled = true;
        }

        // =========================
        // 🔥 NORMALIZAR TEXTO
        // =========================
        private string LimpiarTexto(string texto)
        {
            texto = texto.Trim();

            // quitar espacios dobles
            texto = Regex.Replace(texto, @"\s+", " ");

            // capitalizar
            texto = System.Globalization.CultureInfo
                .CurrentCulture.TextInfo
                .ToTitleCase(texto.ToLower());

            return texto;
        }

        // =========================
        // 🔥 VALIDACIÓN GENERAL
        // =========================
        private async Task<string?> ValidarFormulario(
            string nombre,
            string origen,
            string destino)
        {
            // VACÍOS
            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(origen) ||
                string.IsNullOrWhiteSpace(destino))
                return "Todos los campos son obligatorios.";

            // LONGITUD
            if (nombre.Length < 3 || nombre.Length > 100)
                return "El nombre debe tener entre 3 y 100 caracteres.";

            if (origen.Length < 3 || origen.Length > 100)
                return "El origen debe tener entre 3 y 100 caracteres.";

            if (destino.Length < 3 || destino.Length > 100)
                return "El destino debe tener entre 3 y 100 caracteres.";

            // FORMATO
            if (!Regex.IsMatch(nombre, @"^[A-Za-z0-9\s]+$"))
                return "El nombre solo permite letras y números.";

            if (!Regex.IsMatch(origen, @"^[\p{L}\s]+$"))
                return "El origen solo permite letras.";

            if (!Regex.IsMatch(destino, @"^[\p{L}\s]+$"))
                return "El destino solo permite letras.";

            // ORIGEN != DESTINO
            if (origen.Equals(destino,
                StringComparison.OrdinalIgnoreCase))
                return "Origen y destino no pueden ser iguales.";

            // 🔥 VALIDAR DUPLICADOS (CLAVE PRO)
            var rutas = await _rutaApiService.GetAllAsync();

            bool existe = rutas.Any(r =>
                r.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) &&
                r.Origen.Equals(origen, StringComparison.OrdinalIgnoreCase) &&
                r.Destino.Equals(destino, StringComparison.OrdinalIgnoreCase) &&
                (_rutaEditar == null || r.Id != _rutaEditar.Id));

            if (existe)
                return "Esta ruta ya existe.";

            return null;
        }

        // =========================
        // 🔥 GUARDAR
        // =========================
        private async void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                btnGuardar.Enabled = false;

                string nombre = LimpiarTexto(txtNombre.Text);
                string origen = LimpiarTexto(txtOrigen.Text);
                string destino = LimpiarTexto(txtDestino.Text);

                var error = await ValidarFormulario(
                    nombre, origen, destino);

                if (error != null)
                {
                    MessageBox.Show(
                        error,
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                var ruta = new RutaDto
                {
                    Nombre = nombre,
                    Origen = origen,
                    Destino = destino
                };

                bool resultado;

                if (_rutaEditar == null)
                {
                    resultado =
                        await _rutaApiService.CreateAsync(ruta);
                }
                else
                {
                    ruta.Id = _rutaEditar.Id;

                    resultado =
                        await _rutaApiService.UpdateAsync(ruta);
                }

                if (resultado)
                {
                    MessageBox.Show(
                        "Ruta guardada correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo guardar la ruta.",
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
            finally
            {
                btnGuardar.Enabled = true;
            }
        }

        private void btnCancelar_Click(
            object sender,
            EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}