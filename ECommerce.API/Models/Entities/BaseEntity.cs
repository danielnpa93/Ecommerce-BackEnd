using Newtonsoft.Json;
using System;

namespace ECommerce.API.Models.Entities
{
    public class BaseEntity
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
    }
}
