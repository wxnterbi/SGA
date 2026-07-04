namespace SGA.Application.Dtos.TarjetaRecargable
{
    public class TarjetaRecargableDto
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public decimal Saldo { get; set; }

        public int Estado { get; set; }
    }
}
