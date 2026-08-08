using SGA.Application.Dtos.Incidencia;
using SGA.Presentation.Desktop.Interfaces;
using System.Net.Http.Json;
using System.Text.Json;

namespace SGA.Presentation.Desktop.Services.Incidencia
{
    public class IncidenciaApiService : IIncidenciaApiService
    {
        private readonly HttpClient _httpClient;

        public IncidenciaApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<IncidenciaDto>> GetAllAsync()
        {
            return await _httpClient
                .GetFromJsonAsync<List<IncidenciaDto>>(
                    "api/Incidencia")
                ?? new List<IncidenciaDto>();
        }

        public async Task<IncidenciaDto?> GetByIdAsync(int id)
        {
            return await _httpClient
                .GetFromJsonAsync<IncidenciaDto>(
                    $"api/Incidencia/{id}");
        }

        public async Task<(bool Success, string Message)> CreateAsync(
            IncidenciaDto incidencia)
        {
            var response = await _httpClient.PostAsJsonAsync(
                "api/Incidencia",
                incidencia);

            var message = await ObtenerMensajeAsync(response);

            return (
                response.IsSuccessStatusCode,
                message
            );
        }

        public async Task<(bool Success, string Message)> UpdateAsync(
            IncidenciaDto incidencia)
        {
            var response = await _httpClient.PutAsJsonAsync(
                "api/Incidencia",
                incidencia);

            var message = await ObtenerMensajeAsync(response);

            return (
                response.IsSuccessStatusCode,
                message
            );
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync(
                $"api/Incidencia/{id}");

            return response.IsSuccessStatusCode;
        }

        private async Task<string> ObtenerMensajeAsync(
            HttpResponseMessage response)
        {
            var contenido =
                await response.Content.ReadAsStringAsync();

            if (string.IsNullOrWhiteSpace(contenido))
            {
                return response.IsSuccessStatusCode
                    ? "Operación realizada correctamente."
                    : "Ocurrió un error al procesar la solicitud.";
            }

            try
            {
                using var json =
                    JsonDocument.Parse(contenido);

                var root = json.RootElement;

                if (root.TryGetProperty(
                    "message",
                    out var messageProperty))
                {
                    var mensaje = messageProperty.GetString();

                    if (!string.IsNullOrWhiteSpace(mensaje))
                        return mensaje;
                }

                if (root.TryGetProperty(
                    "errors",
                    out var errorsProperty))
                {
                    foreach (var error in errorsProperty.EnumerateObject())
                    {
                        if (error.Value.ValueKind ==
                            JsonValueKind.Array)
                        {
                            foreach (var mensaje in
                                     error.Value.EnumerateArray())
                            {
                                if (mensaje.ValueKind ==
                                    JsonValueKind.String)
                                {
                                    var texto =
                                        mensaje.GetString();

                                    if (!string.IsNullOrWhiteSpace(texto))
                                        return texto;
                                }
                            }
                        }
                    }
                }


                if (root.TryGetProperty(
                    "detail",
                    out var detailProperty))
                {
                    var detalle =
                        detailProperty.GetString();

                    if (!string.IsNullOrWhiteSpace(detalle))
                        return detalle;
                }


                if (root.TryGetProperty(
                    "title",
                    out var titleProperty))
                {
                    var titulo =
                        titleProperty.GetString();

                    if (!string.IsNullOrWhiteSpace(titulo))
                        return titulo;
                }
            }
            catch (JsonException)
            {

            }


            return contenido;
        }
    }
}
