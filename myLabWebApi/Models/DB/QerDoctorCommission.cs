using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerDoctorCommission
    {
        public long? DochdrLPatientId { get; set; }
        public string PatientName { get; set; }
        public DateTime? PatientDate { get; set; }
        public int? DochdrLDoctorId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorAddress1 { get; set; }
        public string DoctorCity { get; set; }
        public string DoctorState { get; set; }
        public string DoctorRegion { get; set; }
        public int? DochdrTestCatId { get; set; }
        public string TestmstAlias { get; set; }
        public int? Labno { get; set; }
        public string WardNo { get; set; }
        public int? TotalAmountPaid { get; set; }
        public int? DochdrSample { get; set; }
        public string CenterName { get; set; }
        public double? LumSumAmt { get; set; }
        public string SpecialTest { get; set; }
        public double? Percentage { get; set; }
        public double? Discount { get; set; }
        public double? DochdrRate { get; set; }
        public string CenterRegion { get; set; }
        public double? PatientDiscount { get; set; }
        public double? EmergencyCharges { get; set; }
        public bool DochdrBCommission { get; set; }
        public double? Comm { get; set; }
    }
}
