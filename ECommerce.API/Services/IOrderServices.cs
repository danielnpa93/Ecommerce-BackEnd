using ECommerce.API.Models.Dtos;
using ECommerce.API.Utils;
using System.Threading.Tasks;

namespace ECommerce.API.Services
{
    public interface IOrderServices
    {
        Task<PaginatedList<OrderDTO>> GetAll(int? limit, int? offset);
    }
}
