using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerCollectionCenterBillDetail
    {
        public string PatientName { get; set; }
        public long PatientId { get; set; }
        public DateTime? PatientDate { get; set; }
        public double? NormalTests { get; set; }
        public double? SpecialTests { get; set; }
        public double? Discount { get; set; }
        public double? EmergencyChargesPecent { get; set; }
        public int? CenterId { get; set; }
        public double? TotalAmount { get; set; }
        public long? BillId { get; set; }
        public string ProposalNo { get; set; }
        public string PatientPincode { get; set; }
        public string DoctorName { get; set; }
    }
}
