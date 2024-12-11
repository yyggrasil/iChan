using ichan.Domain.Base;

namespace ichan.Domain.Entities
{
    public class Usuario : BaseEntity<int>
    {
        public Usuario() { }
        public Usuario(int id, string email, string senha, string nome, string? descricao)
        {
            Id = id;
            Email = email;
            Senha = senha;
            Nome = nome;
            Descricao = descricao;
        }

        #region Parâmetros

        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string? Descricao { get; set; }

        #endregion

        #region Relacionamentos

        public List<Amizade> amizades { get; } = [];

        public List<Post> posts { get; set; } = [];

        public List<Segue> seguir { get; set; } = [];
        public List<Comentario> comentarios { get; set; } = [];



        #endregion
    }
}
