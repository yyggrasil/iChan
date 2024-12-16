using ichan.Domain.Base;

namespace ichan.App.Models
{
    public class CategoriaDaComunidadeModel
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public string? Categoria {  get; set; }
        public int IdComunidade { get; set; }
        public string? Comunidade {  get; set; }
    }
}
