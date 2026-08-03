using SGA.Application.Dtos.Ruta;
using SGA.Application.Interfaces;
using SGA.Domain.Entities.Configuration;
using SGA.Infrastructure.Notifications;
using SGA.Persistence.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGA.Application.Services
{
    public class RutaService : IRutaService
    {
        private readonly IRutaRepository _rutaRepository;
        private readonly INotificationService _notificationService;

        public RutaService(
            IRutaRepository rutaRepository,
            INotificationService notificationService)
        {
            _rutaRepository = rutaRepository;
            _notificationService = notificationService;
        }

        // 🟢 LIBERA EL HILO DE LA UI DE VERDAD
        public async Task<IEnumerable<RutaDto>> GetAllAsync()
        {
            var rutas = await _rutaRepository.GetAllAsync();

            return rutas.Select(r => new RutaDto
            {
                Id = r.Id,
                Nombre = r.Nombre,
                Origen = r.Origen,
                Destino = r.Destino
            });
        }

        public async Task<RutaDto?> GetByIdAsync(int id)
        {
            var ruta = await _rutaRepository.GetByIdAsync(id);
            if (ruta == null) return null;

            return new RutaDto
            {
                Id = ruta.Id,
                Nombre = ruta.Nombre,
                Origen = ruta.Origen,
                Destino = ruta.Destino
            };
        }

        public async Task AddAsync(RutaDto dto)
        {
            var ruta = new Ruta
            {
                Nombre = dto.Nombre,
                Origen = dto.Origen,
                Destino = dto.Destino
            };

            await _rutaRepository.AddAsync(ruta);

            await _notificationService.SendNotificationAsync(
                "estudiante@itla.edu.do",
                "Nueva ruta",
                "Se registró una nueva ruta correctamente.");
        }

        public async Task UpdateAsync(RutaDto dto)
        {
            var ruta = await _rutaRepository.GetByIdAsync(dto.Id);
            if (ruta == null)
                throw new Exception("Ruta no encontrada.");

            ruta.Nombre = dto.Nombre;
            ruta.Origen = dto.Origen;
            ruta.Destino = dto.Destino;

            await _rutaRepository.UpdateAsync(ruta);
        }

        public async Task DeleteAsync(int id)
        {
            var eliminado = await _rutaRepository.DeleteAsync(id);
            if (!eliminado)
                throw new Exception("Ruta no encontrada.");
        }
    }
}