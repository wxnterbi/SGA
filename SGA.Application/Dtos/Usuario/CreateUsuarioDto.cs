using SGA.Domain.Enums.Configuration;

namespace SGA.Application.Dtos.Usuario
{
    public class CreateUsuarioDto
    {
        public string IdentificadorInstitucional { get; set; } = string.Empty;

        public string Nombre { get; set; } = string.Empty;

        public TipoUsuario TipoUsuario { get; set; }

        public EstadoUsuario Estado { get; set; }
    }
}
