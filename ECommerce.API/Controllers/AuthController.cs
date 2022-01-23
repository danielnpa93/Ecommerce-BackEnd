using ECommerce.API.Models.Dtos;
using ECommerce.API.Repository.Interfaces;
using ECommerce.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ECommerce.API.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ITokenServices _tokenServices;
        private readonly IUserRepository _userRepository;

        public AuthController(ITokenServices tokenServices, IUserRepository userRepository)
        {
            _tokenServices = tokenServices;
            _userRepository = userRepository;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserDTO user)
        {
            try
            {
                var obj = await _userRepository.GetUserByName(user.Username);

                if(obj == null || !BCrypt.Net.BCrypt.Verify(user.Password, obj.Password))
                {
                    return NotFound( new { isValid = false, message = "Invalid username or password" });
                }

                var token = _tokenServices.GenerateToken(user.Username);
                return Ok(new
                {
                    isValid = true,
                    data = new
                    {
                        token = token,
                    }
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { isValid = false, error = ex.Message, message = "Unknow error ocurred" });
            }
        }

    }
}
