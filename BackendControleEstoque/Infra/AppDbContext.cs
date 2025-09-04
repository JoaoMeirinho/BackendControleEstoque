using BackendControleEstoque.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BackendControleEstoque.Infra
{
    class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext(options)
    {
        DbSet<Item> Item { get; set; }
        DbSet<Movimentacao> Movimentacao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
