using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.API
{

    public interface ISettings
    {
        public string TokenKey { get; set; }
    }
    public class Settings : ISettings
    {
        public string TokenKey { get; set; }

        public Settings(string tokenKey)
        {
            TokenKey = tokenKey;
        }
    }
}
