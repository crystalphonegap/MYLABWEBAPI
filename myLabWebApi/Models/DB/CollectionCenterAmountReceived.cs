using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class CollectionCenterAmountReceived
    {
        public long PayRecId { get; set; }
        public int CenterId { get; set; }
        public DateTime PayRecDate { get; set; }
        public long BillId { get; set; }
        public string PayRecMode { get; set; }
        public string BankName { get; set; }
        public string BankBranch { get; set; }
        public string ChequeNo { get; set; }
        public DateTime? ChequeDate { get; set; }
        public decimal RecAmount { get; set; }
        public decimal Deduction { get; set; }
        public decimal Tds { get; set; }
        public int? FromId { get; set; }
    }
}
