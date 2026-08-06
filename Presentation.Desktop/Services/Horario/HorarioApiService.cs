using SGA.Application.Dtos.Horario;
using SGA.Presentation.Desktop.Interfaces;
using System.Net.Http.Json;

namespace SGA.Presentation.Desktop.Services.Horario
{
    public class HorarioApiService : IHorarioApiService
    {
        private readonly HttpClient _httpClient;


        public HorarioApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }



        public async Task<List<HorarioDto>> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<HorarioDto>>("api/Horario")
                   ?? new List<HorarioDto>();
        }



        public async Task<HorarioDto?> GetByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<HorarioDto>(
                $"api/Horario/{id}");
        }



        public async Task<bool> CreateAsync(HorarioDto horario)
        {
            var response =
                await _httpClient.PostAsJsonAsync(
                    "api/Horario",
                    horario);


            return response.IsSuccessStatusCode;
        }



        public async Task<bool> UpdateAsync(HorarioDto horario)
        {
            var response =
                await _httpClient.PutAsJsonAsync(
                    "api/Horario",
                    horario);


            return response.IsSuccessStatusCode;
        }



        public async Task<bool> DeleteAsync(int id)
        {
            var response =
                await _httpClient.DeleteAsync(
                    $"api/Horario/{id}");


            return response.IsSuccessStatusCode;
        }

    }
}