using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using wise_wallet_api.Business.Interfaces;
using wise_wallet_api.Data;
using wise_wallet_api.Domains;

namespace wise_wallet_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : ControllerBase
    {
        private readonly ITableBusiness _business;

        public TableController(ITableBusiness business)
        {
            _business = business;
        }

        [HttpPost]
        public IActionResult AddTable([FromBody] Table table)
        {
            if (table == null) return BadRequest();
            _business.Create(table);
            return Ok(table);
        }

        [HttpGet("get_tables")]
        public IActionResult GetAllTables()
        {
            return Ok(_business.GetAll());
        }

        [HttpGet("get_tables{id}")]
        public IActionResult GetAllTables(int id)
        {
            return Ok(_business.GetById(id));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTable(int id) 
        {
            _business.Delete(id);
            return NoContent();
        }
    }
}
