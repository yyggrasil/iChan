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
            Descricao = descricao;
            DataPost = dataPost;
            Comunidade = comunidade;
            Usuario = usuario;
        }

        public string Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataPost { get; set; }

        public Comunidade Comunidade { get; set; }
        public Usuario Usuario { get; set; }
        public List<Comentario> Comentarios { get; set; } = [];
    }
}
