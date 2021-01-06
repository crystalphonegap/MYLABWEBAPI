using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class VW_PATIENT_BILL_DETAILS
    {
        public long PATIENT_id { get; set; }
        public DateTime? PATIENT_Date { get; set; }
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
        public int? PATIENT_SampleCollected { get; set; }
        public string CENTER_Name { get; set; }
        public int? PATIENT_Doctorid { get; set; }
        public string Doctor_Name1 { get; set; }
        public int? Doctorid2 { get; set; }
        public string Doctor_Name2 { get; set; }
        public double? PATIENT_AmountPaid { get; set; }
        public string blnCommission { get; set; }
        public int? labno { get; set; }
        public double? TotalAmount { get; set; }
        public double? EmergencyCharges { get; set; }
        public double? Discount { get; set; }
        public double? EmergencyChargesPecent { get; set; }
        public double? DiscountPercent { get; set; }
        public int? Patientno { get; set; }
        public int? DOCHDR_TestCatID { get; set; }
        public double? DOCHDR_Rate { get; set; }
        public string TESTMST_Name { get; set; }
        public string Type { get; set; }
        public int? ProfileId { get; set; }
        public string IsProfile { get; set; }
        public float? BaseRate { get; set; }
        public float? Discount1 { get; set; }
        public double? BillAmount { get; set; }
        public int? TotalAmountPaid { get; set; }
        public int? CashPaid { get; set; }
        public int? ChequePaid { get; set; }
        public int? CreditCardPaid { get; set; }
        public int? COLLECTEDAtHospitalPaid { get; set; }
        public int? UPIPaid { get; set; }
        public int? NEFTPAID { get; set; }
    }
}
