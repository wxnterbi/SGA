using SGA.Application.Dtos.Horario;

namespace SGA.Presentation.Desktop.Interfaces
{
    public interface IHorarioApiService
    {
        Task<List<HorarioDto>> GetAllAsync();

        Task<HorarioDto?> GetByIdAsync(int id);
    }
}