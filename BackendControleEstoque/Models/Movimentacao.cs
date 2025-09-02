using BackendControleEstoque.Enums;

namespace BackendControleEstoque.Models
{
    public class Movimentacao
    {
        public Guid Id { get; set; }
        public TipoMovimentoEnum TipoMovimento { get; set; }
        public int Quantidade { get; set; }
        public Item Item { get; set; }
    }
}
