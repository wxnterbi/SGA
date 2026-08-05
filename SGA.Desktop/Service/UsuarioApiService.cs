using SGA.Application.Dtos.Usuario;
using SGA.Desktop.Interfaces;
using System.Net.Http;
using System.Net.Http.Json;

namespace SGA.Desktop.Services
{
    public class UsuarioApiService : IUsuarioApiService
    {
        private readonly HttpClient _httpClient;

        public UsuarioApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<UsuarioDto>> GetAllAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<UsuarioDto>>("usuarios");
            return response ?? new List<UsuarioDto>();
        }

        public async Task<UsuarioDto?> GetByIdAsync(int id)
        {
            MessageBox.Show($"API usada: {_httpClient.BaseAddress}");

            return await _httpClient.GetFromJsonAsync<UsuarioDto>($"usuarios/{id}");
        }

        public async Task<bool> CrearUsuarioAsync(CreateUsuarioDto dto)
        {
            var response = await _httpClient.PostAsJsonAsync("usuarios", dto);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAsync(int id, UpdateUsuarioDto dto)
        {
            var response = await _httpClient.PutAsJsonAsync($"usuarios/{id}", dto);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"usuarios/{id}");
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> RecargarTarjetaAsync(int usuarioId, decimal monto)
        {
            var response = await _httpClient.PostAsJsonAsync(
                $"usuarios/{usuarioId}/recargar",
                new { monto });

            return response.IsSuccessStatusCode;
        }
    }
}