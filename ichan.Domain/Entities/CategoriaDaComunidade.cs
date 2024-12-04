using ichan.Domain.Base;

namespace ichan.Domain.Entities
{
    public class CategoriaDaComunidade : BaseEntity<int>
    {
        public CategoriaDaComunidade() { }
        public CategoriaDaComunidade(int id)
        {
            Id = id;
        }
    }
}
