using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class BillDetail
    {
        public long BillDetId { get; set; }
        public long BillId { get; set; }
        public int SrNo { get; set; }
        public long PatientId { get; set; }
        public string PatientName { get; set; }
        public DateTime PatientDate { get; set; }
        public string TestAlias { get; set; }
        public decimal NormalTest { get; set; }
        public decimal SpecialTest { get; set; }
        public decimal Concession { get; set; }
        public decimal OtherCharges { get; set; }
        public decimal TotalAmt { get; set; }
        public decimal? AmtReceived { get; set; }
        public string Remark { get; set; }
        public string ProposalNo { get; set; }
        public string DoctorName { get; set; }
    }
}
