using Microsoft.Extensions.DependencyInjection;
using SGA.Application.Dtos.Viaje;
using SGA.Desktop.Interfaces.Viaje;
using SGA.Domain.Enums.Reservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGA.Desktop.Modulos.Viaje
{
    public partial class FrmViajePrincipal : Form
    {
        private readonly IViajeApiService _viajeApiService;

        public FrmViajePrincipal(IViajeApiService viajeApiService)
        {
            InitializeComponent();

            _viajeApiService = viajeApiService;

            // Enlace de eventos garantizado por código
            dgvViajes.CellDoubleClick += dgvViajes_CellDoubleClick;
            btnNuevoViaje.Click += btnNuevoViaje_Click;
            btnIniciarViaje.Click += btnIniciarViaje_Click;
            btnCompletarViaje.Click += btnCompletarViaje_Click;
            btnCancelarViaje.Click += btnCancelarViaje_Click;
            btnEliminarViaje.Click += btnEliminarViaje_Click;
            btnRefrescar.Click += btnRefrescar_Click;
        }

        private async void FrmViajePrincipal_Load(object sender, EventArgs e)
        {
            await CargarTablaViajesAsync();
        }

        private async Task CargarTablaViajesAsync()
        {
            try
            {
                if (_viajeApiService == null) return;

                // Consumo directo desde la API HTTP
                var viajes = await _viajeApiService.GetAllAsync();

                // Desconectamos el DataSource actual antes de procesar
                dgvViajes.DataSource = null;

                if (viajes != null && viajes.Any())
                {
                    var viajesVista = viajes.Select(v => new
                    {
                        v.Id,
                        Estado = v.Estado.ToString(),

                        // 🟢 CORRECCIÓN AQUÍ: Lee HorarioTexto devuelto por el servidor en lugar de HoraInicioReal
                        Horario = !string.IsNullOrEmpty(v.HorarioTexto) ? v.HorarioTexto : "N/A",

                        Ruta = v.NombreRuta,
                        Autobus = v.PlacaAutobus,
                        Conductor = v.NombreConductor
                    }).ToList();

                    // Asignamos la nueva lista limpia recuperada vía API
                    dgvViajes.DataSource = viajesVista;

                    if (dgvViajes.Columns.Contains("Id")) dgvViajes.Columns["Id"].HeaderText = "ID";
                    if (dgvViajes.Columns.Contains("Estado")) dgvViajes.Columns["Estado"].HeaderText = "Estado";
                    if (dgvViajes.Columns.Contains("Horario")) dgvViajes.Columns["Horario"].HeaderText = "Horario";
                    if (dgvViajes.Columns.Contains("Ruta")) dgvViajes.Columns["Ruta"].HeaderText = "Ruta";
                    if (dgvViajes.Columns.Contains("Autobus")) dgvViajes.Columns["Autobus"].HeaderText = "Autobús";
                    if (dgvViajes.Columns.Contains("Conductor")) dgvViajes.Columns["Conductor"].HeaderText = "Conductor";

                    dgvViajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los viajes desde la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int? ObtenerIdViajeSeleccionado()
        {
            if (dgvViajes.CurrentRow != null && dgvViajes.CurrentRow.Index >= 0)
            {
                if (dgvViajes.CurrentRow.Cells["Id"] != null && dgvViajes.CurrentRow.Cells["Id"].Value != null)
                {
                    if (int.TryParse(dgvViajes.CurrentRow.Cells["Id"].Value.ToString(), out int id))
                    {
                        return id;
                    }
                }
            }
            return null;
        }

        private async void btnEliminarViaje_Click(object sender, EventArgs e)
        {
            int? viajeId = ObtenerIdViajeSeleccionado();

            if (!viajeId.HasValue)
            {
                MessageBox.Show("Por favor, seleccione un viaje de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea eliminar el viaje #{viajeId.Value}?\n\nEsta acción lo quitará permanentemente vía API.",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    bool exito = await _viajeApiService.DeleteAsync(viajeId.Value);

                    if (exito)
                    {
                        await CargarTablaViajesAsync();
                        MessageBox.Show("El viaje fue eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La API rechazó la solicitud de eliminación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo eliminar el viaje:\n\n{ex.Message}", "Error de Conexión API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnIniciarViaje_Click(object sender, EventArgs e)
        {
            int? viajeId = ObtenerIdViajeSeleccionado();
            if (viajeId.HasValue)
            {
                var viaje = await _viajeApiService.GetByIdAsync(viajeId.Value);
                if (viaje != null)
                {
                    var updateDto = new UpdateViajeDto
                    {
                        Estado = EstadoViaje.EnCurso,
                        RutaId = viaje.RutaId,
                        AutobusId = viaje.AutobusId,
                        ConductorId = viaje.ConductorId,
                        HorarioId = viaje.HorarioId
                    };

                    bool exito = await _viajeApiService.UpdateAsync(viajeId.Value, updateDto);
                    if (exito)
                    {
                        MessageBox.Show("El viaje ha sido iniciado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await CargarTablaViajesAsync();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un viaje para iniciar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnCompletarViaje_Click(object sender, EventArgs e)
        {
            int? viajeId = ObtenerIdViajeSeleccionado();
            if (viajeId.HasValue)
            {
                var viaje = await _viajeApiService.GetByIdAsync(viajeId.Value);
                if (viaje != null)
                {
                    var updateDto = new UpdateViajeDto
                    {
                        Estado = EstadoViaje.Finalizado,
                        RutaId = viaje.RutaId,
                        AutobusId = viaje.AutobusId,
                        ConductorId = viaje.ConductorId,
                        HorarioId = viaje.HorarioId
                    };

                    bool exito = await _viajeApiService.UpdateAsync(viajeId.Value, updateDto);
                    if (exito)
                    {
                        MessageBox.Show("El viaje ha sido completado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await CargarTablaViajesAsync();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un viaje para completar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnCancelarViaje_Click(object sender, EventArgs e)
        {
            int? viajeId = ObtenerIdViajeSeleccionado();
            if (viajeId.HasValue)
            {
                var viaje = await _viajeApiService.GetByIdAsync(viajeId.Value);
                if (viaje != null)
                {
                    var confirm = MessageBox.Show($"¿Está seguro de cancelar el viaje #{viaje.Id}?",
                        "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {
                        var updateDto = new UpdateViajeDto
                        {
                            Estado = EstadoViaje.Cancelado,
                            RutaId = viaje.RutaId,
                            AutobusId = viaje.AutobusId,
                            ConductorId = viaje.ConductorId,
                            HorarioId = viaje.HorarioId
                        };

                        bool exito = await _viajeApiService.UpdateAsync(viajeId.Value, updateDto);
                        if (exito)
                        {
                            MessageBox.Show("El viaje fue cancelado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await CargarTablaViajesAsync();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un viaje para cancelar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnNuevoViaje_Click(object sender, EventArgs e)
        {
            try
            {
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
                MessageBox.Show($"Error al abrir nuevo viaje:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvViajes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                AbrirEdicionViaje();
            }
        }

        private async void AbrirEdicionViaje()
        {
            int? viajeId = ObtenerIdViajeSeleccionado();

            if (viajeId.HasValue)
            {
                try
                {
                    var viajeSeleccionado = await _viajeApiService.GetByIdAsync(viajeId.Value);
                    if (viajeSeleccionado == null)
                    {
                        MessageBox.Show("No se encontró el viaje seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

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
                    MessageBox.Show($"Error al editar viaje:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un viaje de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnRefrescar_Click(object sender, EventArgs e)
        {
            await CargarTablaViajesAsync();
        }
    }
}