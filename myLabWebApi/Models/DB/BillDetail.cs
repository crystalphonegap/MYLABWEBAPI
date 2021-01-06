using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class BillDetail
    {
        public long BillDetId { get; set; }
        public long BillId { get; set; }
        public int SrNo { get; set; }
        public long Patient_id { get; set; }
        public string Patient_Name { get; set; }
        public DateTime Patient_date { get; set; }
        public string Test_alias { get; set; }
        public decimal NormalTest { get; set; }
        public decimal SpecialTest { get; set; }
        public decimal Concession { get; set; }
        public decimal OtherCharges { get; set; }
        public decimal TotalAmt { get; set; }
        public decimal? Amt_received { get; set; }
        public string Remark { get; set; }
        public string Proposal_No { get; set; }
        public string Doctor_Name { get; set; }
    }
}
