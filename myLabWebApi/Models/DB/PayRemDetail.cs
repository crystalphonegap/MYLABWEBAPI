using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class PayRemDetail
    {
        public long PayRemDetlId { get; set; }
        public long PayRemId { get; set; }
        public long BillId { get; set; }
        public long BillNo { get; set; }
        public string FinYear { get; set; }
        public DateTime BillDate { get; set; }
        public decimal BillAmt { get; set; }
        public decimal RecAmount { get; set; }
        public decimal Deduction { get; set; }
        public decimal Tds { get; set; }
        public decimal Balance { get; set; }
    }
}
