using SGA.Application.Dtos.RegistroAcceso;
using SGA.Presentation.Desktop.Interfaces;
using System.Net.Http.Json;

namespace SGA.Presentation.Desktop.Services
{
    public class RegistroAccesoApiService : IRegistroAccesoApiService
    {
        private readonly HttpClient _httpClient;

        public RegistroAccesoApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<RegistroAccesoDto>> GetAllAsync()
        {
            return await _httpClient
                .GetFromJsonAsync<List<RegistroAccesoDto>>(
                    "api/RegistroAcceso")
                ?? new List<RegistroAccesoDto>();
        }

        public async Task<RegistroAccesoDto?> GetByIdAsync(int id)
        {
            return await _httpClient
                .GetFromJsonAsync<RegistroAccesoDto>(
                    $"api/RegistroAcceso/{id}");
        }

        public async Task<List<RegistroAccesoDto>> GetByUsuarioIdAsync(
            int usuarioId)
        {
            return await _httpClient
                .GetFromJsonAsync<List<RegistroAccesoDto>>(
                    $"api/RegistroAcceso/Usuario/{usuarioId}")
                ?? new List<RegistroAccesoDto>();
        }

        public async Task<bool> CreateAsync(
            CreateRegistroAccesoDto dto)
        {
            var response = await _httpClient.PostAsJsonAsync(
                "api/RegistroAcceso",
                dto);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAsync(
            UpdateRegistroAccesoDto dto)
        {
            var response = await _httpClient.PutAsJsonAsync(
                "api/RegistroAcceso",
                dto);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync(
                $"api/RegistroAcceso/{id}");

            return response.IsSuccessStatusCode;
        }

        public async Task<ResultadoAccesoDto?> ValidarMatriculaAsync(
     string matricula,
     int viajeId)
        {
            var dto = new ValidarMatriculaDto
            {
                Matricula = matricula,
                ViajeId = viajeId
            };

            var response = await _httpClient.PostAsJsonAsync(
                "api/RegistroAcceso/ValidarMatricula",
                dto);

            response.EnsureSuccessStatusCode();

            return await response.Content
                .ReadFromJsonAsync<ResultadoAccesoDto>();
        }
    }
}
