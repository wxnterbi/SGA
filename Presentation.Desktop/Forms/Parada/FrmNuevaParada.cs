using SGA.Application.Dtos.Parada;
using SGA.Presentation.Desktop.Interfaces;

namespace SGA.Presentation.Desktop.Forms.Parada
{
    public partial class FrmNuevaParada : Form
    {
        private readonly IParadaApiService _paradaApiService;

        private readonly ParadaDto? _paradaEditar;


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
            if (_paradaEditar == null)
                return;

            txtNombre.Text = _paradaEditar.Nombre;
            txtUbicacion.Text = _paradaEditar.Ubicacion;
            nudOrden.Value = _paradaEditar.Orden;

            lblTitulo.Text = "EDITAR PARADA";
            btnGuardar.Text = "Actualizar";
        }




        private async void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Debe escribir el nombre.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtUbicacion.Text))
                {
                    MessageBox.Show("Debe escribir la ubicación.");
                    return;
                }

                bool resultado;

                if (_paradaEditar == null)
                {
                    var dto = new CreateParadaDto
                    {
                        Nombre = txtNombre.Text.Trim(),
                        Ubicacion = txtUbicacion.Text.Trim(),
                        Orden = (int)nudOrden.Value
                    };

                    resultado =
                        await _paradaApiService
                        .CreateAsync(dto);
                }
                else
                {
                    var dto = new UpdateParadaDto
                    {
                        Id = _paradaEditar.Id,
                        Nombre = txtNombre.Text.Trim(),
                        Ubicacion = txtUbicacion.Text.Trim(),
                        Orden = (int)nudOrden.Value
                    };

                    resultado =
                        await _paradaApiService
                        .UpdateAsync(dto);
                }

                if (resultado)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("No fue posible guardar la parada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void btnCancelar_Click(
            object sender,
            EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FrmNuevaParada_Load_1(object sender, EventArgs e)
        {

        }
    }
}
