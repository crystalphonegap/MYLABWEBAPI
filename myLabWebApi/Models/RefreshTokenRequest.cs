using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerPortalWebApi.Models
{
    public class RefreshTokenRequest
    {
        public string TokenTxt { get; set; }

        public string RefreshTokenTxt { get; set; }
    }
}
