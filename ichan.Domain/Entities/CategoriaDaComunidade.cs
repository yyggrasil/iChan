using ichan.Domain.Base;

namespace ichan.Domain.Entities
{
    public class CategoriaDaComunidade : BaseEntity<int>
    {
        public CategoriaDaComunidade() { }
        public CategoriaDaComunidade(int id, Categoria categoria, Comunidade comunidade)
        {
            Id = id;
            this.Categoria = categoria;
            this.Comunidade = comunidade;
        }

        public virtual Categoria Categoria { get; set; }
        public virtual Comunidade Comunidade { get; set; }
    }
}
