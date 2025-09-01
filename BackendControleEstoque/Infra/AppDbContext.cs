using Microsoft.EntityFrameworkCore;

namespace BackendControleEstoque.Infra
{
    class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
