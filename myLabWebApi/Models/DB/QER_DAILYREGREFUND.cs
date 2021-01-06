using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_DAILYREGREFUND
    {
        public long PATIENT_id { get; set; }
        public string PATIENT_Name { get; set; }
        public string PATIENT_Address1 { get; set; }
        public string PATIENT_Address2 { get; set; }
        public string PATIENT_City { get; set; }
        public string PATIENT_State { get; set; }
        public string PATIENT_Region { get; set; }
        public long PATIENT_Country { get; set; }
        public string PATIENT_Pincode { get; set; }
        public string PATIENT_Telno { get; set; }
        public string PATIENT_Gender { get; set; }
        public string PATIENT_Age { get; set; }
        public DateTime? PATIENT_Date { get; set; }
        public int? PATIENT_Doctorid { get; set; }
        public int? PATIENT_Companyid { get; set; }
        public double? PATIENT_AmountPaid { get; set; }
        public int? PATIENT_SampleCollected { get; set; }
        public int? Doctorid2 { get; set; }
        public string blnCommission { get; set; }
        public int? labno { get; set; }
        public string WardNo { get; set; }
        public string HOSPTYPE { get; set; }
        public double? TotalAmount { get; set; }
        public double? EmergencyCharges { get; set; }
        public double? Discount { get; set; }
        public double? EmergencyChargesPecent { get; set; }
        public DateTime? Sample_Date { get; set; }
        public string Remarks { get; set; }
        public string userid { get; set; }
        public DateTime? Currentdate { get; set; }
        public int? Patientno { get; set; }
        public double? DiscountPercent { get; set; }
        public string PATIENT_AgeFlag { get; set; }
        public string TEST_ALIAS { get; set; }
        public int? Bar_Copiese { get; set; }
        public int? Urgent { get; set; }
        public bool Issent { get; set; }
        public string DOCTOR_Name { get; set; }
        public string CENTER_Name { get; set; }
        public double? NormalTests { get; set; }
        public double? SpecialTests { get; set; }
        public int? TotalAmountPaid { get; set; }
        public int? TotalRefund { get; set; }
    }
}
