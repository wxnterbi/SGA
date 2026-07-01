namespace SGA.Application.Dtos.Pago
{
    public class CreatePagoDto
    {
        public int UsuarioId { get; set; }

        public decimal Monto { get; set; }

        public DateTime FechaPago { get; set; }

        public string Modalidad { get; set; } = string.Empty;
    }
}
