using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.API.Models.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string  Password { get; set; }
    }
}
