namespace SGA.Application.BusinessRules
{
    public class UsuarioRules
    {
        public void ValidarUsuarioRegistrado(bool existeUsuario)
        {
            if (!existeUsuario)
                throw new InvalidOperationException(
                    "El usuario debe estar registrado para utilizar el sistema.");
        }
    }
}