using SGA.Application.Dtos.Parada;

namespace SGA.Application.Interfaces
{
    public interface IParadaService
    {
        Task<IEnumerable<ParadaDto>> GetAllAsync();

        Task<ParadaDto?> GetByIdAsync(int id);

        Task AddAsync(CreateParadaDto dto);

        Task UpdateAsync(UpdateParadaDto dto);

        Task DeleteAsync(int id);
    }
}