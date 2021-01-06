using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_PATIENTTYPE
    {
        public long Patient_id { get; set; }
        public DateTime? PATIENT_Date { get; set; }
        public string NAME { get; set; }
        public string PATIENT_Region { get; set; }
        public long PATIENT_Country { get; set; }
        public string PATIENT_Pincode { get; set; }
        public string PATIENT_Telno { get; set; }
        public string PATIENT_Gender { get; set; }
        public string PATIENT_Age { get; set; }
        public int? PATIENT_Doctorid { get; set; }
        public int? PATIENT_Companyid { get; set; }
        public double? PATIENT_AmountPaid { get; set; }
        public string TYPE { get; set; }
        public int? AmountPaid { get; set; }
        public DateTime? CurrentDate { get; set; }
        public string paymode { get; set; }
        public int? labno { get; set; }
        public string HOSPTYPE { get; set; }
        public double? TotalAmount { get; set; }
        public double? EmergencyCharges { get; set; }
        public double? Discount { get; set; }
        public double? EmergencyChargesPecent { get; set; }
        public DateTime? Sample_Date { get; set; }
        public string Remarks { get; set; }
        public int? Patientno { get; set; }
        public string userid { get; set; }
        public int? Patient_SampleCollected { get; set; }
        public string Center_Name { get; set; }
    }
}
