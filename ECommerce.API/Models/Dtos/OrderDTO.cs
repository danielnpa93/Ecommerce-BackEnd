using Newtonsoft.Json;
using System.Collections.Generic;

namespace ECommerce.API.Models.Dtos
{
    public class OrderDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("delivery_date")]
        public string DeliveryDate { get; set; }

        [JsonProperty("adress")]
        public string Adress { get; set; }

        [JsonProperty("products")]
        public List<ProductDTO> Products { get; set; }

        [JsonProperty("delivery_team")]
        public DeliveryTeamDTO DeliveryTeam { get; set; }
        
    }
}
