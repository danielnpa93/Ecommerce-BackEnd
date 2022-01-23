using Newtonsoft.Json;

namespace ECommerce.API.Models.Dtos
{
    public class ProductDTO
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("amount")]
        public double Money { get; set; }
    }
}
