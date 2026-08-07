using SGA.Application.Dtos.Usuario;
using SGA.Presentation.Desktop.Interfaces;
using System.Net.Http.Json;

namespace SGA.Presentation.Desktop.Services.Usuario
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
            return await _httpClient
                .GetFromJsonAsync<List<UsuarioDto>>("api/Usuario")
                ?? new List<UsuarioDto>();
        }

        public async Task<UsuarioDto?> GetByIdAsync(int id)
        {
            return await _httpClient
                .GetFromJsonAsync<UsuarioDto>($"api/Usuario/{id}");
        }

        public async Task<bool> CreateAsync(CreateUsuarioDto usuario)
        {
            var response =
                await _httpClient.PostAsJsonAsync("api/Usuario", usuario);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAsync(int id, UpdateUsuarioDto usuario)
        {
            var response =
                await _httpClient.PutAsJsonAsync($"api/Usuario/{id}", usuario);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response =
                await _httpClient.DeleteAsync($"api/Usuario/{id}");

            return response.IsSuccessStatusCode;
        }
        public async Task<LoginResponseDto?> LoginAsync(LoginUsuarioDto login)
        {
            var response =
                await _httpClient.PostAsJsonAsync("api/Usuario/login", login);
            if (!response.IsSuccessStatusCode)
                return null;
            return await response.Content.ReadFromJsonAsync<LoginResponseDto>();
        }
    }
}