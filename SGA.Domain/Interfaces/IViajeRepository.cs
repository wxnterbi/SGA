using SGA.Domain.Entities.Reservation;

namespace SGA.Persistence.Interfaces
{
    public interface IViajeRepository
    {
        Task<Viaje> GetByIdAsync(int id);
        Task<IEnumerable<Viaje>> GetAllAsync();
        Task AddAsync(Viaje viaje);
        Task UpdateAsync(Viaje viaje);
        Task DeleteAsync(int id);
        Task<bool> ExisteConductorEnHorarioAsync(int conductorId, int horarioId, int viajeIdExcluir = 0);
        Task<bool> ExisteAutobusEnHorarioAsync(int autobusId, int horarioId, int viajeIdExcluir = 0);
    }
}