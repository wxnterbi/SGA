namespace SGA.Application.Dtos.TarjetaRecargable
{
    public class TarjetaRecargableDto
    {
        public int Id { get; set; }

        public string IdentificadorInstitucional { get; set; } = string.Empty;

        public int UsuarioId { get; set; }

        public decimal Saldo { get; set; }

    }
}
