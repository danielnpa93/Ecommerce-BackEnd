using ECommerce.API.Models.Dtos;
using ECommerce.API.Repository.Interfaces;
using ECommerce.API.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.API.Services
{
    public class OrderServices : IOrderServices
    {
        private readonly IOrderRepository _repository;

        public OrderServices(IOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task<PaginatedList<OrderDTO>> GetAll(int? limit, int? offset)
        {
            var validLimit = limit.GetValueOrDefault(5);
            var validOffset = offset.GetValueOrDefault(1);

            var orders = await _repository.GetAll(validLimit, validOffset);

            var ordersViewModel = new List<OrderDTO>();

            foreach(var item in orders)
            {
                ordersViewModel.Add(new OrderDTO
                {
                    Adress = item.Adress,
                    CreatedAt = item.CreatedAt.ToString("yyyy-MM-ddTHH:mm:ssZ"),
                    DeliveryDate = item.DeliveryDate.ToString("yyyy-MM-ddTHH:mm:ssZ"),
                    Id = item.Id.ToString(),
                    DeliveryTeam = new DeliveryTeamDTO
                    {
                        Description = item.DeliveryTeam.Description,
                        Name = item.DeliveryTeam.Name,
                        VehicleIdentifier = item.DeliveryTeam.VehicleIdentifier
                    },
                    Products = item.OrderProducts.ToList().Select(x =>
                    new ProductDTO
                    {
                        Description = x.Product.Description,
                        Money = x.Product.Money,
                        Name = x.Product.Name

                    }).ToList()
                }) ;
            }

            return new PaginatedList<OrderDTO>(ordersViewModel, orders.TotalItems, orders.CurrentPage, validLimit, orders.TotalPages); 
        }
    }
}
