using SGA.Application.BusinessRules;
using SGA.Application.Dtos.Notificacion;
using SGA.Application.Dtos.RegistroAcceso;
using SGA.Application.Interfaces;
using SGA.Domain.Entities.Reservation;
using SGA.Domain.Enums.Reservation;
using SGA.Infrastructure.Notifications;
using SGA.Persistence.Interfaces;

namespace SGA.Application.Services
{
    public class RegistroAccesoService : IRegistroAccesoService
    {
        private readonly IRegistroAccesoRepository _registroRepository;
        private readonly AccesoRules _accesoRules;
        private readonly INotificationService _notificationService;
        private readonly ITicketMensualRepository _ticketRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly INotificacionService _notificacionService;

        public RegistroAccesoService(
            IRegistroAccesoRepository registroRepository,
            AccesoRules accesoRules,
            INotificationService notificationService,
            ITicketMensualRepository ticketRepository,
            IUsuarioRepository usuarioRepository,
            INotificacionService notificacionService)
        {
            _registroRepository = registroRepository;
            _accesoRules = accesoRules;
            _notificationService = notificationService;
            _ticketRepository = ticketRepository;
            _usuarioRepository = usuarioRepository;
            _notificacionService = notificacionService;
        }


        public async Task<IEnumerable<RegistroAccesoDto>> GetAllAsync()
        {
            var registros = await _registroRepository.GetAllAsync();

            return registros.Select(r =>
            {
                var usuario = _usuarioRepository.GetById(r.UsuarioId);

                return new RegistroAccesoDto
                {
                    Id = r.Id,
                    UsuarioId = r.UsuarioId,
                    Matricula = usuario?.IdentificadorInstitucional ?? "",
                    ViajeId = r.ViajeId,
                    Permitido = r.Permitido,
                    Motivo = r.Motivo,
                    FechaHora = r.FechaHora
                };
            });
        }


        public async Task<RegistroAccesoDto?> GetByIdAsync(int id)
        {
            var registro = await _registroRepository.GetByIdAsync(id);

            if (registro == null)
                return null;

            var usuario = _usuarioRepository.GetById(registro.UsuarioId);

            return new RegistroAccesoDto
            {
                Id = registro.Id,
                UsuarioId = registro.UsuarioId,
                Matricula = usuario?.IdentificadorInstitucional ?? "",
                ViajeId = registro.ViajeId,
                Permitido = registro.Permitido,
                Motivo = registro.Motivo,
                FechaHora = registro.FechaHora
            };
        }


        public async Task<IEnumerable<RegistroAccesoDto>> GetByUsuarioIdAsync(int usuarioId)
        {
            var registros = await _registroRepository
                .GetByUsuarioIdAsync(usuarioId);

            var usuario = _usuarioRepository.GetById(usuarioId);

            return registros.Select(r => new RegistroAccesoDto
            {
                Id = r.Id,
                UsuarioId = r.UsuarioId,
                Matricula = usuario?.IdentificadorInstitucional ?? "",
                ViajeId = r.ViajeId,
                Permitido = r.Permitido,
                Motivo = r.Motivo,
                FechaHora = r.FechaHora
            });
        }


        public async Task<ResultadoValidacionAccesoDto> ValidarAccesoAsync(
            ValidarAccesoDto dto)
        {
            return await ValidarPorMatriculaAsync(dto.Matricula);
        }


        public async Task<ResultadoValidacionAccesoDto> ValidarPorMatriculaAsync(
            string matricula)
        {
            if (string.IsNullOrWhiteSpace(matricula))
            {
                return new ResultadoValidacionAccesoDto
                {
                    Permitido = false,
                    Matricula = "",
                    Nombre = "",
                    Mensaje = "Debe ingresar una matrícula."
                };
            }

            var usuario = _usuarioRepository.GetByIdentificador(matricula);

            if (usuario == null)
            {
                return new ResultadoValidacionAccesoDto
                {
                    Permitido = false,
                    Matricula = matricula,
                    Nombre = "",
                    Mensaje = "No se encontró un usuario con esta matrícula."
                };
            }

            var ticket = await _ticketRepository
                .GetActivoByUsuarioAsync(usuario.Id);

            if (ticket == null)
            {
                return new ResultadoValidacionAccesoDto
                {
                    Permitido = false,
                    Matricula = usuario.IdentificadorInstitucional,
                    Nombre = usuario.Nombre,
                    Mensaje = "Acceso denegado. El usuario no posee un ticket mensual activo."
                };
            }

            return new ResultadoValidacionAccesoDto
            {
                Permitido = true,
                Matricula = usuario.IdentificadorInstitucional,
                Nombre = usuario.Nombre,
                Mensaje = "Acceso permitido. El usuario posee un ticket mensual activo."
            };
        }


