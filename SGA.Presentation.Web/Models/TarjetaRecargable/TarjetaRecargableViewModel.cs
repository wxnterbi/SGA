namespace SGA.Web.Models.TarjetaRecargable
{
    public class TarjetaRecargableViewModel
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public decimal Saldo { get; set; }

        public int Estado { get; set; }
    }
}