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
            var autobuses = _autobusRepository.GetAll();

            var dtos = autobuses.Select(a => new AutobusDto
            {
                Id = a.Id,
                Placa = a.Placa,
                Capacidad = a.CapacidadMaxima,
                EstadoAutobusId = (int)a.EstadoOperativo
            });

            return await Task.FromResult(dtos);
        }

        public async Task<AutobusDto?> GetByIdAsync(int id)
        {
            var a = _autobusRepository.GetById(id);
            if (a == null) return null;

            var dto = new AutobusDto
            {
                Id = a.Id,
                Placa = a.Placa,
                Capacidad = a.CapacidadMaxima,
                EstadoAutobusId = (int)a.EstadoOperativo
            };

            return await Task.FromResult(dto);
        }

        public async Task AddAsync(AutobusDto dto)
        {
            var autobus = new Autobus
            {
                Placa = dto.Placa,
                CapacidadMaxima = dto.Capacidad,
                EstadoOperativo = (Domain.Enums.Configuration.EstadoAutobus)dto.EstadoAutobusId
            };

            _autobusRepository.Add(autobus);
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(AutobusDto dto)
        {
            var autobus = _autobusRepository.GetById(dto.Id);
            if (autobus != null)
            {
                autobus.Placa = dto.Placa;
                autobus.CapacidadMaxima = dto.Capacidad;
                autobus.EstadoOperativo = (Domain.Enums.Configuration.EstadoAutobus)dto.EstadoAutobusId;

                _autobusRepository.Update(autobus);
            }
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(int id)
        {
            _autobusRepository.Delete(id);
            await Task.CompletedTask;
        }
    }
}