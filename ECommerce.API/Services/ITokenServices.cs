using ECommerce.API.Models.Entities;

namespace ECommerce.API.Services
{
    public interface ITokenServices
    {
        public string GenerateToken(string username);
    }

}
