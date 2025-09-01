namespace BackendControleEstoque.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public DateTime LastModified { get; set; }

    }
}
