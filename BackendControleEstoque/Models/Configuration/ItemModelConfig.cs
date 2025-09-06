using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BackendControleEstoque.Models.Configuration
{
    public class ItemModelConfig : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Nome).IsRequired().HasMaxLength(100);
            builder.Property(i => i.Descricao).HasMaxLength(500);
            builder.Property(i => i.Quantidade).IsRequired();
            builder.Property(i => i.LastModified).IsRequired().HasDefaultValueSql("GETDATE()");
        }
    }
    
    
}
