using SGA.Application.Dtos.Conductor;
using SGA.Presentation.Desktop.Interfaces;
using System.Net.Http.Json;

namespace SGA.Presentation.Desktop.Services.Conductor
{
    public class ConductorApiService : IConductorApiService
    {
        private readonly HttpClient _httpClient;

        public ConductorApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ConductorDto>> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<ConductorDto>>("api/Conductor")
                ?? new List<ConductorDto>();
        }

        public async Task<ConductorDto?> GetByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<ConductorDto>($"api/Conductor/{id}");
        }

        public async Task<bool> CreateAsync(ConductorDto conductor)
        {
            var response = await _httpClient.PostAsJsonAsync(
                "api/Conductor",
                conductor);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAsync(ConductorDto conductor)
        {
            var response = await _httpClient.PutAsJsonAsync(
                "api/Conductor",
                conductor);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync(
                $"api/Conductor/{id}");

            return response.IsSuccessStatusCode;
        }
    }
}