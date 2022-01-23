using ECommerce.API.Context;
using ECommerce.API.Models.Entities;
using ECommerce.API.Repository.Interfaces;
using ECommerce.API.Utils;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.API.Repository
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(OrderContext context) : base(context)
        {
        }

        public async Task<PaginatedList<Order>> GetAll(int limit, int offset)
        {
            var count = await _context.Orders.CountAsync();

            var orders = await _context.Orders
                .Skip((offset - 1)* limit)
                .Take(limit)
                .Include(o => o.DeliveryTeam)
                .Include(o => o.OrderProducts).ThenInclude(op => op.Product)
                .AsNoTracking()
                .OrderByDescending(o => o.CreatedAt)
                .ToListAsync();

            return new PaginatedList<Order>(orders, count, offset, limit);
        }
    }
}
