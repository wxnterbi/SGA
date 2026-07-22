namespace SGA.Application.Dtos.Parada
{
    public class UpdateParadaDto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Ubicacion { get; set; }

        public int Orden { get; set; }
    }
}