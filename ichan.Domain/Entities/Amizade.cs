using ichan.Domain.Base;

namespace ichan.Domain.Entities
{
    public class Amizade : BaseEntity<int>
    {
        public Amizade() { }
        public Amizade(int id, DateTime? dataInicio, Usuario usuario1, Usuario usuario2)
        {
            Id = id;
            DataInicio = dataInicio;
            Usuario1 = usuario1;
            Usuario2 = usuario2;
        }

        public DateTime? DataInicio { get; set; }

        public Usuario Usuario1 { get; set; }
        public Usuario Usuario2 { get; set; }
    }
}
