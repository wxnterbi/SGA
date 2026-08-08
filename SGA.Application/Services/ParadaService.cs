using SGA.Application.Dtos.Parada;
using SGA.Application.Dtos.Auditoria;
using SGA.Application.Interfaces;
using SGA.Application.Helpers;
using SGA.Domain.Entities.Configuration;
using SGA.Infrastructure.Notifications;
using SGA.Persistence.Interfaces;

namespace SGA.Application.Services
{
    public class ParadaService : IParadaService
    {
        private readonly IParadaRepository _paradaRepository;
        private readonly INotificationService _notificationService;
        private readonly IAuditoriaService _auditoriaService;

        public ParadaService(
            IParadaRepository paradaRepository,
            INotificationService notificationService,
            IAuditoriaService auditoriaService)
        {
            _paradaRepository = paradaRepository;
            _notificationService = notificationService;
            _auditoriaService = auditoriaService;
        }

        public Task<IEnumerable<ParadaDto>> GetAllAsync()
        {
            var paradas = _paradaRepository.GetAll();

            var resultado = paradas.Select(p => new ParadaDto
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Ubicacion = p.Ubicacion,
                Orden = p.Orden
            });

            return Task.FromResult(resultado);
        }

        public Task<ParadaDto?> GetByIdAsync(int id)
        {
            var parada = _paradaRepository.GetById(id);

            if (parada == null)
                return Task.FromResult<ParadaDto?>(null);

            return Task.FromResult<ParadaDto?>(new ParadaDto
            {
                Id = parada.Id,
                Nombre = parada.Nombre,
                Ubicacion = parada.Ubicacion,
                Orden = parada.Orden
            });
        }

        public async Task AddAsync(CreateParadaDto dto)
        {
            var parada = new Parada
            {
                Nombre = dto.Nombre,
                Ubicacion = dto.Ubicacion,
                Orden = dto.Orden
            };

            _paradaRepository.Add(parada);

            await _notificationService.SendNotificationAsync(
                "usuario@itla.edu.do",
                "Parada registrada",
                $"La parada '{parada.Nombre}' fue registrada correctamente en el sistema."
            );


            await RegistrarAuditoria("Crear Parada",
                $"Se creó la parada '{parada.Nombre}'");
        }

        public async Task UpdateAsync(UpdateParadaDto dto)
        {
            var parada = _paradaRepository.GetById(dto.Id);

            if (parada == null)
                throw new Exception("Parada no encontrada.");

            parada.Nombre = dto.Nombre;
            parada.Ubicacion = dto.Ubicacion;
            parada.Orden = dto.Orden;

            _paradaRepository.Update(parada);


            await RegistrarAuditoria("Actualizar Parada",
                $"Se actualizó la parada ID {dto.Id}");
        }

        public async Task DeleteAsync(int id)
        {
            var eliminado = _paradaRepository.Delete(id);

            if (!eliminado)
                throw new Exception("Parada no encontrada.");


            await RegistrarAuditoria("Eliminar Parada",
                $"Se eliminó la parada ID {id}");
        }


        private async Task RegistrarAuditoria(string accion, string descripcion)
        {
            await _auditoriaService.AddAsync(new CreateAuditoriaDto
            {
                Actor = string.IsNullOrEmpty(SessionManager.Usuario)
                    ? "Sistema"
                    : SessionManager.Usuario,

                TipoAccion = accion,
                Descripcion = descripcion
            });
        }
    }
}