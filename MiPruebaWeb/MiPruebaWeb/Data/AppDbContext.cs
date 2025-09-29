using Microsoft.EntityFrameworkCore;
using MiPruebaWeb.Models;

namespace MiPruebaWeb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Paciente> Pacientes { get; set; } = null!;
    }
}
