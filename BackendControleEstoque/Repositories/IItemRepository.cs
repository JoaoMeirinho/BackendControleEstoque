using BackendControleEstoque.DTOs.Response;
using BackendControleEstoque.DTOs.Request;

namespace BackendControleEstoque.Repositories
{
    public interface IItemRepository
    {
        Task<ItemCreatedResponse> AddItem(ItemCreateRequest item);
    }
}
