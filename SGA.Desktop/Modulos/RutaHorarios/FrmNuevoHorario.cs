using System;
using System.Windows.Forms;
using SGA.Application.Dtos.Horario;
using SGA.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace SGA.Desktop.Modulos.RutaHorarios
{
    public partial class FrmNuevoHorario : Form
    {
        private readonly IHorarioService _horarioService;
        private readonly int _rutaId;

        public FrmNuevoHorario(int rutaId, IHorarioService horarioService = null)
        {
            InitializeComponent();
            _rutaId = rutaId;
            _horarioService = horarioService ?? Program.ServiceProvider.GetRequiredService<IHorarioService>();
        }

        private void FrmNuevoHorario_Load(object sender, EventArgs e)
        {
            // Seleccionar valor por defecto
            if (cmbDiasOperacion.Items.Count > 0)
                cmbDiasOperacion.SelectedIndex = 0;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevoHorario = new HorarioDto
                {
                    RutaId = _rutaId,
                    HoraSalida = dtpHoraSalida.Value.TimeOfDay,
                    DiasOperacion = cmbDiasOperacion.SelectedItem?.ToString() ?? "Lunes a Viernes"
                };

                await _horarioService.AddAsync(nuevoHorario);

                MessageBox.Show("¡Horario registrado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el horario: {ex.Message}", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}