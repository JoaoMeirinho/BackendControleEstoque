using AutoMapper;
using BackendControleEstoque.DTOs.Request;
using BackendControleEstoque.DTOs.Response;
using BackendControleEstoque.Infra;
using BackendControleEstoque.Models;
using BackendControleEstoque.Repositories.Interfaces;

namespace BackendControleEstoque.Services
{
    public class ItemService(
        IMapper mapper,
        IItemRepository itemRepository,
        AppDbContext dbContext
        )
    {
        public readonly IMapper _mapper = mapper;
        public readonly IItemRepository _itemRepository = itemRepository;
        public readonly AppDbContext _dbContext = dbContext;
        public async Task<ItemCreatedResponse> AddItemService(ItemCreateRequest request)
        {
            //TASK: Adicionar validação para item criado

            var item = _mapper.Map<Item>(request);

            await _itemRepository.AddItem(item);
            await _dbContext.SaveChangesAsync();

            var itemResponse = _mapper.Map<ItemCreatedResponse>(item);
            return itemResponse;

        }
    }
}
