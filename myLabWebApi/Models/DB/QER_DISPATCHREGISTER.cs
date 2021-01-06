using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_DISPATCHREGISTER
    {
        public long PATIENT_id { get; set; }
        public string PATIENT_Name { get; set; }
        public int? labno { get; set; }
        public double? TotalAmount { get; set; }
        public double? EmergencyCharges { get; set; }
        public double? Discount { get; set; }
        public string Remarks { get; set; }
        public DateTime? PATIENT_Date { get; set; }
        public int? PATIENT_SampleCollected { get; set; }
        public string CENTER_Name { get; set; }
        public string CENTER_Region { get; set; }
        public string TEST_ALIAS { get; set; }
        public string blnCommission { get; set; }
        public string DOCTOR_Name { get; set; }
        public string DOCTOR_Region { get; set; }
        public string PATIENT_Pincode { get; set; }
        public int? Doctorid2 { get; set; }
        public string DOCTOR_Name2 { get; set; }
        public int? TAmtPaid { get; set; }
        public int? TAmtRefund { get; set; }
        public string PATIENT_Email { get; set; }
        public string userid { get; set; }
    }
}
