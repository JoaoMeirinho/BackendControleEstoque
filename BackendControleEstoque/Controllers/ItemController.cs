using BackendControleEstoque.DTOs.Request;
using BackendControleEstoque.DTOs.Response;
using BackendControleEstoque.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendControleEstoque.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {

        [HttpPost]
        [ProducesResponseType(typeof(ItemCreatedResponse), StatusCodes.Status201Created)]
        public async Task<IActionResult> AddItem(
            [FromServices] ItemService itemService,
            [FromBody] ItemCreateRequest request
            )
        {
            var result = await itemService.AddItemService(request);
            return Created(string.Empty, result);
        }
    }
}
