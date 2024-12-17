using ichan.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ichan.Repository.Mapping
{
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Post");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Titulo)
                .IsRequired()
                .HasColumnType("varchar(45)");

            builder.Property(x => x.Texto)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.DataPost)
                .IsRequired()
                .HasColumnType("DATETIME");
            builder.HasOne(x => x.Comunidade);
            builder.HasOne(x => x.Usuario);
            builder.HasMany(x => x.Comentarios)
                .WithOne(x => x.Post);
        }
    }
}
