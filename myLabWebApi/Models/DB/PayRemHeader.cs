using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class PayRemHeader
    {
        public long PayRemId { get; set; }
        public string RefNo { get; set; }
        public DateTime? RefDate { get; set; }
        public string Subject { get; set; }
        public int CenterId { get; set; }
        public string BillType { get; set; }
    }
}
