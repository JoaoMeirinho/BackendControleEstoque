using BackendControleEstoque.Models;

namespace BackendControleEstoque.Repositories.Interfaces
{
    public interface IMovimentacaoRepository
    {
        Task AddMovimentacao(Movimentacao movimentacao);
    }
}
