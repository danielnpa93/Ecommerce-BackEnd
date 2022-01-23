using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.API.Models.Dtos
{
    public class LoginUserDTO
    {
        [Required]
        [JsonProperty("username")]
        public string Username { get; set; }

        [Required]
        [JsonProperty("password")]
        public string Password { get; set; }

    }
}
