namespace SGA.Application.Dtos.Horario
{
    public class UpdateHorarioDto
    {
        public int Id { get; set; }

        public string DiasOperacion { get; set; } = string.Empty;

        public TimeSpan HoraSalida { get; set; }

        public int RutaId { get; set; }
    }
}
