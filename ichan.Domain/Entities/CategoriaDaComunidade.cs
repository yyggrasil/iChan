using ichan.Domain.Base;

namespace ichan.Domain.Entities
{
    public class CategoriaDaComunidade : BaseEntity<int>
    {
        public CategoriaDaComunidade() { }
        public CategoriaDaComunidade(int id, Categoria categoria, Comunidade comunidade)
        {
            Id = id;
            this.categoria = categoria;
            this.comunidade = comunidade;
        }

        public Categoria categoria { get; set; }
        public Comunidade comunidade { get; set; }
    }
}
