using SGA.Domain.Enums.Configuration;

namespace SGA.Application.Dtos.Usuario
{
    public class LoginResponseDto
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public TipoUsuario TipoUsuario { get; set; }

        public EstadoUsuario Estado { get; set; }
    }
}