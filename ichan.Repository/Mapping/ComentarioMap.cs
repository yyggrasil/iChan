using ichan.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ichan.Repository.Mapping
{
    public class ComentarioMap : IEntityTypeConfiguration<Comentario>
    {
        public void Configure(EntityTypeBuilder<Comentario> builder)
        {
            builder.ToTable("Comentario");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Texto)
                .IsRequired()
                .HasColumnType("varchar(255)");
            builder.Property(x => x.DateComentario)
                .IsRequired()
                .HasColumnType("DATETIME");

            builder.HasOne(x => x.Usuario);
            builder.HasOne<Comentario>();
        }
    }
}
