using Microsoft.Extensions.DependencyInjection;
using SGA.Application.Dtos.Viaje;
using SGA.Application.Interfaces;
using SGA.Domain.Enums.Reservation;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGA.Desktop.Modulos.Viaje
{
    public partial class FrmViajePrincipal : Form
    {
        private readonly IViajeService _viajeService;
        private readonly IRutaService _rutaService;
        private readonly IAutobusService _autobusService;
        private readonly IConductorService _conductorService;
        private readonly IHorarioService _horarioService;

        public FrmViajePrincipal(
            IViajeService viajeService,
            IRutaService rutaService,
            IAutobusService autobusService,
            IConductorService conductorService,
            IHorarioService horarioService)
        {
            InitializeComponent();

            _viajeService = viajeService;
            _rutaService = rutaService;
            _autobusService = autobusService;
            _conductorService = conductorService;
            _horarioService = horarioService;

            dgvViajes.CellDoubleClick += dgvViajes_CellDoubleClick;
        }

        private void dgvViajes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que no haya dado clic en los encabezados (e.RowIndex >= 0)
            if (e.RowIndex >= 0)
            {
                AbrirEdicionViaje();
            }
        }

        private async void FrmViajePrincipal_Load(object sender, EventArgs e)
        {
            await CargarTablaViajesAsync();
        }

        private async Task CargarTablaViajesAsync()
        {
            try
            {
                // Si el servicio es null, salimos amistosamente sin explotar
                if (_viajeService == null)
                {
                    return;
                }

                var viajes = await _viajeService.GetAllAsync();

                if (viajes != null)
                {
                    // 1. Asignar los datos
                    dgvViajes.DataSource = viajes.ToList();

                    // 2. Ocultar columnas de IDs para el usuario
                    if (dgvViajes.Columns.Contains("RutaId")) dgvViajes.Columns["RutaId"].Visible = false;
                    if (dgvViajes.Columns.Contains("HorarioId")) dgvViajes.Columns["HorarioId"].Visible = false;
                    if (dgvViajes.Columns.Contains("AutobusId")) dgvViajes.Columns["AutobusId"].Visible = false;
                    if (dgvViajes.Columns.Contains("ConductorId")) dgvViajes.Columns["ConductorId"].Visible = false;

                    // 3. Renombrar encabezados para mostrar la información legible
                    if (dgvViajes.Columns.Contains("Id")) dgvViajes.Columns["Id"].HeaderText = "ID";
                    if (dgvViajes.Columns.Contains("NombreRuta")) dgvViajes.Columns["NombreRuta"].HeaderText = "Ruta";
                    if (dgvViajes.Columns.Contains("PlacaAutobus")) dgvViajes.Columns["PlacaAutobus"].HeaderText = "Autobús";
                    if (dgvViajes.Columns.Contains("NombreConductor")) dgvViajes.Columns["NombreConductor"].HeaderText = "Conductor";
                    if (dgvViajes.Columns.Contains("Estado")) dgvViajes.Columns["Estado"].HeaderText = "Estado";
                    if (dgvViajes.Columns.Contains("HoraInicioReal")) dgvViajes.Columns["HoraInicioReal"].HeaderText = "Hora Inicio";
                    if (dgvViajes.Columns.Contains("HoraFinReal")) dgvViajes.Columns["HoraFinReal"].HeaderText = "Hora Fin";

                    // 4. Auto-ajustar columnas al ancho de la tabla
                    dgvViajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los viajes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // 🟢 1. BOTÓN PROGRAMAR NUEVO VIAJE
        // ==========================================
        private async void btnNuevoViaje_Click(object sender, EventArgs e)
        {
            try
            {
                // 🛡️ CREAMOS UN SCOPE DEDICADO PARA EL MODAL
                // Esto aísla el DbContext y los servicios, evitando el congelamiento de la UI
                using (var scope = Program.ServiceProvider.CreateScope())
                {
                    var modal = scope.ServiceProvider.GetRequiredService<FrmNuevoViajeModal>();

                    if (modal.ShowDialog(this) == DialogResult.OK)
                    {
                        await CargarTablaViajesAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir la ventana de nuevo viaje:\n{ex.Message}\n\nDetalles: {ex.InnerException?.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // ✏️ 2. EDITAR / ACTUALIZAR VIAJE (Doble Clic o Botón)
        // ==========================================
        private async void AbrirEdicionViaje()
        {
            if (dgvViajes.CurrentRow?.DataBoundItem is ViajeDto viajeSeleccionado)
            {
                try
                {
                    // 💡 SOLUCIÓN: Usamos ActivatorUtilities para crear el modal inyectando servicios limpios + el DTO a editar
                    using (var modal = ActivatorUtilities.CreateInstance<FrmNuevoViajeModal>(Program.ServiceProvider, viajeSeleccionado))
                    {
                        if (modal.ShowDialog() == DialogResult.OK)
                        {
                            await CargarTablaViajesAsync();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al abrir la ventana de edición:\n{ex.Message}\n\nDetalles: {ex.InnerException?.Message}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un viaje de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ==========================================
        // 🚀 3. BOTÓN INICIAR VIAJE
        // ==========================================
        private async void btnIniciarViaje_Click(object sender, EventArgs e)
        {
            if (dgvViajes.CurrentRow?.DataBoundItem is ViajeDto viaje)
            {
                viaje.Estado = EstadoViaje.Programado; // O el estado que uses en tu Enum
                await _viajeService.UpdateAsync(viaje);
                MessageBox.Show("El viaje ha sido iniciado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CargarTablaViajesAsync();
            }
        }

        // ==========================================
        // ✅ 4. BOTÓN COMPLETAR VIAJE
        // ==========================================
        private async void btnCompletarViaje_Click(object sender, EventArgs e)
        {
            if (dgvViajes.CurrentRow?.DataBoundItem is ViajeDto viaje)
            {
                viaje.Estado = EstadoViaje.Finalizado;
                await _viajeService.UpdateAsync(viaje);
                MessageBox.Show("El viaje ha sido completado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CargarTablaViajesAsync();
            }
        }

        // ==========================================
        // ❌ 5. BOTÓN CANCELAR VIAJE
        // ==========================================
        private async void btnCancelarViaje_Click(object sender, EventArgs e)
        {
            if (dgvViajes.CurrentRow?.DataBoundItem is ViajeDto viaje)
            {
                var confirm = MessageBox.Show($"¿Está seguro de cancelar el viaje #{viaje.Id}?",
                    "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    viaje.Estado = EstadoViaje.Cancelado;
                    await _viajeService.UpdateAsync(viaje);
                    MessageBox.Show("El viaje fue cancelado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CargarTablaViajesAsync();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un viaje para cancelar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ==========================================
        // 🔄 6. BOTÓN REFRESCAR
        // ==========================================
        private async void btnRefrescar_Click(object sender, EventArgs e)
        {
            await CargarTablaViajesAsync();
        }
    }
}