using Microsoft.EntityFrameworkCore;
using SGA.Domain.Entities.Configuration;
using SGA.Domain.Entities.Reservation;

namespace SGA.Persistence.Context
{
    public class SGABD : DbContext
    {
        public SGABD(DbContextOptions<SGABD> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Autobus> Autobuses { get; set; }
        public DbSet<Conductor> Conductores { get; set; }
        public DbSet<Ruta> Rutas { get; set; }
        public DbSet<Parada> Paradas { get; set; }
        public DbSet<Horario> Horarios { get; set; }

        public DbSet<Pago> Pagos { get; set; }
        public DbSet<TicketMensual> TicketsMensuales { get; set; }
        public DbSet<TarjetaRecargable> TarjetasRecargables { get; set; }
        public DbSet<Viaje> Viajes { get; set; }
        public DbSet<RegistroAcceso> RegistrosAcceso { get; set; }
        public DbSet<Incidencia> Incidencias { get; set; }
        public DbSet<Notificacion> Notificaciones { get; set; }
        public DbSet<Auditoria> Auditorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Autobus>().ToTable("Autobus");
            modelBuilder.Entity<Conductor>().ToTable("Conductor");
            modelBuilder.Entity<Ruta>().ToTable("Ruta");
            modelBuilder.Entity<Parada>().ToTable("Parada");
            modelBuilder.Entity<Horario>().ToTable("Horario");

            modelBuilder.Entity<Pago>().ToTable("Pago");
            modelBuilder.Entity<TicketMensual>().ToTable("TicketMensual");
            modelBuilder.Entity<TarjetaRecargable>().ToTable("TarjetaRecargable");
            modelBuilder.Entity<Viaje>().ToTable("Viaje");
            modelBuilder.Entity<RegistroAcceso>().ToTable("RegistroAcceso");
            modelBuilder.Entity<Incidencia>().ToTable("Incidencia");
            modelBuilder.Entity<Notificacion>().ToTable("Notificacion");
            modelBuilder.Entity<Auditoria>().ToTable("Auditoria");

            modelBuilder.Entity<Usuario>()
    .Property(x => x.Estado)
    .HasConversion<string>();

            modelBuilder.Entity<Usuario>()
                .Property(x => x.TipoUsuario)
                .HasConversion<string>();

            modelBuilder.Entity<Autobus>()
                .Property(x => x.EstadoOperativo)
                .HasConversion<string>();

            modelBuilder.Entity<Conductor>()
                .Property(x => x.EstadoLaboral)
                .HasConversion<string>();

            modelBuilder.Entity<Viaje>()
                .Property(x => x.Estado)
                .HasConversion<string>();

            modelBuilder.Entity<TicketMensual>()
                .Property(x => x.Estado)
                .HasConversion<string>();

            modelBuilder.Entity<TarjetaRecargable>()
                .Property(x => x.Estado)
                .HasConversion<string>();

            modelBuilder.Entity<Incidencia>()
                .Property(x => x.Tipo)
                .HasConversion<string>();

            modelBuilder.Entity<Notificacion>()
                .Property(x => x.TipoEvento)
                .HasConversion<string>();

            // Evitar advertencias de decimales
            modelBuilder.Entity<Pago>()
                .Property(x => x.Monto)
                .HasPrecision(18, 2);

            modelBuilder.Entity<TarjetaRecargable>()
                .Property(x => x.Saldo)
                .HasPrecision(18, 2);

            base.OnModelCreating(modelBuilder);
        }
    }
}
