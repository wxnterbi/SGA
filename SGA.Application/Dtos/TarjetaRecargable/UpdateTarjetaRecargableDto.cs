namespace SGA.Application.Dtos.TarjetaRecargable
{
    public class UpdateTarjetaRecargableDto
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public decimal Saldo { get; set; }

        public int Estado { get; set; }
    }
}
