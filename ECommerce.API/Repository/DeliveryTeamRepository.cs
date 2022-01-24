using ECommerce.API.Context;
using ECommerce.API.Models.Entities;
using ECommerce.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.API.Repository
{
    public class DeliveryTeamRepository : BaseRepository<DeliveryTeam>, IDeliveryTeamRepository
    {
        public DeliveryTeamRepository(OrderContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<DeliveryTeam>> GetAll()
        {
           return await _context.DeliveryTeam
                .OrderBy(o=>o.Name)
                .Include(o => o.Orders)
                .AsNoTracking()
                .ToListAsync();

        }
    }
}
