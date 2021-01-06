using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class smsData
    {
        public long smsid { get; set; }
        public DateTime? smsdate { get; set; }
        public string mobileno { get; set; }
        public string message { get; set; }
        public string sndstatus { get; set; }
        public long? regno { get; set; }
    }
}
