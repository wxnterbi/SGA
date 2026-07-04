namespace SGA.Application.Dtos.RegistroAcceso
{
    public class UpdateRegistroAccesoDto
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int ViajeId { get; set; }
        public bool Permitido { get; set; }
        public string Motivo { get; set; }
        public DateTime FechaHora { get; set; }
    }
}