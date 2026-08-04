using SGA.Application.Dtos.Viaje;
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
            try
            {
                var response = await _httpClient.GetFromJsonAsync<List<ViajeDto>>("api/viajes");
                return response ?? new List<ViajeDto>();
            }
            catch
            {
                return new List<ViajeDto>();
            }
        }

        public async Task<ViajeDto?> GetByIdAsync(int id)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<ViajeDto>($"api/viajes/{id}");
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> CreateAsync(CreateViajeDto dto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/viajes", dto);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAsync(int id, UpdateViajeDto dto)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/viajes/{id}", dto);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/viajes/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}