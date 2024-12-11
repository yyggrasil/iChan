using ichan.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ichan.Repository.Mapping
{
    public class CategoriaDaComunidadeMap : IEntityTypeConfiguration<CategoriaDaComunidade>
    {
        public void Configure(EntityTypeBuilder<CategoriaDaComunidade> builder)
        {
            builder.ToTable("Categoria Da Comunidade");

            builder.HasKey(c => c.Id);

            builder.HasOne(c => c.categoria);
            builder.HasOne(c => c.comunidade);
        }
    }
}
