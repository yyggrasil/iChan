using ichan.Domain.Base;

namespace ichan.Domain.Entities
{
    public class Categoria : BaseEntity<int>
    {
        public Categoria() { }
        public Categoria(int id, string nome, string? descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }

        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public virtual List<CategoriaDaComunidade> categoriaDaComunidades { get; set; } = [];
    }
}
