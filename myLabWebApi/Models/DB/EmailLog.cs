using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class EmailLog
    {
        public long Docid { get; set; }
        public string Type { get; set; }
        public DateTime? SysDate { get; set; }
    }
}
