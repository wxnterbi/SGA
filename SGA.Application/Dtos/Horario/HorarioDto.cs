namespace SGA.Application.Dtos.Horario
{
    public class HorarioDto
    {
        public int Id { get; set; }

        public string DiasOperacion { get; set; } = string.Empty;

        public TimeSpan HoraSalida { get; set; }

        public int RutaId { get; set; }

        public string NombreRuta { get; set; } = string.Empty;
    }
}
