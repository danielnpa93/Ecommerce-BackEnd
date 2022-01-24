using ECommerce.API.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.API.Services
{
    public interface IDeliveryTeamServices
    {
        Task<List<DeliveryTeamDetailsDTO>> GetAll();
    }
}
