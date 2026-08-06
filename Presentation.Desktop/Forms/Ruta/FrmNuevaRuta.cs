using SGA.Application.Dtos.Ruta;
using SGA.Presentation.Desktop.Interfaces;

namespace SGA.Presentation.Desktop.Forms.Ruta
{
    public partial class FrmNuevaRuta : Form
    {
        private readonly IRutaApiService _rutaApiService;

        private readonly RutaDto? _rutaEditar;


        public FrmNuevaRuta(
            IRutaApiService rutaApiService)
        {
            InitializeComponent();

            _rutaApiService = rutaApiService;

            Load += FrmNuevaRuta_Load;

            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
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
        }

        private void FrmNuevaRuta_Load(
            object sender,
            EventArgs e)
        {
            if (_rutaEditar != null)
            {
                txtNombre.Text =
                    _rutaEditar.Nombre;

                txtOrigen.Text =
                    _rutaEditar.Origen;

                txtDestino.Text =
                    _rutaEditar.Destino;


                lblTitulo.Text =
                    "EDITAR RUTA";
            }
        }

        private async void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                   string.IsNullOrWhiteSpace(txtOrigen.Text) ||
                   string.IsNullOrWhiteSpace(txtDestino.Text))
                {
                    MessageBox.Show(
                        "Complete todos los campos.");

                    return;
                }



                var ruta = new RutaDto
                {
                    Nombre = txtNombre.Text,
                    Origen = txtOrigen.Text,
                    Destino = txtDestino.Text
                };



                bool resultado;



                if (_rutaEditar == null)
                {
                    resultado =
                        await _rutaApiService
                        .CreateAsync(ruta);
                }
                else
                {
                    ruta.Id =
                        _rutaEditar.Id;


                    resultado =
                        await _rutaApiService
                        .UpdateAsync(ruta);
                }



                if (resultado)
                {
                    MessageBox.Show(
                        "Ruta guardada correctamente.");


                    DialogResult =
                        DialogResult.OK;

                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error");
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

        private void FrmNuevaRuta_Load_1(object sender, EventArgs e)
        {

        }
    }
}
