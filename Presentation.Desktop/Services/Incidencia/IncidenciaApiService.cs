using SGA.Application.Dtos.Incidencia;
using SGA.Presentation.Desktop.Interfaces;
using System.Net.Http.Json;

namespace SGA.Presentation.Desktop.Services.Incidencia
{
    public class IncidenciaApiService : IIncidenciaApiService
    {
        private readonly HttpClient _httpClient;


        public IncidenciaApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }



        public async Task<List<IncidenciaDto>> GetAllAsync()
        {
            return await _httpClient
                .GetFromJsonAsync<List<IncidenciaDto>>
                ("api/Incidencia")
                ?? new List<IncidenciaDto>();
        }



        public async Task<IncidenciaDto?> GetByIdAsync(int id)
        {
            return await _httpClient
                .GetFromJsonAsync<IncidenciaDto>
                ($"api/Incidencia/{id}");
        }



        public async Task<bool> CreateAsync(
            IncidenciaDto incidencia)
        {
            var response =
                await _httpClient
                .PostAsJsonAsync(
                    "api/Incidencia",
                    incidencia);


            return response.IsSuccessStatusCode;
        }



        public async Task<bool> UpdateAsync(
            IncidenciaDto incidencia)
        {
            var response =
                await _httpClient
                .PutAsJsonAsync(
                    "api/Incidencia",
                    incidencia);


            return response.IsSuccessStatusCode;
        }



        public async Task<bool> DeleteAsync(int id)
        {
            var response =
                await _httpClient
                .DeleteAsync(
                    $"api/Incidencia/{id}");


            return response.IsSuccessStatusCode;
        }
    }
}
