namespace SGA.Application.Dtos.Pago
{
    public class UpdatePagoDto
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public decimal Monto { get; set; }

        public DateTime FechaPago { get; set; }

        public string Modalidad { get; set; } = string.Empty;
    }
}
