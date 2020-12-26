using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class Smsapi
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Sender { get; set; }
        public int? EnableSms { get; set; }
    }
}
