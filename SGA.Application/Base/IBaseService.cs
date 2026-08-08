namespace SGA.Application.Base
{
    public interface IBaseService<TDto>
    {
        Task<IEnumerable<TDto>> GetAllAsync();

        Task<TDto?> GetByIdAsync(int id);

        Task AddAsync(TDto dto);

        Task UpdateAsync(TDto dto);

        Task DeleteAsync(int id);
    }
}