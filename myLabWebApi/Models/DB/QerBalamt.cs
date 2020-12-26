using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerBalamt
    {
        public long PatientId { get; set; }
        public string PatientName { get; set; }
        public int? Labno { get; set; }
        public DateTime? PatientDate { get; set; }
        public double? BillAmount { get; set; }
        public int? TotalAmountPaid { get; set; }
        public double? BalanceAmt { get; set; }
        public string DoctorName { get; set; }
        public string CenterName { get; set; }
        public int? CenterId { get; set; }
        public string CenterRegion { get; set; }
        public string PatientPincode { get; set; }
        public string TestAlias { get; set; }
        public int? Urgent { get; set; }
        public string DoctorMobileNo { get; set; }
    }
}
