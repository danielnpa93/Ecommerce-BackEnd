using ECommerce.API.Models.Entities;
using ECommerce.API.Utils;
using System.Threading.Tasks;

namespace ECommerce.API.Repository.Interfaces
{
    public interface IOrderRepository : IBaseRepository<Order>
    {
        public Task<PaginatedList<Order>> GetAll(int limit, int offset);
    }
}
