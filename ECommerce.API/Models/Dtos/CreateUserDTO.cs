using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.API.Models.Dtos
{
    public class CreateUserDTO
    {
        [Required]
        [JsonProperty("username")]
        public string Username { get; set; }

        [Required]
        [JsonProperty("password")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Not matches")]
        [JsonProperty("confirmPassword")]
        public string ConfirmPassword { get; set; }
    }
}
