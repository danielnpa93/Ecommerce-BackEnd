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
    public class UserRepository : BaseRepository<User>, IUserRepository
    {

        public UserRepository(OrderContext context) : base(context)
        {
            
        }

        public async Task<User> CreateUser(User user)
        {
            var obj = await this.Create(user);

            return obj;
        }

        public async Task<User> GetUserByName(string name)
        {
            var obj = await this._context.User
                   .AsNoTracking()
                   .FirstOrDefaultAsync(user => user.Username == name);

            return obj;
        }
    }
}
