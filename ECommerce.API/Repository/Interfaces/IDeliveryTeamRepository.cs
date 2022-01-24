using ECommerce.API.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.API.Repository.Interfaces
{
    public interface IDeliveryTeamRepository : IBaseRepository<DeliveryTeam>
    {
        public Task<IEnumerable<DeliveryTeam>> GetAll();
    }
}
