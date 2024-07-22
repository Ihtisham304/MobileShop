using AfaqMobileShop.Server.Data;
using AfaqMobileShop.Shared.DTO;
using AfaqMobileShop.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AfaqMobileShop.Server.Controllers
{
    [ApiController]
    [Route("api/buys")]
    public class BuyController: ControllerBase
    {
        private readonly AfaqMobileShopContext _context;
        public BuyController(AfaqMobileShopContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BuyDTO>>> GetBuyers()
        {
            var Buyers =  _context.Buying.ToList();
            return Ok(Buyers);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<BuyDTO>> GetBuy(int id)
        {
            var Buy = _context.Buying.SingleOrDefaultAsync(b=> b.Id == id);
            if(Buy == null)
            {
                return NotFound();
            }
            return Ok(Buy);
        }
        [HttpPost]
        public async Task<ActionResult<Buy>> CreateBuy(Buy buy)
        {
            _context.Buying.Add(buy);
            await _context.SaveChangesAsync();

            return Ok(buy);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBuy(int id, Buy buy)
        {
            if(id != buy.Id)
            {
                return NotFound();
            }
            _context.Entry(buy).State = EntityState.Modified;
            try
            {
                _context.SaveChangesAsync();
                return Ok(buy);
            }
            catch(DbUpdateConcurrencyException)
            {
                return NotFound();
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBuy(int id)
        {
            var buy = await _context.Buying.FindAsync(id);
            if (buy == null)
            {
                return NotFound();
            }
            _context.Buying.Remove(buy);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
