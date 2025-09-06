namespace BackendControleEstoque.DTOs.Request
{
    public class ItemCreateRequest
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
    }
}
