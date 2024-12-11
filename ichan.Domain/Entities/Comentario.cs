using ichan.Domain.Base;

namespace ichan.Domain.Entities
{
    public class Comentario : BaseEntity<int>
    {
        public Comentario() { }
        public Comentario(int id, string texto, DateTime dateComentario, Usuario usuario, Post post)
        {
            Id = id;
            Texto = texto;
            DateComentario = dateComentario;
            Usuario = usuario;
            Post = post;
        }

        public string Texto { get; set; }
        public DateTime DateComentario { get; set; }
        public Usuario Usuario { get; set; }
        public Post Post { get; set; }
    }
}
