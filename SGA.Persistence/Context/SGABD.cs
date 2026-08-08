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

            modelBuilder.Entity<Incidencia>()
                .Property(x => x.Tipo)
                .HasConversion<string>();

            modelBuilder.Entity<Notificacion>()
                .Property(x => x.TipoEvento)
                .HasConversion<string>();

            modelBuilder.Entity<Pago>()
                .Property(x => x.Monto)
                .HasPrecision(18, 2);

            modelBuilder.Entity<TarjetaRecargable>()
                .Property(x => x.Saldo)
                .HasPrecision(18, 2);

            modelBuilder.Entity<TicketMensual>()
                .Property(x => x.Precio)
                .HasPrecision(18, 2);

            modelBuilder.Entity<TarjetaRecargable>()
                .HasOne(t => t.Usuario)
                .WithMany(u => u.TarjetasRecargables)
                .HasForeignKey(t => t.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TicketMensual>()
                .HasOne<Usuario>()
                .WithMany()
                .HasForeignKey(t => t.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TicketMensual>()
                .HasOne<Pago>()
                .WithMany()
                .HasForeignKey(t => t.PagoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TicketMensual>()
                .HasOne<Ruta>()
                .WithMany()
                .HasForeignKey(t => t.RutaEntradaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TicketMensual>()
                .HasOne<Horario>()
                .WithMany()
                .HasForeignKey(t => t.HorarioEntradaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TicketMensual>()
                .HasOne<Parada>()
                .WithMany()
                .HasForeignKey(t => t.ParadaEntradaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TicketMensual>()
                .HasOne<Ruta>()
                .WithMany()
                .HasForeignKey(t => t.RutaSalidaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TicketMensual>()
                .HasOne<Horario>()
                .WithMany()
                .HasForeignKey(t => t.HorarioSalidaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TicketMensual>()
                .HasOne<Parada>()
                .WithMany()
                .HasForeignKey(t => t.ParadaSalidaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Pago>()
                .Property(x => x.Concepto)
                .HasConversion<string>();

            modelBuilder.Entity<Pago>()
                .Property(x => x.TipoTicket)
                .HasConversion<string>();

            modelBuilder.Entity<Auditoria>(entity =>
            {
                entity.ToTable("Auditoria");

                entity.HasKey(a => a.Id);

                entity.Property(a => a.Actor)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(a => a.TipoAccion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(a => a.Descripcion)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(a => a.FechaHora)
                    .IsRequired();

                entity.Property(a => a.FechaCreacion)
                    .IsRequired();

                entity.Property(a => a.FechaModificacion)
                    .IsRequired(false);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
