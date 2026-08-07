using SGA.Application.Dtos.Pago;
using SGA.Presentation.Desktop.Interfaces;
using System.Net.Http.Json;
using System.Linq;

public class PagoApiService : IPagoApiService
{
    private readonly HttpClient _httpClient;

    public PagoApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<PagoDto>> GetAllAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<PagoDto>>(
            "api/Pago")
            ?? new List<PagoDto>();
    }

    public async Task<PagoDto?> GetByIdAsync(int id)
    {
        return await _httpClient.GetFromJsonAsync<PagoDto>(
            $"api/Pago/{id}");
    }

    public async Task<List<PagoDto>> GetRecargasAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<PagoDto>>(
            "api/Pago/Recargas")
            ?? new List<PagoDto>();
    }

    public async Task<List<PagoDto>> GetRecargasByUsuarioAsync(int usuarioId)
    {
        var recargas = await _httpClient.GetFromJsonAsync<List<PagoDto>>(
            "api/Pago/Recargas")
            ?? new List<PagoDto>();

        return recargas
            .Where(p => p.UsuarioId == usuarioId)
            .OrderByDescending(p => p.FechaPago)
            .ToList();
    }
}
