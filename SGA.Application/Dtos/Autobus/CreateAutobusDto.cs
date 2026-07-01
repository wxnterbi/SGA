namespace SGA.Application.Dtos.Autobus
{
    public class CreateAutobusDto
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public int Capacidad { get; set; }
        public int EstadoAutobusId { get; set; }
    }
}