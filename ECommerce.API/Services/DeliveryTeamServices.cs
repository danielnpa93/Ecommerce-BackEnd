using ECommerce.API.Models.Dtos;
using ECommerce.API.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.API.Services
{
    public class DeliveryTeamServices : IDeliveryTeamServices
    {

        private readonly IDeliveryTeamRepository _repository;

        public DeliveryTeamServices(IDeliveryTeamRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<DeliveryTeamDetailsDTO>> GetAll()
        {
            var teams = await _repository.GetAll();

            var deliveryTeamsViewModel = new List<DeliveryTeamDetailsDTO>();

            foreach (var item in teams)
            {
                deliveryTeamsViewModel.Add(new DeliveryTeamDetailsDTO
                {
                    Description = item.Description,
                    Name = item.Name,
                    VehicleIdentifier = item.VehicleIdentifier,
                    OrdersCount = item.Orders.Count,
                    FirstDateTime = item.Orders.OrderBy(x => x.DeliveryDate).FirstOrDefault()?.DeliveryDate.ToString("yyyy-MM-ddTHH:mm:ssZ")?? null,
                    LastDateTime = item.Orders.OrderByDescending(x => x.DeliveryDate).FirstOrDefault()?.DeliveryDate.ToString("yyyy-MM-ddTHH:mm:ssZ")?? null
                });
            }

            return deliveryTeamsViewModel;
        }
    }
}
