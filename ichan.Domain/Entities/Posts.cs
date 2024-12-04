using ichan.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ichan.Domain.Entities
{
    public class Posts : BaseEntity<int>
    {
        public Posts() { }
        public Posts(int id, string titulo, string? descricao, DateTime dataPost) 
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            DataPost = dataPost;
        }

        public string Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataPost { get; set; }
    }
}
