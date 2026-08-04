using SGA.Application.Dtos.Autobus;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGA.Desktop.Interfaces.Autobus
{
    public interface IAutobusApiService
    {
        Task<List<AutobusDto>> GetAllAsync();
        Task<AutobusDto> GetByIdAsync(int id);
        Task<bool> CreateAsync(CreateAutobusDto createDto);
        Task<bool> UpdateAsync(int id, UpdateAutobusDto updateDto);
        Task<bool> DeleteAsync(int id);
    }
}