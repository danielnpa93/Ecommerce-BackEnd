using Newtonsoft.Json;

namespace ECommerce.API.Models.Dtos
{
    public class UserDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

    }
}
