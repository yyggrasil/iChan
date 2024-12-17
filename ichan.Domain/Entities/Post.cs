using ichan.Domain.Base;

namespace ichan.Domain.Entities
{
    public class Post : BaseEntity<int>
    {
        public Post() { }
        public Post(int id, string titulo, string? descricao, DateTime dataPost, Comunidade comunidade, Usuario usuario)
        {
            Id = id;
            Titulo = titulo;
            Conteudo = descricao;
            DataPost = dataPost;
            Comunidade = comunidade;
            Usuario = usuario;
        }

        public string Titulo { get; set; }
        public string? Conteudo { get; set; }
        public DateTime DataPost { get; set; }

        public virtual Comunidade Comunidade { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual List<Comentario> Comentarios { get; set; } = [];
    }
}
