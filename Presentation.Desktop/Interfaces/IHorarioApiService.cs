using SGA.Application.Dtos.Horario;

namespace SGA.Presentation.Desktop.Interfaces
{
    public interface IHorarioApiService
    {
        Task<List<HorarioDto>> GetAllAsync();

        Task<HorarioDto?> GetByIdAsync(int id);

        Task<bool> CreateAsync(HorarioDto horario);

        Task<bool> UpdateAsync(HorarioDto horario);

        Task<bool> DeleteAsync(int id);
    }
}