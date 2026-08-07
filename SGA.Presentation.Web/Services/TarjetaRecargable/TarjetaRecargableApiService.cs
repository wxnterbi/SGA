using System.Net.Http.Json;
using SGA.Web.Interfaces.TarjetaRecargable;
using SGA.Web.Models.TarjetaRecargable;

namespace SGA.Web.Services.TarjetaRecargable
{
    public class TarjetaRecargableApiService : ITarjetaRecargableApiService
    {
        private readonly HttpClient _httpClient;

        public TarjetaRecargableApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<TarjetaRecargableViewModel>> GetAllAsync()
        {
            var tarjetas = await _httpClient.GetFromJsonAsync<List<TarjetaRecargableViewModel>>("api/TarjetaRecargable");

            return tarjetas ?? new List<TarjetaRecargableViewModel>();
        }

        public async Task<TarjetaRecargableViewModel?> GetByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<TarjetaRecargableViewModel>($"api/TarjetaRecargable/{id}");
        }

        public async Task<bool> CreateAsync(TarjetaRecargableViewModel tarjeta)
        {
            var response = await _httpClient.PostAsJsonAsync("api/TarjetaRecargable", tarjeta);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAsync(TarjetaRecargableViewModel tarjeta)
        {
            var response = await _httpClient.PutAsJsonAsync("api/TarjetaRecargable", tarjeta);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/TarjetaRecargable/{id}");

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> RecargarSaldoAsync(RecargarSaldoViewModel model)
        {
            var dto = new
            {
                UsuarioId = model.UsuarioId,
                Monto = model.Monto
            };

            var response = await _httpClient.PostAsJsonAsync(
                "api/TarjetaRecargable/Recargar",
                dto);

            return response.IsSuccessStatusCode;
        }
        public async Task<TarjetaRecargableViewModel?> GetByUsuarioIdAsync(int usuarioId)
        {
            return await _httpClient.GetFromJsonAsync<TarjetaRecargableViewModel>(
                $"api/TarjetaRecargable/Usuario/{usuarioId}");
        }
    }
}
