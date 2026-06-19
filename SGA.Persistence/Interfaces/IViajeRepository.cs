namespace SGA.Persistence.Interfaces
{
    public interface IViajeRepository
    {
        Task<Viaje> GetByIdAsync(int id);
        Task<IEnumerable<Viaje>> GetAllAsync();
        Task AddAsync(Viaje viaje);
        Task UpdateAsync(Viaje viaje);
        Task DeleteAsync(int id);
    }
}