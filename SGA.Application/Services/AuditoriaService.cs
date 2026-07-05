using SGA.Application.Dtos.Auditoria;
using SGA.Application.Interfaces;
using SGA.Domain.Entities.Reservation;
using SGA.Persistence.Interfaces;

namespace SGA.Application.Services
{
    public class AuditoriaService : IAuditoriaService
    {
        private readonly IAuditoriaRepository _auditoriaRepository;

        public AuditoriaService(IAuditoriaRepository auditoriaRepository)
        {
            _auditoriaRepository = auditoriaRepository;
        }

        public async Task<AuditoriaDto> GetByIdAsync(int id)
        {
            var auditorias = await _auditoriaRepository.GetAllAsync();
            var a = auditorias.FirstOrDefault(x => x.Id == id);
            if (a == null) return null;

            return new AuditoriaDto
            {
                Id = a.Id,
                Actor = a.Actor,
                TipoAccion = a.TipoAccion,
                Descripcion = a.Descripcion,
                FechaHora = a.FechaHora
            };
        }

        public async Task<IEnumerable<AuditoriaDto>> GetAllAsync()
        {
            var auditorias = await _auditoriaRepository.GetAllAsync();
            return auditorias.Select(a => new AuditoriaDto
            {
                Id = a.Id,
                Actor = a.Actor,
                TipoAccion = a.TipoAccion,
                Descripcion = a.Descripcion,
                FechaHora = a.FechaHora
            });
        }

        public async Task AddAsync(AuditoriaDto dto)
        {
            var auditoria = new Auditoria
            {
                Actor = dto.Actor,
                TipoAccion = dto.TipoAccion,
                Descripcion = dto.Descripcion,
                FechaHora = dto.FechaHora
            };
            await _auditoriaRepository.AddAsync(auditoria);
        }

        public Task UpdateAsync(AuditoriaDto dto)
        {
            throw new System.NotSupportedException("No está permitido modificar registros de auditoría.");
        }

        public Task DeleteAsync(int id)
        {
            throw new System.NotSupportedException("No está permitido eliminar registros de auditoría.");
        }
    }
}