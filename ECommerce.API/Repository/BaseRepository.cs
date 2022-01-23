using ECommerce.API.Context;
using ECommerce.API.Models.Entities;
using ECommerce.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.API.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private protected readonly OrderContext _context;

        public BaseRepository(OrderContext context)
        {
            _context = context;
        }

        public virtual async Task<T> Create(T obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();

            return obj;
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
           return await _context.Set<T>()
                .AsNoTracking()
                .ToListAsync();
        }

        public virtual async Task<T> GetById(Guid id)
        {
            var obj = await _context.Set<T>()
               .AsNoTracking()
               .FirstOrDefaultAsync(x => x.Id == id);

            return obj;
        }

        public virtual async Task<bool> Remove(Guid id)
        {
            var obj = await GetById(id);

            if (obj != null)
            {
                _context.Set<T>()
                    .Remove(obj);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public Task<T> Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
