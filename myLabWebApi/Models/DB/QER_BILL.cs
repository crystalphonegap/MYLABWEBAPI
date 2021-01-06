using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_BILL
    {
        public long? PATIENT_id { get; set; }
        public string PATIENT_Name { get; set; }
        public string PATIENT_Address1 { get; set; }
        public string PATIENT_Address2 { get; set; }
        public string PATIENT_City { get; set; }
        public string PATIENT_State { get; set; }
        public string PATIENT_Region { get; set; }
        public long? PATIENT_Country { get; set; }
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
        public bool? Issent { get; set; }
        public string EMPLOYEE_Name { get; set; }
        public string DOCTOR_Name { get; set; }
        public string DOCTOR_Name1 { get; set; }
        public string CENTER_Name { get; set; }
        public double? DOCHDR_Rate { get; set; }
        public int? TESTMST_CurrentId { get; set; }
        public string TESTMST_Name { get; set; }
        public string TESTMST_PrintFormat { get; set; }
        public double? TESTMST_Rate { get; set; }
        public string TESTMST_ReportHeading { get; set; }
        public string Type { get; set; }
        public double? TESTMST_Testcost { get; set; }
        public string TESTMST_Alias { get; set; }
        public double? TESTMST_Percentage { get; set; }
        public double? TESTMST_Lumsum { get; set; }
        public string Active { get; set; }
        public string Comments { get; set; }
        public int? TESTMST_Companyid { get; set; }
        public int? TESTMST_TestTypeId { get; set; }
        public string TESTMST_CatType { get; set; }
        public string SpecialTest { get; set; }
        public string TESTMST_sample { get; set; }
        public float? BaseRate { get; set; }
        public float? Discount1 { get; set; }
        public int? ProfileId { get; set; }
    }
}
