using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using SGA.Application.Dtos.Usuario;
using SGA.Desktop.Interfaces;

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
            var response = await _httpClient.GetFromJsonAsync<List<UsuarioDto>>("api/Usuario");
            return response ?? new List<UsuarioDto>();
        }

        public async Task<UsuarioDto> GetByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<UsuarioDto>($"api/Usuario/{id}");
        }

        public async Task<bool> CrearUsuarioAsync(CreateUsuarioDto dto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Usuario", dto);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> RecargarTarjetaAsync(int usuarioId, decimal monto)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/Usuario/{usuarioId}/recargar", new { Monto = monto });
            return response.IsSuccessStatusCode;
        }
    }
}