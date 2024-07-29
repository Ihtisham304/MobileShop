using AfaqMobileShop.Server.Data;
using AfaqMobileShop.Shared.DTO;
using AfaqMobileShop.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AfaqMobileShop.Server.Controllers
{
    [ApiController]
    [Route("api/sells")]
    public class SellController: ControllerBase
    {
        private readonly AfaqMobileShopContext _context;

        public SellController(AfaqMobileShopContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SellDTO>>> GetSales()
        {
            var sales = _context.Sales.ToList();

            return Ok(sales);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<SellDTO>> GetSale(int id)
        {
            var sale = await _context.Sales.SingleOrDefaultAsync(s => s.Id == id);

            if(sale == null)
            {
                return NotFound();
            }
            return Ok(sale);
        }
        [HttpGet("totalselling")]
        public async Task<IActionResult> GetTotalSales()
        {
            var totalSell = await _context.Sales.CountAsync();
            return Ok(totalSell);
        }
        [HttpPost]
        public async Task<ActionResult<Sell>> CreateSale(Sell sell)
        {
            _context.Sales.Add(sell);
            await _context.SaveChangesAsync();
            return Ok(sell);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSale(int id,Sell sell)
        {
            if (id != sell.Id)
            {
                return BadRequest();
            }
            _context.Entry(sell).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();

                return Ok(sell);
            }
            catch(DbUpdateConcurrencyException)
            {
                return NotFound();
            }

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSale(int id)
        {
            var sale = await _context.Sales.FindAsync(id);
            if(sale == null)
            {
                return NotFound();
            }
            _context.Sales.Remove(sale);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
