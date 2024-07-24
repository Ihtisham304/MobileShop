using AfaqMobileShop.Server.Data;
using AfaqMobileShop.Shared.DTO;
using AfaqMobileShop.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AfaqMobileShop.Server.Controllers
{
    [ApiController]
    [Route("api/stocks")]
    public class StockController : ControllerBase
    {
        private readonly AfaqMobileShopContext _context;

        public StockController(AfaqMobileShopContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StockDTO>>> GetStocks()
        {
            var stocks = _context.Stocks.ToList();

            return Ok(stocks);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<StockDTO>> GetStock(int id)
        {
            var stock = _context.Stocks.SingleOrDefaultAsync(s => s.Id == id);
            if (stock == null)
            {
                NotFound();
            }
            return Ok(stock);
        }
        [HttpPost]
        public async Task<ActionResult<Stock>> CreateStock(Stock stock)
            {
                _context.Stocks.Add(stock);
            await _context.SaveChangesAsync();
            return Ok(stock);   
            }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStock(int id,Stock stock)
        {
            if (id== null)
            {
                return BadRequest();
            }
            _context.Entry(stock).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
                return Ok(stock);
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStock(int id)
        {
            var stock = await _context.Stocks.FindAsync(id);
            if (stock == null)
            {
                NotFound();
            }
            _context.Stocks.Remove(stock);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
