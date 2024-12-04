using ichan.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string? Descricao { get; set; }
    }
}
