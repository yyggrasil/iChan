using ichan.Domain.Base;

namespace ichan.Domain.Entities
{
    public class Amizade : BaseEntity<int>
    {
        public Amizade() { }
        public Amizade(int id, DateTime? dataInicio)
        {
            Id = id;
            DataInicio = dataInicio;
        }

        public DateTime? DataInicio { get; set; }
    }
}
