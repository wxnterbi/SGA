namespace SGA.Application.Dtos.RegistroAcceso
{
    public class RegistroAccesoDto
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Matricula { get; set; } = string.Empty;
        public int ViajeId { get; set; }
        public bool Permitido { get; set; }
        public string Motivo { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
