using SGA.Application.Dtos.Ruta;
using SGA.Presentation.Desktop.Interfaces;
using System.Net.Http.Json;

namespace SGA.Presentation.Desktop.Services.Ruta
{
    public class RutaApiService : IRutaApiService
    {
        private readonly HttpClient _httpClient;

        public RutaApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<List<RutaDto>> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<RutaDto>>("api/Ruta")
                   ?? new List<RutaDto>();
        }


        public async Task<RutaDto?> GetByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<RutaDto>($"api/Ruta/{id}");
        }
        public async Task<bool> CreateAsync(RutaDto ruta)
        {
            var response =
                await _httpClient.PostAsJsonAsync(
                    "api/Ruta",
                    ruta);

            return response.IsSuccessStatusCode;
        }



        public async Task<bool> UpdateAsync(RutaDto ruta)
        {
            var response =
                await _httpClient.PutAsJsonAsync(
                    "api/Ruta",
                    ruta);

            return response.IsSuccessStatusCode;
        }



        public async Task<bool> DeleteAsync(int id)
        {
            var response =
                await _httpClient.DeleteAsync(
                    $"api/Ruta/{id}");

            return response.IsSuccessStatusCode;
        }
    }
}