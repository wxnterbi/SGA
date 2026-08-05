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
    }
}