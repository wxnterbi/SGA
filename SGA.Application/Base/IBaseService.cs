namespace SGA.Application.Base
{
    public interface IBaseService<T>
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T?> GetByIdAsync(int id);

        Task AddAsync(T dto);

        Task UpdateAsync(T dto);

        Task DeleteAsync(int id);
    }
}
