using ichan.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ichan.Repository.Mapping
{
    public class SegueMap : IEntityTypeConfiguration<Segue>
    {
        public void Configure(EntityTypeBuilder<Segue> builder)
        {
            builder.ToTable("Segue");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.DataSeguida)
                .IsRequired()
                .HasColumnType("DATETIME");

            builder.HasOne(x => x.Usuario);
            builder.HasOne(x => x.Comunidade);
        }
    }
}
