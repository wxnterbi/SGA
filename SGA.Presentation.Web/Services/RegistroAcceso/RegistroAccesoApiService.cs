using System.Net.Http.Json;
using SGA.Web.Interfaces.RegistroAcceso;
using SGA.Web.Models.RegistroAcceso;

namespace SGA.Web.Services.RegistroAcceso
{
    public class RegistroAccesoApiService : IRegistroAccesoApiService
    {
        private readonly HttpClient _httpClient;

        public RegistroAccesoApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<RegistroAccesoViewModel>> GetAllAsync()
        {
            var registros = await _httpClient.GetFromJsonAsync<List<RegistroAccesoViewModel>>("api/RegistroAcceso");

            return registros ?? new List<RegistroAccesoViewModel>();
        }

        public async Task<RegistroAccesoViewModel?> GetByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<RegistroAccesoViewModel>($"api/RegistroAcceso/{id}");
        }

        public async Task<bool> CreateAsync(RegistroAccesoViewModel registro)
        {
            var response = await _httpClient.PostAsJsonAsync("api/RegistroAcceso", registro);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAsync(RegistroAccesoViewModel registro)
        {
            var response = await _httpClient.PutAsJsonAsync("api/RegistroAcceso", registro);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/RegistroAcceso/{id}");

            return response.IsSuccessStatusCode;
        }
    }
}
