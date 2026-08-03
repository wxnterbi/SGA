using System.Net.Http.Json;
using SGA.Web.Models.Usuario;

namespace SGA.Web.Services.Login
{
    public class UsuarioApiService
    {
        private readonly HttpClient _httpClient;

        public UsuarioApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<UsuarioViewModel>> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<UsuarioViewModel>>("api/Usuario")
                   ?? new List<UsuarioViewModel>();
        }
    }
}
