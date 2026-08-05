using SGA.Application.Dtos.Viaje;
using SGA.Presentation.Desktop.Interfaces;
using SGA.Presentation.Desktop.Models;
using System.Net.Http.Json;

namespace SGA.Presentation.Desktop.Services.Viaje
{
    public class ViajeApiService : IViajeApiService
    {
        private readonly HttpClient _httpClient;

        public ViajeApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ViajeDto>> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<ViajeDto>>("api/Viaje")
                   ?? new List<ViajeDto>();
        }

        public async Task<ViajeDto?> GetByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<ViajeDto>($"api/Viaje/{id}");
        }

        public async Task<ApiResponse> CreateAsync(ViajeDto viaje)
        {
            var response = await _httpClient.PostAsJsonAsync(
                "api/Viaje",
                viaje);


            if (response.IsSuccessStatusCode)
            {
                return new ApiResponse
                {
                    Success = true,
                    Message = "Viaje registrado correctamente."
                };
            }


            var error = await response.Content.ReadFromJsonAsync<ApiResponse>();


            return new ApiResponse
            {
                Success = false,
                Message = error?.Message
                    ?? "No fue posible registrar el viaje."
            };
        }

        public async Task<bool> UpdateAsync(ViajeDto viaje)
        {
            var response = await _httpClient.PutAsJsonAsync("api/Viaje", viaje);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/Viaje/{id}");

            return response.IsSuccessStatusCode;
        }
    }
}