using SGA.Application.Dtos.Parada;
using SGA.Application.Interfaces;
using SGA.Domain.Entities.Configuration;
using SGA.Infrastructure.Notifications;
using SGA.Persistence.Interfaces;

namespace SGA.Application.Services
{
    public class ParadaService : IParadaService
    {
        private readonly IParadaRepository _paradaRepository;
        private readonly INotificationService _notificationService;

        public ParadaService(
            IParadaRepository paradaRepository,
            INotificationService notificationService)
        {
            _paradaRepository = paradaRepository;
            _notificationService = notificationService;
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
        }


        public Task UpdateAsync(UpdateParadaDto dto)
        {
            var parada = new Parada
            {
                Id = dto.Id,
                Nombre = dto.Nombre,
                Ubicacion = dto.Ubicacion,
                Orden = dto.Orden
            };


            _paradaRepository.Update(parada);

            return Task.CompletedTask;
        }


        public Task DeleteAsync(int id)
        {
            var eliminado = _paradaRepository.Delete(id);

            if (!eliminado)
                throw new Exception("Parada no encontrada.");


            return Task.CompletedTask;
        }
    }
}