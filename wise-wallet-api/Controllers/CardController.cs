using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using wise_wallet_api.Business.Interfaces;
using wise_wallet_api.Data;
using wise_wallet_api.Domains;

namespace wise_wallet_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICardBusiness _business;

        public CardController(ICardBusiness business)
        {
            _business = business;
        }

        [HttpGet("get_cards")]
        public IActionResult GetAllCards()
        {
            return Ok(_business.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetCard(int id)
        {
            return Ok(_business.GetById(id));
        }

        [HttpPost]
        public IActionResult AddCard(Card card)
        {
            if (card == null) return BadRequest();
            return Ok(_business.CreateCard(card));
        }

        [HttpDelete("delete{id}")]
        public IActionResult DeleteCard(int id)
        {
            _business.Delete(id);
            return NoContent();
        }
    }
}
