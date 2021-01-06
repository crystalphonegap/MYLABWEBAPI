using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class PayRemDetail
    {
        public long PayRemDetlId { get; set; }
        public long PayRemId { get; set; }
        public long BillId { get; set; }
        public long BillNo { get; set; }
        public string Fin_year { get; set; }
        public DateTime BillDate { get; set; }
        public decimal BillAmt { get; set; }
        public decimal RecAmount { get; set; }
        public decimal Deduction { get; set; }
        public decimal TDS { get; set; }
        public decimal Balance { get; set; }
    }
}
