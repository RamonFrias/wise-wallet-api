using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using wise_wallet_api.Data;
using wise_wallet_api.Domains;

namespace wise_wallet_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly DataContext _context;

        public ClientController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddClient(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
            return Ok("Client Added!");
        }

        [HttpGet("get_clients")]
        public async Task<IActionResult> GetAllClients()
        {
            var clients = await _context.Clients.ToListAsync();
            return Ok(clients);
        }
    }
}
