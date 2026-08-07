using System.Net.Http.Json;
using SGA.Web.Interfaces.TicketMensual;
using SGA.Web.Models.TicketMensual;

namespace SGA.Web.Services.TicketMensual
{
    public class TicketMensualApiService : ITicketMensualApiService
    {
        private readonly HttpClient _httpClient;

        public TicketMensualApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<TicketMensualViewModel>> GetAllAsync()
        {
            var tickets = await _httpClient.GetFromJsonAsync<List<TicketMensualViewModel>>("api/TicketMensual");

            return tickets ?? new List<TicketMensualViewModel>();
        }

        public async Task<TicketMensualViewModel?> GetByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<TicketMensualViewModel>($"api/TicketMensual/{id}");
        }

        public async Task<bool> CreateAsync(TicketMensualViewModel ticket)
        {
            var response = await _httpClient.PostAsJsonAsync("api/TicketMensual", ticket);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAsync(TicketMensualViewModel ticket)
        {
            var response = await _httpClient.PutAsJsonAsync("api/TicketMensual", ticket);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/TicketMensual/{id}");

            return response.IsSuccessStatusCode;
        }
    }
}
