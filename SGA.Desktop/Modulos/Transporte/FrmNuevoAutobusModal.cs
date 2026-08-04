using Microsoft.Extensions.DependencyInjection;
using SGA.Application.Dtos.Autobus;
using SGA.Desktop.Interfaces.Autobus;
using System;
using System.Windows.Forms;

namespace SGA.Desktop.Modulos.Transporte
{
    // 🟢 Clase auxiliar con tipos explícitos para evitar fallos de reflexión en WinForms
    public class ComboEstadoItem
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
    }

    public partial class FrmNuevoAutobusModal : Form
    {
        private readonly IAutobusApiService _autobusApiService;

        public FrmNuevoAutobusModal(IAutobusApiService autobusApiService = null)
        {
            InitializeComponent();
            _autobusApiService = autobusApiService ?? Program.ServiceProvider.GetRequiredService<IAutobusApiService>();

            CargarEstados();
        }

        private void CargarEstados()
        {
            cmbEstado.Items.Clear();

            // 🟢 Usar instancias de ComboEstadoItem en lugar de objetos anónimos
            var estados = new[]
            {
                new ComboEstadoItem { Id = 1, Nombre = "Disponible" },
                new ComboEstadoItem { Id = 2, Nombre = "En Mantenimiento" }
            };

            cmbEstado.DisplayMember = "Nombre";
            cmbEstado.ValueMember = "Id";
            cmbEstado.DataSource = estados;
            cmbEstado.SelectedIndex = 0;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // 🟢 Obtener el ID seleccionado de forma segura mediante SelectedValue
                int estadoId = 0;
                if (cmbEstado.SelectedValue is int idInt)
                {
                    estadoId = idInt;
                }
                else if (cmbEstado.SelectedItem is ComboEstadoItem item)
                {
                    estadoId = item.Id;
                }

                var nuevoAutobusDto = new CreateAutobusDto
                {
                    Placa = txtPlaca.Text.Trim().ToUpper(),
                    Marca = txtMarca.Text.Trim(),
                    Modelo = txtModelo.Text.Trim(),
                    Capacidad = (int)numCapacidad.Value,
                    EstadoAutobusId = estadoId
                };

                // Enviamos el DTO directamente a la API.
                bool exito = await _autobusApiService.CreateAsync(nuevoAutobusDto);

                if (exito)
                {
                    MessageBox.Show("¡Autobús registrado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de validación:\n\n{ex.Message}", "Validación SGA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}