namespace SGA.Application.Dtos.RegistroAcceso
{
    public class ResultadoAccesoDto
    {
        public bool Permitido { get; set; }

        public string Matricula { get; set; } = string.Empty;

        public string Nombre { get; set; } = string.Empty;

        public string Mensaje { get; set; } = string.Empty;
    }
}