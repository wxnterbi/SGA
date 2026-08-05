using Microsoft.Extensions.DependencyInjection;
using SGA.Application.Dtos.Ruta;
using SGA.Desktop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SGA.Desktop.Modulos.RutaHorarios
{
    public partial class FrmGestionRutaHorario : Form
    {
        private readonly ApiClient _apiClient;

        public FrmGestionRutaHorario(ApiClient apiClient = null)
        {
            InitializeComponent();

            _apiClient = apiClient ?? Program.ServiceProvider.GetRequiredService<ApiClient>();

            this.Load += FrmGestionRutaHorario_Load;

            txtBuscarRuta.TextChanged += TxtBuscarRuta_TextChanged;
            dgvRutas.SelectionChanged += DgvRutas_SelectionChanged;
        }

        private async void FrmGestionRutaHorario_Load(object sender, EventArgs e)
        {
            await CargarRutasAsync();
        }

        private async System.Threading.Tasks.Task CargarRutasAsync()
        {
            try
            {
                var rutas = await _apiClient.GetAsync<List<RutaDto>>("rutas");
                dgvRutas.DataSource = rutas?.ToList() ?? new List<RutaDto>();

                if (dgvRutas.Columns["Id"] != null) dgvRutas.Columns["Id"].Width = 50;
                if (dgvRutas.Columns["Nombre"] != null) dgvRutas.Columns["Nombre"].HeaderText = "Ruta";
                if (dgvRutas.Columns["Origen"] != null) dgvRutas.Columns["Origen"].HeaderText = "Origen";
                if (dgvRutas.Columns["Destino"] != null) dgvRutas.Columns["Destino"].HeaderText = "Destino";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar rutas desde la API: {ex.Message}", "SGA ITLA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void DgvRutas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRutas.CurrentRow != null && dgvRutas.CurrentRow.DataBoundItem is RutaDto rutaSeleccionada)
            {
                int rutaId = rutaSeleccionada.Id;
                lblRutaSeleccionada.Text = $"Ruta: {rutaSeleccionada.Nombre}";

                await CargarHorariosPorRutaAsync(rutaId);
            }
        }

        private async System.Threading.Tasks.Task CargarHorariosPorRutaAsync(int rutaId)
        {
            try
            {
                var todosLosHorarios = await _apiClient.GetAsync<List<HorarioDto>>("horarios");

                if (todosLosHorarios != null)
                {
                    var horariosDeLaRuta = todosLosHorarios
                        .Where(h => h.RutaId == rutaId)
                        .Select(h => new
                        {
                            HoraSalida = DateTime.Today.Add(h.HoraSalida).ToString("hh:mm tt"),
                            Dias = h.DiasOperacion
                        })
                        .ToList();

                    dgvHorarios.DataSource = horariosDeLaRuta;

                    if (dgvHorarios.Columns["HoraSalida"] != null)
                        dgvHorarios.Columns["HoraSalida"].HeaderText = "Hora de Salida";

                    if (dgvHorarios.Columns["Dias"] != null)
                        dgvHorarios.Columns["Dias"].HeaderText = "Días de Operación";
                }
            }
            catch (Exception)
            {
                dgvHorarios.DataSource = null;
            }
        }

        private void TxtBuscarRuta_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscarRuta.Text.ToLower().Trim();
        }

        private void btnNuevaRuta_Click(object sender, EventArgs e)
        {
            using (var modal = new FrmNuevaRuta())
            {
                if (modal.ShowDialog() == DialogResult.OK)
                {
                    _ = CargarRutasAsync();
                }
            }
        }

        private void btnNuevoHorario_Click(object sender, EventArgs e)
        {
            if (dgvRutas.CurrentRow == null || !(dgvRutas.CurrentRow.DataBoundItem is RutaDto rutaSeleccionada))
            {
                MessageBox.Show("Por favor, seleccione primero una ruta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var modal = new FrmNuevoHorario(rutaSeleccionada.Id))
            {
                if (modal.ShowDialog() == DialogResult.OK)
                {
                    _ = CargarHorariosPorRutaAsync(rutaSeleccionada.Id);
                }
            }
        }
    }

    public class HorarioDto
    {
        public int Id { get; set; }
        public int RutaId { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public string DiasOperacion { get; set; }
    }
}