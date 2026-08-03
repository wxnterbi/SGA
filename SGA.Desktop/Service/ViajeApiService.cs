using SGA.Application.Dtos;
using SGA.Application.Dtos.Viaje;
using SGA.Application.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGA.Desktop.Services
{
    public class ViajeApiService : IViajeService
    {
        private readonly ApiClient _apiClient;

        public ViajeApiService()
        {
            _apiClient = new ApiClient();
        }

        public async Task<IEnumerable<ViajeDto>> GetAllAsync()
        {
            var result = await _apiClient.GetAsync<List<ViajeDto>>("Viaje");
            return result ?? new List<ViajeDto>();
        }

        public async Task<ViajeDto?> GetByIdAsync(int id)
        {
            return await _apiClient.GetAsync<ViajeDto>($"Viaje/{id}");
        }

        // Retorna Task (void asíncrono) para cumplir con IBaseService
        public async Task AddAsync(ViajeDto dto)
        {
            await _apiClient.PostAsync<ViajeDto, ViajeDto>("Viaje", dto);
        }

        // Retorna Task para cumplir con IBaseService
        public async Task UpdateAsync(ViajeDto dto)
        {
            await _apiClient.PostAsync<ViajeDto, ViajeDto>("Viaje", dto);
        }

        // Retorna Task para cumplir con IBaseService
        public async Task DeleteAsync(int id)
        {
            // Petición DELETE cuando la implementes en ApiClient
            await Task.CompletedTask;
        }
    }
}