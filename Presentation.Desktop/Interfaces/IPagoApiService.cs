using SGA.Application.Dtos.Pago;

namespace SGA.Presentation.Desktop.Interfaces
{
    public interface IPagoApiService
    {
        Task<List<PagoDto>> GetAllAsync();

        Task<PagoDto?> GetByIdAsync(int id);

        Task<List<PagoDto>> GetRecargasAsync();

        Task<List<PagoDto>> GetRecargasByUsuarioAsync(int usuarioId);
    }
}
