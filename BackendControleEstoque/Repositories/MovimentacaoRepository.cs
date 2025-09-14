using BackendControleEstoque.Infra;
using BackendControleEstoque.Models;
using BackendControleEstoque.Repositories.Interfaces;

namespace BackendControleEstoque.Repositories
{
    public class MovimentacaoRepository(AppDbContext dbContext) : IMovimentacaoRepository
    {
        private readonly AppDbContext _dbContext = dbContext;
        public async Task AddMovimentacao(Movimentacao movimentacao)
        {
            //TASK: Implementar logs de erro e de movimentação
            await _dbContext.Movimentacao.AddAsync(movimentacao);
        }
    }
}
