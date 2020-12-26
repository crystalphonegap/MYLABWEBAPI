using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class SmsSet
    {
        public decimal Portno { get; set; }
        public string Settings { get; set; }
        public string Sign { get; set; }
        public string Msgcenter { get; set; }
        public string WebSign { get; set; }
    }
}
