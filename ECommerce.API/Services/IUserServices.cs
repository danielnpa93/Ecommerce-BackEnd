using ECommerce.API.Models.Dtos;
using ECommerce.API.Utils;
using System.Threading.Tasks;

namespace ECommerce.API.Services
{
    public interface IUserServices
    {
        public Task<ResponseEnvelope<UserDTO>> CreateUser(CreateUserDTO user);
    }
}
