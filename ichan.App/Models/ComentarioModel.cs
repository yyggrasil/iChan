using ichan.Domain.Base;

namespace ichan.App.Models
{
    public class ComentarioModel
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public DateTime DateComentario { get; set; }
        public int IdUsuario { get; set; }
        public string? Usuario { get; set; }
        public int IdPost {  get; set; }
        public string? Post { get; set; }
    }
}
