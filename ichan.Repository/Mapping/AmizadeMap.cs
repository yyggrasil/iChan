using ichan.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ichan.Repository.Mapping
{
    public class AmizadeMap : IEntityTypeConfiguration<Amizade>
    {
        public void Configure(EntityTypeBuilder<Amizade> builder)
        {
            builder.ToTable("Amizade");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.DataInicio)
                .IsRequired()
                .HasColumnName("DataInicio")
                .HasColumnType("DATETIME");

            builder.HasOne(x => x.Usuario1);

            builder.HasOne(x => x.Usuario2);
        }
    }
}
