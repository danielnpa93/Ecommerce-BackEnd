using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.API.Models.Dtos
{
    public class DeliveryTeamDetailsDTO : DeliveryTeamDTO
    {

        [JsonProperty("orders_count")]
        public int OrdersCount { get; set; }

        [JsonProperty("first_order_date")]
        public string FirstDateTime { get; set; }

        [JsonProperty("last_order_date")]
        public string LastDateTime { get; set; }
    }
}
