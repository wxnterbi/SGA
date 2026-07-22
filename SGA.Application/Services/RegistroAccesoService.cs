using SGA.Application.BusinessRules;
using SGA.Application.Dtos.RegistroAcceso;
using SGA.Application.Interfaces;
using SGA.Domain.Entities.Reservation;
using SGA.Infrastructure.Notifications;
using SGA.Persistence.Interfaces;
using SGA.Persistence.Repository;

namespace SGA.Application.Services
{
    public class RegistroAccesoService : IRegistroAccesoService
    {
        private readonly IRegistroAccesoRepository _registroRepository;
        private readonly AccesoRules _accesoRules;
        private readonly INotificationService _notificationService;

        public RegistroAccesoService(
            IRegistroAccesoRepository registroRepository,
            AccesoRules accesoRules,
            INotificationService notificationService)
        {
            _registroRepository = registroRepository;
            _accesoRules = accesoRules;
            _notificationService = notificationService;
        }

        public async Task<IEnumerable<RegistroAccesoDto>> GetAllAsync()
        {
            var registros = await _registroRepository.GetAllAsync();

            return registros.Select(r => new RegistroAccesoDto
            {
                Id = r.Id,
                UsuarioId = r.UsuarioId,
                ViajeId = r.ViajeId,
                Permitido = r.Permitido,
                Motivo = r.Motivo,
                FechaHora = r.FechaHora
            });
        }

        public async Task<RegistroAccesoDto?> GetByIdAsync(int id)
        {
            var registro = await _registroRepository.GetByIdAsync(id);

            if (registro == null)
                return null;

            return new RegistroAccesoDto
            {
                Id = registro.Id,
                UsuarioId = registro.UsuarioId,
                ViajeId = registro.ViajeId,
                Permitido = registro.Permitido,
                Motivo = registro.Motivo,
                FechaHora = registro.FechaHora
            };
        }

        public async Task AddAsync(RegistroAccesoDto dto)
        {
            _accesoRules.ValidarAutorizacion(dto.Permitido);

            var registro = new RegistroAcceso
            {
                UsuarioId = dto.UsuarioId,
                ViajeId = dto.ViajeId,
                Permitido = dto.Permitido,
                Motivo = dto.Motivo,
                FechaHora = dto.FechaHora
            };

            await _registroRepository.AddAsync(registro);

            await _notificationService.SendNotificationAsync(
                 "estudiante@itla.edu.do",
                 "Acceso registrado",
                 "Se registró un acceso al sistema correctamente.");
        }

        public async Task UpdateAsync(RegistroAccesoDto dto)
        {

            var registro = await _registroRepository.GetByIdAsync(dto.Id);

            if (registro == null)
                throw new Exception("Registro de acceso no encontrado.");

            _accesoRules.ValidarAutorizacion(dto.Permitido);

            registro.UsuarioId = dto.UsuarioId;
            registro.ViajeId = dto.ViajeId;
            registro.Permitido = dto.Permitido;
            registro.Motivo = dto.Motivo;
            registro.FechaHora = dto.FechaHora;

            await _registroRepository.UpdateAsync(registro);
        }

        public async Task DeleteAsync(int id)
        {
            var registro = await _registroRepository.GetByIdAsync(id);

            if (registro == null)
                throw new Exception("No se encontró el registro de acceso.");

            await _registroRepository.DeleteAsync(id);
        }
    }
}
