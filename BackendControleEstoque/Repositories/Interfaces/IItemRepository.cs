using BackendControleEstoque.DTOs.Response;
using BackendControleEstoque.DTOs.Request;
using BackendControleEstoque.Models;

namespace BackendControleEstoque.Repositories.Interfaces
{
    public interface IItemRepository
    {
        Task AddItem(Item item);
    }
}
