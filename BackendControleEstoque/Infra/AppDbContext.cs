using BackendControleEstoque.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendControleEstoque.Infra
{
    class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        DbSet<Item> Item { get; set; }
        DbSet<Movimentacao> Movimentacao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
