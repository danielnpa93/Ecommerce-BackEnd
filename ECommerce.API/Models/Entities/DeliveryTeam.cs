using Newtonsoft.Json;
using System.Collections.Generic;

namespace ECommerce.API.Models.Entities
{
    public class DeliveryTeam : BaseEntity
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("vehicleIdentifier")]
        public string VehicleIdentifier { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
