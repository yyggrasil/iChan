using ichan.Domain.Base;

namespace ichan.Domain.Entities
{
    public class Comentario : BaseEntity<int>
    {
        public Comentario() { }
        public Comentario(int id, string texto, DateTime dateComentario) 
        {
            Id = id;
            Texto = texto;
            DateComentario = dateComentario;
        }

        public string Texto { get; set; }
        public DateTime DateComentario { get; set; }
    }
}
