using System.Net.Http.Json;
using SGA.Web.Interfaces.Notificacion;
using SGA.Web.Models.Notificacion;

namespace SGA.Web.Services.Notificacion
{
    public class NotificacionApiService : INotificacionApiService
    {
        private readonly HttpClient _httpClient;

        public NotificacionApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<NotificacionViewModel>> GetAllAsync()
        {
            var notificaciones = await _httpClient.GetFromJsonAsync<List<NotificacionViewModel>>("api/Notificacion");

            return notificaciones ?? new List<NotificacionViewModel>();
        }

        public async Task<NotificacionViewModel?> GetByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<NotificacionViewModel>($"api/Notificacion/{id}");
        }

        public async Task<bool> CreateAsync(NotificacionViewModel notificacion)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Notificacion", notificacion);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAsync(NotificacionViewModel notificacion)
        {
            var response = await _httpClient.PutAsJsonAsync("api/Notificacion", notificacion);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/Notificacion/{id}");

            return response.IsSuccessStatusCode;
        }
    }
}
