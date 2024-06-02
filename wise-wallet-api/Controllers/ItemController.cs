using Microsoft.AspNetCore.Mvc;
using wise_wallet_api.Domains;
using wise_wallet_api.Repository.Implementations;
using wise_wallet_api.Repository.Interfaces;

namespace wise_wallet_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemBusiness _business;

        public ItemController(IItemBusiness business)
        {
            _business = business;
        }

        [HttpGet("get_itens")]
        public IActionResult GetItens()
        {
            return Ok(_business.GetItens());
        }

        [HttpGet("get_itens{id}")]
        public IActionResult GetItensByCardID(int id = 1)
        {
            return Ok(_business.GetItensByCardId(id));
        }

        [HttpPost("post_itens")]
        public IActionResult AddItem([FromBody] Item item)
        {
            if (item == null) return BadRequest();
            return Ok(_business.AddItem(item));
        }

        [HttpDelete("delete_item")]
        public IActionResult RemoveItem(int id) 
        {
            _business.RemoveItem(id);
            return NoContent();
        }
    }
}
