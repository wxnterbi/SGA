namespace SGA.Web.Models.TarjetaRecargable
{
    public class TarjetaRecargableViewModel
    {
        public int Id { get; set; }

        public string IdentificadorInstitucional { get; set; } = string.Empty;
        public int UsuarioId { get; set; }

        public decimal Saldo { get; set; }

    }
}