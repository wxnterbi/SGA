using SGA.Web.Models.TarjetaRecargable;

namespace SGA.Web.Interfaces.TarjetaRecargable
{
    public interface ITarjetaRecargableApiService
    {
        Task<List<TarjetaRecargableViewModel>> GetAllAsync();

        Task<TarjetaRecargableViewModel?> GetByIdAsync(int id);

        Task<bool> CreateAsync(TarjetaRecargableViewModel tarjeta);

        Task<bool> UpdateAsync(TarjetaRecargableViewModel tarjeta);

        Task<bool> DeleteAsync(int id);
    }
}