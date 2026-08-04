using SGA.Application.Dtos.Autobus;
using SGA.Desktop.Interfaces.Autobus;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SGA.Desktop.Services.Autobus
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
            var response = await _httpClient.GetFromJsonAsync<List<AutobusDto>>("api/autobuses");
            return response ?? new List<AutobusDto>();
        }

        public async Task<AutobusDto> GetByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<AutobusDto>($"api/autobuses/{id}");
        }

        public async Task<bool> CreateAsync(CreateAutobusDto createDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/autobuses", createDto);

            if (!response.IsSuccessStatusCode)
            {
                // Leer mensaje de error enviado por FluentValidation desde la API
                string errorMensaje = await response.Content.ReadAsStringAsync();
                throw new InvalidOperationException(errorMensaje);
            }

            return true;
        }

        public async Task<bool> UpdateAsync(int id, UpdateAutobusDto updateDto)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/autobuses/{id}", updateDto);

            if (!response.IsSuccessStatusCode)
            {
                string errorMensaje = await response.Content.ReadAsStringAsync();
                throw new InvalidOperationException(errorMensaje);
            }

            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/autobuses/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}