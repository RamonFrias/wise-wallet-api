using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using wise_wallet_api.Data;
using wise_wallet_api.Domains;

namespace wise_wallet_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly DataContext _context;

        public ItemController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("get_itens")]
        public async Task<IActionResult> GetIten()
        {
            var itens = await _context.Itens.ToListAsync();
            return Ok(itens);
        }

        [HttpPost("post_itens")]
        public async Task<IActionResult> AddItem([FromBody] Item item)
        {
            _context.Itens.Add(item);
            await _context.SaveChangesAsync();
            return Ok("Item sucessfull Added");
        }
    }
}
