using SGA.Application.Interfaces;
using SGA.Application.Dtos.Conductor;
using SGA.Persistence.Interfaces;
using SGA.Domain.Entities.Configuration;

namespace SGA.Application.Services
{
    public class ConductorService : IConductorService
    {
        private readonly IConductorRepository _conductorRepository;

        public ConductorService(IConductorRepository conductorRepository)
        {
            _conductorRepository = conductorRepository ?? throw new ArgumentNullException(nameof(conductorRepository));
        }

        public async Task<IEnumerable<ConductorDto>> GetAllAsync()
        {
            var conductores = await _conductorRepository.GetAllAsync();
            return conductores.Select(c => new ConductorDto
            {
                Id = c.Id,
                Nombre = c.Nombre,
                Apellido = c.Apellido,
                Cedula = c.Cedula,
                Licencia = c.Licencia,
                Telefono = c.Telefono,
                FechaContratacion = c.FechaContratacion,
                EstadoConductorId = (int)c.EstadoLaboral
            });
        }

        public async Task<ConductorDto> GetByIdAsync(int id)
        {
            var c = await _conductorRepository.GetByIdAsync(id);
            if (c == null) return null;

            return new ConductorDto
            {
                Id = c.Id,
                Nombre = c.Nombre,
                Apellido = c.Apellido,
                Cedula = c.Cedula,
                Licencia = c.Licencia,
                Telefono = c.Telefono,
                FechaContratacion = c.FechaContratacion,
                EstadoConductorId = (int)c.EstadoLaboral
            };
        }

        public async Task<bool> CreateAsync(CreateConductorDto dto)
        {
            var conductor = new Conductor
            {
                Nombre = dto.Nombre,
                Apellido = dto.Apellido,
                Cedula = dto.Cedula,
                Licencia = dto.Licencia,
                Telefono = dto.Telefono,
                FechaContratacion = dto.FechaContratacion,
                EstadoLaboral = (Domain.Enums.Configuration.EstadoLaboral)dto.EstadoConductorId
            };

            return await _conductorRepository.AddAsync(conductor);
        }

        public async Task<bool> UpdateAsync(UpdateConductorDto dto)
        {
            var conductor = await _conductorRepository.GetByIdAsync(dto.Id);
            if (conductor == null) return false;

            conductor.Nombre = dto.Nombre;
            conductor.Apellido = dto.Apellido;
            conductor.Cedula = dto.Cedula;
            conductor.Licencia = dto.Licencia;
            conductor.Telefono = dto.Telefono;
            conductor.EstadoLaboral = (Domain.Enums.Configuration.EstadoLaboral)dto.EstadoConductorId;

            return await _conductorRepository.UpdateAsync(conductor);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var conductor = await _conductorRepository.GetByIdAsync(id);
            if (conductor == null) return false;

            return await _conductorRepository.DeleteAsync(conductor);
        }
    }
}