using SGA.Application.Dtos.Autobus;
using SGA.Presentation.Desktop.Interfaces;
using System.Net.Http.Json;

namespace SGA.Presentation.Desktop.Services.Autobus
{
    public class AutobusApiService : IAutobusApiService
    {
        private readonly HttpClient _httpClient;


        public AutobusApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<List<AutobusDto>> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<AutobusDto>>("api/Autobus")
                   ?? new List<AutobusDto>();
        }


        public async Task<AutobusDto?> GetByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<AutobusDto>($"api/Autobus/{id}");
        }
    }
}