using System;
using System.Windows.Forms;
using SGA.Application.Dtos.Ruta;
using SGA.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace SGA.Desktop.Modulos.RutaHorarios
{
    public partial class FrmNuevaRuta : Form
    {
        private readonly IRutaService _rutaService;

        public FrmNuevaRuta(IRutaService rutaService = null)
        {
            InitializeComponent();
            _rutaService = rutaService ?? Program.ServiceProvider.GetRequiredService<IRutaService>();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre de la ruta.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtOrigen.Text) || string.IsNullOrWhiteSpace(txtDestino.Text))
            {
                MessageBox.Show("Por favor, ingrese el origen y destino.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var nuevaRuta = new RutaDto
                {
                    Nombre = txtNombre.Text.Trim(),
                    Origen = txtOrigen.Text.Trim(),
                    Destino = txtDestino.Text.Trim()
                };

                await _rutaService.AddAsync(nuevaRuta);

                MessageBox.Show("¡Ruta registrada correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la ruta: {ex.Message}", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}