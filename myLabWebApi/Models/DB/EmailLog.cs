using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class EmailLog
    {
        public long Docid { get; set; }
        public string Type { get; set; }
        public DateTime? SysDate { get; set; }
    }
}
