using AfaqMobileShop.Server.Data;
using AfaqMobileShop.Shared.DTO;
using AfaqMobileShop.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace AfaqMobileShop.Server.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UsersController: ControllerBase
    {
        private readonly AfaqMobileShopContext _context;
        public UsersController(AfaqMobileShopContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] User newuser)
        {
            _context.Users.Add(newuser);
            _context.SaveChanges();

            return Ok();
        }
        [HttpPost("login")]

        public IActionResult Login(LoginDTO loginDTO)
        {
            var user = AuthenticatedUser(loginDTO.UserName, loginDTO.Password);

            if (user == null)
            {
                return Unauthorized();
            }
            return Ok(new LoginResponseDTO { IsSuccess= true});
        }
        private User AuthenticatedUser(string userName, string password)
        {
            var user = _context.Users.SingleOrDefault(u=> u.UserName == userName && u.Password == password);
            return user;
        }
    }
}
