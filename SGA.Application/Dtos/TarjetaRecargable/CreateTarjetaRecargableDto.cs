namespace SGA.Application.Dtos.TarjetaRecargable
{
    public class CreateTarjetaRecargableDto
    {
        public int UsuarioId { get; set; }

        public decimal Saldo { get; set; }

        public int Estado { get; set; }
    }
}
