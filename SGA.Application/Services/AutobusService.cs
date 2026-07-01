using SGA.Application.Interfaces;
using SGA.Application.Dtos.Autobus;
using SGA.Persistence.Interfaces;
using SGA.Domain.Entities.Configuration;

namespace SGA.Application.Services
{
    public class AutobusService : IAutobusService
    {
        private readonly IAutobusRepository _autobusRepository;

        public AutobusService(IAutobusRepository autobusRepository)
        {
            _autobusRepository = autobusRepository ?? throw new ArgumentNullException(nameof(autobusRepository));
        }

        public async Task<IEnumerable<AutobusDto>> GetAllAsync()
        {
            var autobuses = await _autobusRepository.GetAllAsync();
            return autobuses.Select(a => new AutobusDto
            {
                Id = a.Id,
                Placa = a.Placa,
                Modelo = a.Modelo,
                Capacidad = a.Capacidad,
                EstadoAutobusId = (int)a.EstadoAutobus
            });
        }

        public async Task<AutobusDto> GetByIdAsync(int id)
        {
            var a = await _autobusRepository.GetByIdAsync(id);
            if (a == null) return null;

            return new AutobusDto
            {
                Id = a.Id,
                Placa = a.Placa,
                Modelo = a.Modelo,
                Capacidad = a.Capacidad,
                EstadoAutobusId = (int)a.EstadoAutobus
            };
        }

        public async Task<bool> CreateAsync(CreateAutobusDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Placa))
                throw new ArgumentException("La placa es obligatoria.");

            var autobus = new Autobus
            {
                Placa = dto.Placa,
                Modelo = dto.Modelo,
                Capacidad = dto.Capacidad,
                EstadoAutobus = (Domain.Enums.Configuration.EstadoAutobus)dto.EstadoAutobusId
            };

            return await _autobusRepository.AddAsync(autobus);
        }

        public async Task<bool> UpdateAsync(UpdateAutobusDto dto)
        {
            var autobus = await _autobusRepository.GetByIdAsync(dto.Id);
            if (autobus == null) return false;

            autobus.Placa = dto.Placa;
            autobus.Modelo = dto.Modelo;
            autobus.Capacidad = dto.Capacidad;
            autobus.EstadoAutobus = (Domain.Enums.Configuration.EstadoAutobus)dto.EstadoAutobusId;

            return await _autobusRepository.UpdateAsync(autobus);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var autobus = await _autobusRepository.GetByIdAsync(id);
            if (autobus == null) return false;

            return await _autobusRepository.DeleteAsync(autobus);
        }
    }
}