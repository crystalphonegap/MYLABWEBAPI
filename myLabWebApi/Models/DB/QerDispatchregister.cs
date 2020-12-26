using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerDispatchregister
    {
        public long PatientId { get; set; }
        public string PatientName { get; set; }
        public int? Labno { get; set; }
        public double? TotalAmount { get; set; }
        public double? EmergencyCharges { get; set; }
        public double? Discount { get; set; }
        public string Remarks { get; set; }
        public DateTime? PatientDate { get; set; }
        public int? PatientSampleCollected { get; set; }
        public string CenterName { get; set; }
        public string CenterRegion { get; set; }
        public string TestAlias { get; set; }
        public string BlnCommission { get; set; }
        public string DoctorName { get; set; }
        public string DoctorRegion { get; set; }
        public string PatientPincode { get; set; }
        public int? Doctorid2 { get; set; }
        public string DoctorName2 { get; set; }
        public int? TamtPaid { get; set; }
        public int? TamtRefund { get; set; }
        public string PatientEmail { get; set; }
        public string Userid { get; set; }
    }
}
