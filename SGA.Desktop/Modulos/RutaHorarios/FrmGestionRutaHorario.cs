using Microsoft.Extensions.DependencyInjection;
using SGA.Application.Dtos.Ruta;
using SGA.Application.Interfaces;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SGA.Desktop.Modulos.RutaHorarios
{
    public partial class FrmGestionRutaHorario : Form
    {
        private readonly IRutaService _rutaService;
        private readonly IHorarioService _horarioService;

        public FrmGestionRutaHorario(IRutaService rutaService = null, IHorarioService horarioService = null)
        {
            InitializeComponent();

            _rutaService = rutaService ?? Program.ServiceProvider.GetRequiredService<IRutaService>();
            _horarioService = horarioService ?? Program.ServiceProvider.GetRequiredService<IHorarioService>();

            this.Load += FrmGestionRutaHorario_Load;

            // Evento para filtrar al escribir
            txtBuscarRuta.TextChanged += TxtBuscarRuta_TextChanged;

            // Evento Maestro-Detalle: Al cambiar de ruta, se actualizan los horarios
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
                var rutas = await _rutaService.GetAllAsync();
                dgvRutas.DataSource = rutas.ToList();

                // Formatear columnas visibles según las propiedades reales de RutaDto
                if (dgvRutas.Columns["Id"] != null) dgvRutas.Columns["Id"].Width = 50;
                if (dgvRutas.Columns["Nombre"] != null) dgvRutas.Columns["Nombre"].HeaderText = "Ruta";
                if (dgvRutas.Columns["Origen"] != null) dgvRutas.Columns["Origen"].HeaderText = "Origen";
                if (dgvRutas.Columns["Destino"] != null) dgvRutas.Columns["Destino"].HeaderText = "Destino";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar rutas: {ex.Message}", "SGA ITLA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // 1. Obtenemos todos los horarios
                var todosLosHorarios = await _horarioService.GetAllAsync();

                // 2. Filtramos en memoria por el ID de la Ruta seleccionada
                var horariosDeLaRuta = todosLosHorarios
                    .Where(h => h.RutaId == rutaId)
                    .Select(h => new
                    {
                        // Convierte la hora a string legible (ej: "06:30 AM", "07:30 PM")
                        HoraSalida = DateTime.Today.Add(h.HoraSalida).ToString("hh:mm tt"),
                        Dias = h.DiasOperacion
                    })
                    .ToList();

                // 3. Asignamos a la tabla de la derecha
                dgvHorarios.DataSource = horariosDeLaRuta;

                if (dgvHorarios.Columns["HoraSalida"] != null)
                    dgvHorarios.Columns["HoraSalida"].HeaderText = "Hora de Salida";

                if (dgvHorarios.Columns["Dias"] != null)
                    dgvHorarios.Columns["Dias"].HeaderText = "Días de Operación";
            }
            catch (Exception)
            {
                dgvHorarios.DataSource = null;
            }
        }

        private void TxtBuscarRuta_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscarRuta.Text.ToLower().Trim();
            // Lógica de filtrado opcional
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

            // Pasamos el ID de la ruta seleccionada
            using (var modal = new FrmNuevoHorario(rutaSeleccionada.Id))
            {
                if (modal.ShowDialog() == DialogResult.OK)
                {
                    _ = CargarHorariosPorRutaAsync(rutaSeleccionada.Id);
                }
            }
        }
    }
}