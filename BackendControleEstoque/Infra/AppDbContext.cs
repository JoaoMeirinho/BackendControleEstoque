using BackendControleEstoque.Models;
using BackendControleEstoque.Models.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BackendControleEstoque.Infra
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<Item> Item { get; set; }
        public DbSet<Movimentacao> Movimentacao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            new ItemModelConfig().Configure(modelBuilder.Entity<Item>());
        }
    }
}
