using SGA.Domain.Entities.Reservation;

namespace SGA.Persistence.Interfaces
{
    public interface ITarjetaRecargableRepository
    {
        Task<TarjetaRecargable> GetByIdAsync(int id);
        Task<IEnumerable<TarjetaRecargable>> GetAllAsync();
        Task<TarjetaRecargable> GetByUsuarioIdAsync(int usuarioId);
        Task AddAsync(TarjetaRecargable tarjeta);
        Task UpdateAsync(TarjetaRecargable tarjeta);
        Task DeleteAsync(int id);
    }
}