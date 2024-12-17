using ichan.Domain.Base;

namespace ichan.App.Models
{
    public class PostModel
    {
        public PostModel()
        {
            Comentarios = new List<ComentarioModel>();
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string? Conteudo { get; set; }
        public DateTime DataPost { get; set; }

        public int IdComunidade { get; set; }
        public string? Comunidade {  get; set; }
        public int IdUsuario { get; set; }
        public string? Usuario { get; set; }
        public List<ComentarioModel> Comentarios { get; set; } = [];
    }
}
