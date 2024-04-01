using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using wise_wallet_api.Data;
using wise_wallet_api.Domains;

namespace wise_wallet_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly DataContext _context;

        public CardController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCards()
        {
            var cards = await _context.Cards.ToListAsync();
            return Ok(cards);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCard(int id)
        {
            var card = await _context.Cards.FindAsync(id);
            if(card is null)
                return BadRequest("Hero not found.");
            return Ok(card);
        }

        [HttpPost]
        public async Task<IActionResult> AddCard(Card card)
        {
            _context.Cards.Add(card);
            await _context.SaveChangesAsync();
            return Ok(await _context.Cards.ToListAsync());
        }
    }
}
