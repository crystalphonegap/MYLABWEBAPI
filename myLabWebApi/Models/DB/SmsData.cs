using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class SmsData
    {
        public long Smsid { get; set; }
        public DateTime? Smsdate { get; set; }
        public string Mobileno { get; set; }
        public string Message { get; set; }
        public string Sndstatus { get; set; }
        public long? Regno { get; set; }
    }
}
