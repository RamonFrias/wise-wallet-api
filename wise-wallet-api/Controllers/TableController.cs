using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using wise_wallet_api.Data;
using wise_wallet_api.Domains;

namespace wise_wallet_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : ControllerBase
    {
        private readonly DataContext _context;

        public TableController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddTable([FromBody] Table table)
        {
            _context.Tables.Add(table);
            await _context.SaveChangesAsync();
            return Ok("Table Added!");
        }

        [HttpGet("get_tables")]
        public async Task<IActionResult> GetAllTables()
        {
            var cards = await _context.Tables.ToListAsync();
            return Ok(cards);
        }
    }
}
