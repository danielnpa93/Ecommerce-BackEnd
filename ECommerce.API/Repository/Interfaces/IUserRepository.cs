using ECommerce.API.Models.Entities;
using System.Threading.Tasks;

namespace ECommerce.API.Repository.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> CreateUser(User user);

        Task<User> GetUserByName(string name);
    }
}
