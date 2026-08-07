namespace SGA.Application.Dtos.RegistroAcceso
{
    public class ResultadoValidacionAccesoDto
    {
        public bool Permitido { get; set; }

        public string Mensaje { get; set; } = string.Empty;

        public string Nombre { get; set; } = string.Empty;

        public string Matricula { get; set; } = string.Empty;
    }
}