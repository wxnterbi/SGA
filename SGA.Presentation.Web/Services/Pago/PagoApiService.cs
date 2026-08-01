using System.Net.Http.Json;
using SGA.Web.Interfaces.Pago;
using SGA.Web.Models.Pago;

namespace SGA.Web.Services.Pago
{
    public class PagoApiService : IPagoApiService
    {
        private readonly HttpClient _httpClient;

        public PagoApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<PagoViewModel>> GetAllAsync()
        {
            var pagos = await _httpClient.GetFromJsonAsync<List<PagoViewModel>>("api/Pago");

            return pagos ?? new List<PagoViewModel>();
        }

        public async Task<PagoViewModel?> GetByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<PagoViewModel>($"api/Pago/{id}");
        }

        public async Task<bool> CreateAsync(PagoViewModel pago)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Pago", pago);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAsync(PagoViewModel pago)
        {
            var response = await _httpClient.PutAsJsonAsync("api/Pago", pago);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/Pago/{id}");

            return response.IsSuccessStatusCode;
        }
    }
}