        public async Task<ResultadoAccesoDto> ValidarMatriculaAsync(
            string matricula,
            int viajeId)
        {
            if (string.IsNullOrWhiteSpace(matricula))
            {
                return new ResultadoAccesoDto
                {
                    Permitido = false,
                    Matricula = "",
                    Nombre = "",
                    Mensaje = "Debe ingresar una matrícula."
                };
            }

            var usuario = _usuarioRepository.GetByIdentificador(matricula);

            if (usuario == null)
            {
                return new ResultadoAccesoDto
                {
                    Permitido = false,
                    Matricula = matricula,
                    Nombre = "",
                    Mensaje = "No existe un usuario con esta matrícula."
                };
            }

            var ticket = await _ticketRepository
                .GetActivoByUsuarioAsync(usuario.Id);

            bool permitido = ticket != null;

            string motivo = permitido
                ? "Ticket mensual activo."
                : "No posee un ticket mensual activo.";

            var registro = new RegistroAcceso
            {
                UsuarioId = usuario.Id,
                ViajeId = viajeId,
                Permitido = permitido,
                Motivo = motivo,
                FechaHora = DateTime.Now
            };

            await _registroRepository.AddAsync(registro);

            return new ResultadoAccesoDto
            {
                Permitido = permitido,
                Matricula = usuario.IdentificadorInstitucional,
                Nombre = usuario.Nombre,
                Mensaje = permitido
                    ? "Acceso permitido."
                    : "Acceso denegado."
            };
        }

        public async Task AddAsync(RegistroAccesoDto dto)
        {
            var usuario = _usuarioRepository.GetById(dto.UsuarioId);

            if (usuario == null)
                throw new Exception("El usuario no existe.");

            var ticket = await _ticketRepository
                .GetActivoByUsuarioAsync(dto.UsuarioId);

            bool permitido = ticket != null;

            string motivo = permitido
                ? "Ticket válido"
                : "No posee un ticket mensual activo.";

            var registro = new RegistroAcceso
            {
                UsuarioId = dto.UsuarioId,
                ViajeId = dto.ViajeId,
                Permitido = permitido,
                Motivo = motivo,
                FechaHora = DateTime.Now
            };

            await _registroRepository.AddAsync(registro);

            await _notificationService.SendNotificationAsync(
                "estudiante@itla.edu.do",
                permitido ? "Acceso permitido" : "Acceso denegado",
                motivo);
        }


        public async Task RegistrarAccesoAsync(int usuarioId, int viajeId)
        {
            var usuario = _usuarioRepository.GetById(usuarioId);

            if (usuario == null)
                throw new Exception("El usuario no existe.");

            var ticket = await _ticketRepository
                .GetActivoByUsuarioAsync(usuarioId);

            bool permitido = ticket != null;

            string motivo = permitido
                ? "Ticket válido"
                : "No posee un ticket mensual activo.";

            var registro = new RegistroAcceso
            {
                UsuarioId = usuarioId,
                ViajeId = viajeId,
                Permitido = permitido,
                Motivo = motivo,
                FechaHora = DateTime.Now
            };

            await _registroRepository.AddAsync(registro);

            await _notificationService.SendNotificationAsync(
                "estudiante@itla.edu.do",
                permitido ? "Acceso permitido" : "Acceso denegado",
                motivo);

            await _notificacionService.AddAsync(new NotificacionDto
            {
                UsuarioId = usuarioId,
                TipoEvento = permitido
                    ? (int)TipoEvento.AccesoPermitido
                    : (int)TipoEvento.AccesoDenegado,

                Mensaje = motivo,
                FechaHora = DateTime.Now
            });
        }


        public async Task UpdateAsync(RegistroAccesoDto dto)
        {
            var registro = await _registroRepository
                .GetByIdAsync(dto.Id);

            if (registro == null)
                throw new Exception("Registro de acceso no encontrado.");

            _accesoRules.ValidarAutorizacion(dto.Permitido);

            registro.UsuarioId = dto.UsuarioId;
            registro.ViajeId = dto.ViajeId;
            registro.Permitido = dto.Permitido;
            registro.Motivo = dto.Motivo;
            registro.FechaHora = dto.FechaHora;

            await _registroRepository.UpdateAsync(registro);
        }


        public async Task DeleteAsync(int id)
        {
            var registro = await _registroRepository.GetByIdAsync(id);

            if (registro == null)
                throw new Exception(
                    "No se encontró el registro de acceso.");

            await _registroRepository.DeleteAsync(id);
        }
    }
}
