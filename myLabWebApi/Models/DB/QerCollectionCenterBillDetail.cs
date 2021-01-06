using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QerCollectionCenterBillDetail
    {
        public string PATIENT_Name { get; set; }
        public long PATIENT_id { get; set; }
        public DateTime? PATIENT_Date { get; set; }
        public double? NormalTests { get; set; }
        public double? SpecialTests { get; set; }
        public double? Discount { get; set; }
        public double? EmergencyChargesPecent { get; set; }
        public int? CENTER_id { get; set; }
        public double? TotalAmount { get; set; }
        public long? BillId { get; set; }
        public string Proposal_No { get; set; }
        public string PATIENT_Pincode { get; set; }
        public string DOCTOR_NAME { get; set; }
    }
}
