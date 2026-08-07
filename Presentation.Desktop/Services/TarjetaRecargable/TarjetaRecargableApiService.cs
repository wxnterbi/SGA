using System.Net.Http.Json;
using SGA.Application.Dtos.TarjetaRecargable;

public class TarjetaRecargableApiService : ITarjetaRecargableApiService
{
    private readonly HttpClient _httpClient;

    public TarjetaRecargableApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<TarjetaRecargableDto?> GetByMatriculaAsync(string matricula)
    {
        var response = await _httpClient.GetAsync(
            $"https://localhost:7264/api/TarjetaRecargable/Matricula/{matricula}");

        if (!response.IsSuccessStatusCode)
            return null;

        return await response.Content.ReadFromJsonAsync<TarjetaRecargableDto>();
    }
    public async Task<bool> RecargarSaldoAsync(RecargarSaldoDto dto)
    {
        var response = await _httpClient.PostAsJsonAsync(
            "https://localhost:7264/api/TarjetaRecargable/Recargar",
            dto);

        return response.IsSuccessStatusCode;
      }
   }

