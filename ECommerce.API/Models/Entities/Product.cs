using Newtonsoft.Json;
using System.Collections.Generic;

namespace ECommerce.API.Models.Entities
{
    public class Product : BaseEntity
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("amount")]
        public double Money { get; set; }

        public virtual ICollection<OrderProduct> OrdersProduct { get; set; }

    }
}
