namespace ichan.App.Models
{
    public class SegueModel
    {
        public int Id { get; set; }
        public DateTime DataSeguida { get; set; }
        public int IdUsuario { get; set; }
        public string? Usuario { get; set; }
        public int IdComunidade { get; set; }
        public string? Comunidade { get; set; }
    }
}
