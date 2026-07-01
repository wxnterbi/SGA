namespace SGA.Application.Dtos.Autobus
{
    public class UpdateAutobusDto
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public int Capacidad { get; set; }
        public int EstadoAutobusId { get; set; }
    }
}