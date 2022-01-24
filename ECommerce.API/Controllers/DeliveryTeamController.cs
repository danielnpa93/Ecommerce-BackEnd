using ECommerce.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.API.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class DeliveryTeamController: ControllerBase
    {
        private readonly IDeliveryTeamServices _teamServices;

        public DeliveryTeamController(IDeliveryTeamServices teamServices )
        {
            _teamServices = teamServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var teams = await _teamServices.GetAll();
                return Ok(new { isValid = true, data = teams});
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { isValid = false, error = ex.Message, message = "Unknow error ocurred" });
            }
        }
    }
}
