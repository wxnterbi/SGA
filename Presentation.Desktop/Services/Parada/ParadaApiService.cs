using SGA.Application.Dtos.Parada;
using SGA.Presentation.Desktop.Interfaces;
using System.Net.Http.Json;

namespace SGA.Presentation.Desktop.Services.Parada
{
    public class ParadaApiService : IParadaApiService
    {
        private readonly HttpClient _httpClient;

        public ParadaApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ParadaDto>> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<ParadaDto>>("api/Parada")
                ?? new List<ParadaDto>();
        }

        public async Task<ParadaDto?> GetByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<ParadaDto>($"api/Parada/{id}");
        }

        public async Task<bool> CreateAsync(CreateParadaDto parada)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Parada", parada);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAsync(UpdateParadaDto parada)
        {
            var response = await _httpClient.PutAsJsonAsync("api/Parada", parada);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/Parada/{id}");

            return response.IsSuccessStatusCode;
        }
    }
}