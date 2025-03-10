﻿using ichan.Domain.Base;

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

        #region Propriedades
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        #endregion

        #region relacionamentos
        public virtual List<Segue> seguidores { get; set; } = [];
        public virtual List<Post> posts { get; set; } = [];
        public virtual List<CategoriaDaComunidade> categorias { get; set; } = [];
        #endregion
    }
}
