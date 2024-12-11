using ichan.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ichan.Repository.Mapping
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");

            builder.HasKey(c => c.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(45)")
                .IsRequired();
            builder.Property(x => x.Descricao)
                .HasColumnType("varchar(255)");


            builder.HasMany(x => x.categoriaDaComunidades)
                .WithOne(x => x.categoria)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        }
    }
}
