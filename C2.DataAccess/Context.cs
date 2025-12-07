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
    }
}
