using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_DOCTOR_COMMISSION
    {
        public long? DOCHDR_lPatientId { get; set; }
        public string PATIENT_Name { get; set; }
        public DateTime? PATIENT_Date { get; set; }
        public int? DOCHDR_lDoctorId { get; set; }
        public string DOCTOR_Name { get; set; }
        public string DOCTOR_Address1 { get; set; }
        public string DOCTOR_City { get; set; }
        public string DOCTOR_State { get; set; }
        public string DOCTOR_Region { get; set; }
        public int? DOCHDR_TestCatID { get; set; }
        public string TESTMST_Alias { get; set; }
        public int? labno { get; set; }
        public string WardNo { get; set; }
        public int? TotalAmountPaid { get; set; }
        public int? DOCHDR_Sample { get; set; }
        public string CENTER_Name { get; set; }
        public double? LumSumAmt { get; set; }
        public string SpecialTest { get; set; }
        public double? Percentage { get; set; }
        public double? Discount { get; set; }
        public double? DOCHDR_Rate { get; set; }
        public string CENTER_Region { get; set; }
        public double? Patient_Discount { get; set; }
        public double? EmergencyCharges { get; set; }
        public bool DOCHDR_bCommission { get; set; }
        public double? Comm { get; set; }
    }
}
