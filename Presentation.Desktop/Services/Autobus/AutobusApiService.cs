using SGA.Application.Dtos.Autobus;
using SGA.Presentation.Desktop.Interfaces;
using SGA.Presentation.Desktop.Models;
using System.Net.Http.Json;

namespace SGA.Presentation.Desktop.Services.Autobus
{
    public class AutobusApiService : IAutobusApiService
    {

        private readonly HttpClient _httpClient;


        public AutobusApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }



        public async Task<List<AutobusDto>> GetAllAsync()
        {
            return await _httpClient
                .GetFromJsonAsync<List<AutobusDto>>("api/Autobus")
                ?? new List<AutobusDto>();
        }



        public async Task<AutobusDto?> GetByIdAsync(int id)
        {
            return await _httpClient
                .GetFromJsonAsync<AutobusDto>(
                    $"api/Autobus/{id}");
        }



        public async Task<ApiResponse> CreateAsync(AutobusDto autobus)
        {
            var response = await _httpClient.PostAsJsonAsync(
                "api/Autobus",
                autobus);

            if (response.IsSuccessStatusCode)
            {
                return new ApiResponse
                {
                    Success = true,
                    Message = "Autobús registrado correctamente."
                };
            }

            var contenido = await response.Content.ReadAsStringAsync();

            string mensaje = "No fue posible registrar el autobús.";

            try
            {
                using var json = System.Text.Json.JsonDocument.Parse(contenido);

                if (json.RootElement.TryGetProperty("errors", out var errors))
                {
                    var primerError = errors.EnumerateObject().FirstOrDefault();

                    if (primerError.Value.ValueKind ==
                        System.Text.Json.JsonValueKind.Array)
                    {
                        mensaje = primerError.Value[0].GetString() ?? mensaje;
                    }
                }
                else if (json.RootElement.TryGetProperty("message", out var msg))
                {
                    mensaje = msg.GetString() ?? mensaje;
                }
            }
            catch
            {
            
            }

            return new ApiResponse
            {
                Success = false,
                Message = mensaje
            };
        }

        public async Task<ApiResponse> UpdateAsync(AutobusDto autobus)
        {
            var response =
                await _httpClient.PutAsJsonAsync(
                    "api/Autobus",
                    autobus);


            return new ApiResponse
            {
                Success = response.IsSuccessStatusCode,

                Message = response.IsSuccessStatusCode
                    ? "Autobús actualizado correctamente."
                    : "No fue posible actualizar el autobús."
            };
        }



        public async Task<ApiResponse> DeleteAsync(int id)
        {
            var response =
                await _httpClient.DeleteAsync(
                    $"api/Autobus/{id}");


            return new ApiResponse
            {
                Success = response.IsSuccessStatusCode,

                Message = response.IsSuccessStatusCode
                    ? "Autobús eliminado correctamente."
                    : "No fue posible eliminar el autobús."
            };
        }

    }
}