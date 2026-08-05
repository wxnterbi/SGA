using SGA.Application.Dtos.Viaje;
using SGA.Desktop.Interfaces.Viaje;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SGA.Desktop.Interfaces.Viaje
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
            // Se usa "viajes" en lugar de "api/viajes" porque BaseAddress ya incluye "/api/"
            var response = await _httpClient.GetFromJsonAsync<List<ViajeDto>>("viajes");
            return response ?? new List<ViajeDto>();
        }

        public async Task<ViajeDto?> GetByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<ViajeDto>($"viajes/{id}");
        }

        public async Task<bool> CreateAsync(CreateViajeDto dto)
        {
            var response = await _httpClient.PostAsJsonAsync("viajes", dto);

            if (!response.IsSuccessStatusCode)
            {
                string errorMensaje = await response.Content.ReadAsStringAsync();
                throw new InvalidOperationException(errorMensaje);
            }

            return true;
        }

        public async Task<bool> UpdateAsync(int id, UpdateViajeDto dto)
        {
            var response = await _httpClient.PutAsJsonAsync($"viajes/{id}", dto);

            if (!response.IsSuccessStatusCode)
            {
                string errorMensaje = await response.Content.ReadAsStringAsync();
                throw new InvalidOperationException(errorMensaje);
            }

            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"viajes/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}