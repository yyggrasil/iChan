using ichan.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ichan.Repository.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Email)
                .HasColumnType("varchar(45)")
                .IsRequired()
                .HasColumnName("DataInicio");

            builder.Property(x => x.Bios)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.Senha)
                .HasColumnType("varchar(45)")
                .IsRequired();

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(45)")
                .IsRequired();


        }
    }
}
