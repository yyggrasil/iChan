using ichan.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ichan.Repository.Mapping
{
    public class ComunidadeMap : IEntityTypeConfiguration<Comunidade>
    {
        public void Configure(EntityTypeBuilder<Comunidade> builder)
        {
            builder.ToTable("Comunidade");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnType("varchar(45)");

            builder.Property(x => x.Descricao)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.DataCriacao)
                .IsRequired()
                .HasColumnType("DATETIME");

            builder.HasMany(x => x.seguidores)
                .WithOne(x => x.Comunidade)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(x => x.posts)
                .WithOne(x => x.Comunidade)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(x => x.categorias)
                .WithOne(x => x.Comunidade)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
