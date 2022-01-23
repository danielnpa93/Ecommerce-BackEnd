using ECommerce.API.Models.Dtos;
using ECommerce.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ECommerce.API.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;

        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserDTO user)
        {
            try
            {
                var reponse = await _userServices.CreateUser(user);

                if (!reponse.IsValid)
                {
                    return BadRequest(reponse);
                }

                return Ok(reponse);
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { isValid = false, error = ex.Message, message = "Unknow error ocurred" });
            }

        }
    }
}
