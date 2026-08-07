using Microsoft.Extensions.Configuration;
using SGA.Web.Interfaces.Pago;
using SGA.Web.Models.Pago;
using System.Net.Http.Json;
using System.Text.Json;
using System.Linq;

namespace SGA.Web.Services.Pago
{
    public class PagoApiService : IPagoApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public PagoApiService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
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
        public async Task<HttpResponseMessage> ComprarTicketAsync(
            ComprarTicketViewModel model)
        {
            return await _httpClient.PostAsJsonAsync(
                "api/Pago/ComprarTicket",
                model);
        }
        public async Task<List<RutaCompraViewModel>> GetRutasAsync()
        {
            var url = $"{_configuration["ApiSettings:DesktopApiUrl"]}api/Ruta";

            return await _httpClient.GetFromJsonAsync<List<RutaCompraViewModel>>(url)
                   ?? new List<RutaCompraViewModel>();
        }

        public async Task<List<HorarioCompraViewModel>> GetHorariosAsync()
        {
            var url = $"{_configuration["ApiSettings:DesktopApiUrl"]}api/Horario";

            return await _httpClient.GetFromJsonAsync<List<HorarioCompraViewModel>>(url)
                   ?? new List<HorarioCompraViewModel>();
        }

        public async Task<List<ParadaCompraViewModel>> GetParadasAsync()
        {
            var url = $"{_configuration["ApiSettings:DesktopApiUrl"]}api/Parada";

            return await _httpClient.GetFromJsonAsync<List<ParadaCompraViewModel>>(url)
                   ?? new List<ParadaCompraViewModel>();
        }
    }
}
