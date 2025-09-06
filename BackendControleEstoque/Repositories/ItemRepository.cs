using BackendControleEstoque.DTOs.Request;
using BackendControleEstoque.DTOs.Response;
using BackendControleEstoque.Infra;
using BackendControleEstoque.Models;
using BackendControleEstoque.Repositories.Interfaces;

namespace BackendControleEstoque.Repositories
{
    public class ItemRepository(AppDbContext dbContext) : IItemRepository
    {
        private readonly AppDbContext _dbContext = dbContext;
        public async Task AddItem(Item item)
        {
            await _dbContext.Item.AddAsync(item);
        }
    }
}
