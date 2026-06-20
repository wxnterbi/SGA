using SGA.Domain.Entities.Reservation;

namespace SGA.Persistence.Interfaces
{
    public interface ITarjetaRecargableRepository
    {
        Task<TarjetaRecargable> GetByIdAsync(int id);
        Task<TarjetaRecargable> GetByUsuarioIdAsync(int usuarioId);
        Task UpdateAsync(TarjetaRecargable tarjeta);
    }
}