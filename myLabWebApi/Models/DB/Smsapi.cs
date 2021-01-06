using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class SMSAPI
    {
        public int Id { get; set; }
        public string URL { get; set; }
        public string UserName { get; set; }
        public string password { get; set; }
        public string sender { get; set; }
        public int? EnableSMS { get; set; }
    }
}
