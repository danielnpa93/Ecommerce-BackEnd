using ECommerce.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ECommerce.API.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderServices _orderService;

        public OrderController(IOrderServices orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAll([FromQuery] int? limit, int? offset)
        {
            try
            {
                var users = await _orderService.GetAll(limit, offset);
                return Ok(new {
                    isValid = true, 
                    data = users, 
                    totalPages = users.TotalPages, 
                    limit = users.Limit,
                    currentPage = users.CurrentPage, 
                    totalItems = users.TotalItems 
                });
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { isValid = false, error = ex.Message, message = "Unknow error ocurred" }) ;
            }
        }
      
    }
}
