using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ECommerce.API.Models.Entities
{
    public class Order : BaseEntity
    {
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("delivery_date")]

        public DateTime DeliveryDate { get; set; }

        [JsonProperty("adress")]
        public string Adress { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }

        [JsonProperty("delivery_team_id")]
        public Guid DeliveryTeamId { get; set; }

        public DeliveryTeam DeliveryTeam { get; set; }

    }
}