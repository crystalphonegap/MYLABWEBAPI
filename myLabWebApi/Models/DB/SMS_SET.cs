using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class SMS_SET
    {
        public decimal portno { get; set; }
        public string settings { get; set; }
        public string sign { get; set; }
        public string msgcenter { get; set; }
        public string web_sign { get; set; }
    }
}
