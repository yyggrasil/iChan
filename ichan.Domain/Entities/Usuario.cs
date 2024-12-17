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
            Bios = descricao;
        }

        #region Parâmetros

        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string? Bios { get; set; }

        #endregion

        #region Relacionamentos

        public virtual List<Post> posts { get; set; } = [];

        public virtual List<Segue> seguir { get; set; } = [];
        public virtual List<Comentario> comentarios { get; set; } = [];



        #endregion
    }
}
