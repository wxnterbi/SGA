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
            var conductores = await _conductorRepository.GetAllAsync();

            var dtos = conductores.Select(c => new ConductorDto
            {
                Id = c.Id,
                Nombre = c.Nombre,
                Cedula = c.Cedula,
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
                Cedula = c.Cedula,
                Licencia = c.Licencia,    
                Telefono = c.Telefono,
                EstadoConductorId = (int)c.EstadoLaboral
            };

            return await Task.FromResult(dto);
        }

        public async Task AddAsync(ConductorDto dto)
        {
            var existeCedula = _conductorRepository.GetByCedula(dto.Cedula);
            if (existeCedula != null)
            {
                throw new InvalidOperationException("CEDULA_DUPLICADA");
            }

            var existeTelefono = _conductorRepository.GetByTelefono(dto.Telefono);
            if (existeTelefono != null)
            {
                throw new InvalidOperationException("TELEFONO_DUPLICADO");
            }

            var conductor = new Conductor
            {
                Nombre = dto.Nombre,
                Cedula = dto.Cedula,
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
            var conductorConMismaCedula = _conductorRepository.GetByCedula(dto.Cedula);
            if (conductorConMismaCedula != null && conductorConMismaCedula.Id != dto.Id)
            {
                throw new InvalidOperationException("CEDULA_DUPLICADA");
            }

            var conductorConMismoTelefono = _conductorRepository.GetByTelefono(dto.Telefono);
            if (conductorConMismoTelefono != null && conductorConMismoTelefono.Id != dto.Id)
            {
                throw new InvalidOperationException("TELEFONO_DUPLICADO");
            }

            var conductor = _conductorRepository.GetById(dto.Id);
            if (conductor != null)
            {
                conductor.Nombre = dto.Nombre;
                conductor.Cedula = dto.Cedula;
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