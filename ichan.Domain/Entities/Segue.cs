using ichan.Domain.Base;

namespace ichan.Domain.Entities
{
    public class Segue : BaseEntity<int>
    {
        public Segue() { }
        public Segue(int id, DateTime dataSeguida, Usuario usuario, Comunidade comunidade)
        {
            Id = id;
            DataSeguida = dataSeguida;
            Usuario = usuario;
            Comunidade = comunidade;
        }

        public DateTime DataSeguida { get; set; }
        public Usuario Usuario { get; set; }
        public Comunidade Comunidade { get; set; }
    }
}
