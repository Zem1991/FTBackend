using FTBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace FTBackend.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

        public DbSet<Compra> Compra { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Produto> Produto { get; set; }
    }
}
