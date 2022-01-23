using Newtonsoft.Json;

namespace ECommerce.API.Models.Dtos
{
    public class DeliveryTeamDTO
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("vehicleIdentifier")]
        public string VehicleIdentifier { get; set; }

    }
}
