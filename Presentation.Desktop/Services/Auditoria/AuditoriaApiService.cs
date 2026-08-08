using System.Net.Http.Json;
using SGA.Application.Dtos.Auditoria;
using SGA.Presentation.Desktop.Interfaces;

namespace SGA.Presentation.Desktop.Services
{
    public class AuditoriaApiService : IAuditoriaApiService
    {
        private readonly HttpClient _httpClient;

        public AuditoriaApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<AuditoriaDto>> GetAllAsync()
        {
            var resultado =
                await _httpClient
                    .GetFromJsonAsync<List<AuditoriaDto>>(
                        "api/Auditoria");

            return resultado ?? new List<AuditoriaDto>();
        }

        public async Task<AuditoriaDto?> GetByIdAsync(int id)
        {
            return await _httpClient
                .GetFromJsonAsync<AuditoriaDto>(
                    $"api/Auditoria/{id}");
        }
    }
}