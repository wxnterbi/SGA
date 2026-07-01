using SGA.Application.Dtos.Horario;
using SGA.Application.Interfaces;
using SGA.Domain.Entities.Configuration;
using SGA.Persistence.Interfaces;

namespace SGA.Application.Services
{
    public class HorarioService : IHorarioService
    {
        private readonly IHorarioRepository _horarioRepository;

        public HorarioService(IHorarioRepository horarioRepository)
        {
            _horarioRepository = horarioRepository;
        }

        public Task<IEnumerable<HorarioDto>> GetAllAsync()
        {
            var horarios = _horarioRepository.GetAll();

            var resultado = horarios.Select(h => new HorarioDto
            {
                Id = h.Id,
                DiasOperacion = h.DiasOperacion,
                HoraSalida = h.HoraSalida,
                RutaId = h.RutaId
            });

            return Task.FromResult(resultado);
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
                RutaId = horario.RutaId
            });
        }

        public Task AddAsync(HorarioDto dto)
        {
            var horario = new Horario
            {
                DiasOperacion = dto.DiasOperacion,
                HoraSalida = dto.HoraSalida,
                RutaId = dto.RutaId
            };

            _horarioRepository.Add(horario);

            return Task.CompletedTask;
        }

        public Task UpdateAsync(HorarioDto dto)
        {
            var horario = _horarioRepository.GetById(dto.Id);

            if (horario == null)
                throw new Exception("Horario no encontrado.");

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
                throw new Exception("Horario no encontrado.");

            return Task.CompletedTask;
        }
    }
}
