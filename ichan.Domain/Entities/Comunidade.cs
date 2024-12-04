using ichan.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ichan.Domain.Entities
{
    public class Comunidade : BaseEntity<int>
    {
        public Comunidade() { }
        public Comunidade(int id, string nome, string? descricao, DateTime dataCriacao) 
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            DataCriacao = dataCriacao;
        }

        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataCriacao { get; set; }

    }
}
