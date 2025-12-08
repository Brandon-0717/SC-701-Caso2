using C2.Abstractions.Models.DAModels;
using Microsoft.EntityFrameworkCore;

namespace C2.DataAccess
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<ProductoDA> Productos { get; set; }
        public DbSet<OrdenDA> Ordenes { get; set; }
        public DbSet<OrdenDetalleDA> OrdenDetalles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrdenDetalleDA>()
                .HasKey(o => new { o.OrdenDetallePK, o.ProductoFK });
        }
    }
}
