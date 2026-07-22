using SGA.Application.Dtos.Conductor;
using SGA.Application.Interfaces;
using SGA.Domain.Entities.Configuration;
using SGA.Infrastructure.Notifications;
using SGA.Persistence.Interfaces;

namespace SGA.Application.Services
{
    public class ConductorService : IConductorService
    {
        private readonly IConductorRepository _conductorRepository;
        private readonly INotificationService _notificationService;

        public ConductorService(
            IConductorRepository conductorRepository,
            INotificationService notificationService)
        {
            _conductorRepository = conductorRepository;
            _notificationService = notificationService;
        }

        public async Task<IEnumerable<ConductorDto>> GetAllAsync()
        {
            var conductores = _conductorRepository.GetAll();

            var dtos = conductores.Select(c => new ConductorDto
            {
                Id = c.Id,
                Nombre = c.Nombre,
                Cedula = c.Identificacion,
                Licencia = c.Licencia,  
                Telefono = c.Telefono,
                EstadoConductorId = (int)c.EstadoLaboral
            });

            return await Task.FromResult(dtos);
        }

        public async Task<ConductorDto?> GetByIdAsync(int id)
        {
            var c = _conductorRepository.GetById(id);
            if (c == null) return null;

            var dto = new ConductorDto
            {
                Id = c.Id,
                Nombre = c.Nombre,
                Cedula = c.Identificacion,
                Licencia = c.Licencia,    
                Telefono = c.Telefono,
                EstadoConductorId = (int)c.EstadoLaboral
            };

            return await Task.FromResult(dto);
        }

        public async Task AddAsync(ConductorDto dto)
        {
            var conductor = new Conductor
            {
                Nombre = dto.Nombre,
                Identificacion = dto.Cedula,
                Licencia = dto.Licencia,   
                Telefono = dto.Telefono,
                EstadoLaboral = (Domain.Enums.Configuration.EstadoLaboral)dto.EstadoConductorId
            };

            _conductorRepository.Add(conductor);

            await _notificationService.SendNotificationAsync(
                "conductor@itla.edu.do",
                "Conductor registrado",
                "El conductor fue registrado correctamente.");
        }

        public async Task UpdateAsync(ConductorDto dto)
        {
            var conductor = _conductorRepository.GetById(dto.Id);
            if (conductor != null)
            {
                conductor.Nombre = dto.Nombre;
                conductor.Identificacion = dto.Cedula;
                conductor.Licencia = dto.Licencia;  
                conductor.Telefono = dto.Telefono;
                conductor.EstadoLaboral = (Domain.Enums.Configuration.EstadoLaboral)dto.EstadoConductorId;

                _conductorRepository.Update(conductor);
            }
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(int id)
        {
            _conductorRepository.Delete(id);
            await Task.CompletedTask;
        }
    }
}