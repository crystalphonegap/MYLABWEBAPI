using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class PayRemHeader
    {
        public long PayRemID { get; set; }
        public string RefNo { get; set; }
        public DateTime? RefDate { get; set; }
        public string Subject { get; set; }
        public int Center_id { get; set; }
        public string Bill_Type { get; set; }
    }
}
