namespace SGA.Application.Dtos.Horario
{
    public class CreateHorarioDto
    {
        public string DiasOperacion { get; set; } = string.Empty;

        public TimeSpan HoraSalida { get; set; }

        public int RutaId { get; set; }
    }
}
