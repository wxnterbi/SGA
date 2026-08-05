using SGA.Application.BusinessRules;
using SGA.Application.Dtos.Viaje;
using SGA.Application.Interfaces;
using SGA.Domain.Entities.Reservation;
using SGA.Domain.Enums.Reservation;
using SGA.Infrastructure.Notifications;
using SGA.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGA.Application.Services
{
    public class ViajeService : IViajeService
    {
        private readonly IViajeRepository _viajeRepository;
        private readonly ViajeRules _viajeRules;
        private readonly INotificationService _notificationService;

        public ViajeService(
            IViajeRepository viajeRepository,
            ViajeRules viajeRules,
            INotificationService notificationService)
        {
            _viajeRepository = viajeRepository;
            _viajeRules = viajeRules;
            _notificationService = notificationService;
        }

        public async Task<ViajeDto?> GetByIdAsync(int id)
        {
            var viaje = await _viajeRepository.GetByIdAsync(id);

            if (viaje == null)
                return null;

            return MapToDto(viaje);
        }

        public async Task<IEnumerable<ViajeDto>> GetAllAsync()
        {
            var viajes = await _viajeRepository.GetAllAsync();

            return viajes.Select(viaje => MapToDto(viaje));
        }

        public async Task AddAsync(ViajeDto dto)
        {
            await _viajeRules.ValidarAsignacionViaje(
                dto.RutaId,
                dto.HorarioId,
                dto.AutobusId,
                dto.ConductorId);

            var viaje = new Viaje
            {
                RutaId = dto.RutaId,
                HorarioId = dto.HorarioId,
                AutobusId = dto.AutobusId,
                ConductorId = dto.ConductorId,
                Estado = dto.Estado == 0
                    ? EstadoViaje.Programado
                    : dto.Estado
            };

            await _viajeRepository.AddAsync(viaje);

            await _notificationService.SendNotificationAsync(
                "estudiante@itla.edu.do",
                "Viaje registrado",
                "Se registró un nuevo viaje correctamente.");
        }

        public async Task UpdateAsync(ViajeDto dto)
        {
            var viaje = await _viajeRepository.GetByIdAsync(dto.Id);

            if (viaje != null)
            {
                viaje.RutaId = dto.RutaId;
                viaje.HorarioId = dto.HorarioId;
                viaje.AutobusId = dto.AutobusId;
                viaje.ConductorId = dto.ConductorId;
                viaje.Estado = dto.Estado;
                viaje.HoraInicioReal = dto.HoraInicioReal;
                viaje.HoraFinReal = dto.HoraFinReal;

                await _viajeRepository.UpdateAsync(viaje);
            }
        }

        public async Task DeleteAsync(int id)
        {
            await _viajeRepository.DeleteAsync(id);
        }

        private static ViajeDto MapToDto(Viaje viaje)
        {
            return new ViajeDto
            {
                Id = viaje.Id,
                RutaId = viaje.RutaId,
                HorarioId = viaje.HorarioId,
                AutobusId = viaje.AutobusId,
                ConductorId = viaje.ConductorId,
                Estado = viaje.Estado,
                HoraInicioReal = viaje.HoraInicioReal,
                HoraFinReal = viaje.HoraFinReal,

                HorarioTexto = viaje.Horario != null
                    ? DateTime.Today.Add(viaje.Horario.HoraSalida)
                        .ToString("hh:mm tt")
                    : "N/A",

                NombreRuta = viaje.Ruta != null
                    ? $"{viaje.Ruta.Origen} - {viaje.Ruta.Destino}"
                    : $"Ruta #{viaje.RutaId}",

                PlacaAutobus = viaje.Autobus != null
                    ? viaje.Autobus.Placa
                    : $"Autobús #{viaje.AutobusId}",

                NombreConductor = viaje.Conductor != null
                    ? viaje.Conductor.Nombre
                    : $"Conductor #{viaje.ConductorId}"
            };
        }
    }
}