using SGA.Application.Dtos.Ruta;
using SGA.Application.Interfaces;
using SGA.Domain.Entities.Configuration;
using SGA.Persistence.Interfaces;

namespace SGA.Application.Services
{
    public class RutaService : IRutaService
    {
        private readonly IRutaRepository _rutaRepository;

        public RutaService(IRutaRepository rutaRepository)
        {
            _rutaRepository = rutaRepository;
        }

        public Task<IEnumerable<RutaDto>> GetAllAsync()
        {
            var rutas = _rutaRepository.GetAll();

            var resultado = rutas.Select(r => new RutaDto
            {
                Id = r.Id,
                Nombre = r.Nombre,
                Origen = r.Origen,
                Destino = r.Destino
            });

            return Task.FromResult(resultado);
        }

        public Task<RutaDto?> GetByIdAsync(int id)
        {
            var ruta = _rutaRepository.GetById(id);

            if (ruta == null)
                return Task.FromResult<RutaDto?>(null);

            return Task.FromResult<RutaDto?>(new RutaDto
            {
                Id = ruta.Id,
                Nombre = ruta.Nombre,
                Origen = ruta.Origen,
                Destino = ruta.Destino
            });
        }

        public Task AddAsync(RutaDto dto)
        {
            var ruta = new Ruta
            {
                Nombre = dto.Nombre,
                Origen = dto.Origen,
                Destino = dto.Destino
            };

            _rutaRepository.Add(ruta);

            return Task.CompletedTask;
        }

        public Task UpdateAsync(RutaDto dto)
        {
            var ruta = _rutaRepository.GetById(dto.Id);

            if (ruta == null)
                throw new Exception("Ruta no encontrada.");

            ruta.Nombre = dto.Nombre;
            ruta.Origen = dto.Origen;
            ruta.Destino = dto.Destino;

            _rutaRepository.Update(ruta);

            return Task.CompletedTask;
        }

        public Task DeleteAsync(int id)
        {
            var eliminado = _rutaRepository.Delete(id);

            if (!eliminado)
                throw new Exception("Ruta no encontrada.");

            return Task.CompletedTask;
        }
    }
}