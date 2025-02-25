namespace ichan.App.Models
{
    public class UsuarioModel
    {
        public UsuarioModel()
        {
            posts = new List<PostModel>();
            seguir = new List<SegueModel>();
            comentarios = new List<ComentarioModel>();
        }

        #region Parâmetros
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string? Bios { get; set; }

        #endregion

        #region Relacionamentos
        public List<PostModel> posts { get; set; }
        public List<SegueModel> seguir { get; set; }
        public List<ComentarioModel> comentarios { get; set; }

        #endregion
    }
}
