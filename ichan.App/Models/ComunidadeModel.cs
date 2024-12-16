using ichan.Domain.Base;

namespace ichan.App.Models
{
    public class ComunidadeModel
    {
        public ComunidadeModel()
        {
            seguidores = new List<SegueModel>();
            posts = new List<PostModel>();
            categorias = new List<CategoriaDaComunidadeModel>();
        }

        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        #endregion

        #region relacionamentos
        public List<SegueModel> seguidores { get; set; }
        public List<PostModel> posts { get; set; }
        public List<CategoriaDaComunidadeModel> categorias { get; set; }
        #endregion
    }
}
