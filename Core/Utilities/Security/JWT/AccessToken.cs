using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        public string Token { get; set; } //Jwt nin ta kendisi 
        public DateTime Expiration { get; set; } //Bitiş zamanı

    }
}
