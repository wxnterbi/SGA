using SGA.Web.Models.Pago;

namespace SGA.Web.Interfaces.Pago
{
    public interface IPagoApiService
    {
        Task<List<PagoViewModel>> GetAllAsync();

        Task<PagoViewModel?> GetByIdAsync(int id);

        Task<bool> CreateAsync(PagoViewModel pago);

        Task<bool> UpdateAsync(PagoViewModel pago);

        Task<bool> DeleteAsync(int id);
    }
}
