namespace ichan.App.Models
{
    public class CategoriaModel
    {
        public CategoriaModel()
        {
            categoriaDaComunidades = new List<CategoriaDaComunidadeModel>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public List<CategoriaDaComunidadeModel> categoriaDaComunidades { get; set; }
    }
}
