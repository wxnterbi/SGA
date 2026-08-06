using SGA.Application.Dtos.Horario;
using SGA.Application.Interfaces;
using SGA.Domain.Entities.Configuration;
using SGA.Infrastructure.Notifications;
using SGA.Persistence.Interfaces;

namespace SGA.Application.Services
{
    public class HorarioService : IHorarioService
    {
        private readonly IHorarioRepository _horarioRepository;
        private readonly INotificationService _notificationService;

        public HorarioService(
            IHorarioRepository horarioRepository,
            INotificationService notificationService)
        {
            _horarioRepository = horarioRepository;
            _notificationService = notificationService;
        }

        public async Task<IEnumerable<HorarioDto>> GetAllAsync()
        {
            var horarios = await _horarioRepository.GetAllAsync();

            var resultado = horarios.Select(h => new HorarioDto
            {
                Id = h.Id,
                DiasOperacion = h.DiasOperacion,
                HoraSalida = h.HoraSalida,
                RutaId = h.RutaId,

                NombreRuta = h.Ruta != null
                    ? $"{h.Ruta.Origen} - {h.Ruta.Destino}"
                    : $"Ruta #{h.RutaId}"
            });

            return await Task.FromResult(resultado);
        }

        public Task<HorarioDto?> GetByIdAsync(int id)
        {
            var horario = _horarioRepository.GetById(id);

            if (horario == null)
                return Task.FromResult<HorarioDto?>(null);

            return Task.FromResult<HorarioDto?>(new HorarioDto
            {
                Id = horario.Id,
                DiasOperacion = horario.DiasOperacion,
                HoraSalida = horario.HoraSalida,
                RutaId = horario.RutaId,

                NombreRuta = horario.Ruta != null
                    ? $"{horario.Ruta.Origen} - {horario.Ruta.Destino}"
                    : $"Ruta #{horario.RutaId}"
            });
        }

        public async Task AddAsync(HorarioDto dto)
        {
            var horario = new Horario
            {
                DiasOperacion = dto.DiasOperacion,
                HoraSalida = dto.HoraSalida,
                RutaId = dto.RutaId
            };

            _horarioRepository.Add(horario);

            await _notificationService.SendNotificationAsync(
                "estudiante@itla.edu.do",
                "Horario registrado",
                "Se registró un nuevo horario correctamente.");
        }

        public Task UpdateAsync(HorarioDto dto)
        {
            var horario = _horarioRepository.GetById(dto.Id);

            if (horario == null)
                throw new InvalidOperationException("Horario no encontrado.");

            horario.DiasOperacion = dto.DiasOperacion;
            horario.HoraSalida = dto.HoraSalida;
            horario.RutaId = dto.RutaId;

            _horarioRepository.Update(horario);

            return Task.CompletedTask;
        }

        public Task DeleteAsync(int id)
        {
            var eliminado = _horarioRepository.Delete(id);

            if (!eliminado)
                throw new InvalidOperationException("Horario no encontrado.");

            return Task.CompletedTask;
        }
    }
}