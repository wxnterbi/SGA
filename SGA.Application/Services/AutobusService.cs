using SGA.Application.Dtos.Autobus;
using SGA.Application.Interfaces;
using SGA.Domain.Entities.Configuration;
using SGA.Domain.Enums.Configuration;
using SGA.Infrastructure.Notifications;
using SGA.Persistence.Interfaces;

namespace SGA.Application.Services
{
    public class AutobusService : IAutobusService
    {
        private readonly IAutobusRepository _autobusRepository;
        private readonly INotificationService _notificationService;

        public AutobusService(
            IAutobusRepository autobusRepository,
            INotificationService notificationService)
        {
            _autobusRepository = autobusRepository;
            _notificationService = notificationService;
        }

        public async Task<IEnumerable<AutobusDto>> GetAllAsync()
        {
            var autobuses = await _autobusRepository.GetAllAsync();

            var dtos = autobuses.Select(a => new AutobusDto
            {
                Id = a.Id,
                Placa = a.Placa,
                Marca = a.Marca,
                Modelo = a.Modelo,
                Capacidad = a.CapacidadMaxima,
                EstadoAutobusId = (int)a.EstadoOperativo,
                EstadoDescripcion = a.EstadoOperativo.ToString()
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
                Marca = a.Marca,                            
                Modelo = a.Modelo,                           
                Capacidad = a.CapacidadMaxima,                 
                EstadoAutobusId = (int)a.EstadoOperativo,      
                EstadoDescripcion = a.EstadoOperativo.ToString()
            };

            return await Task.FromResult(dto);
        }

        public async Task AddAsync(AutobusDto dto)
        {
            var existePlaca =
                await _autobusRepository.ExistePlacaAsync(dto.Placa);


            if (existePlaca)
            {
                throw new Exception(
                    "La placa ingresada ya se encuentra registrada.");
            }
            var autobus = new Autobus
            {
                Placa = dto.Placa,
                Marca = dto.Marca,                      
                Modelo = dto.Modelo,                   
                CapacidadMaxima = dto.Capacidad,           
                EstadoOperativo = (EstadoAutobus)dto.EstadoAutobusId
            };

            _autobusRepository.Add(autobus);

            await _notificationService.SendNotificationAsync(
                "transporte@itla.edu.do",
                "Autobús registrado",
                "El autobús fue registrado correctamente.");
        }

        public async Task UpdateAsync(AutobusDto dto)
        {
            var autobus = _autobusRepository.GetById(dto.Id);
            if (autobus != null)
            {
                autobus.Placa = dto.Placa;
                autobus.Marca = dto.Marca;   
                autobus.Modelo = dto.Modelo; 
                autobus.CapacidadMaxima = dto.Capacidad;
                autobus.EstadoOperativo = (EstadoAutobus)dto.EstadoAutobusId;

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