using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerBill
    {
        public long? PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientAddress1 { get; set; }
        public string PatientAddress2 { get; set; }
        public string PatientCity { get; set; }
        public string PatientState { get; set; }
        public string PatientRegion { get; set; }
        public long? PatientCountry { get; set; }
        public string PatientPincode { get; set; }
        public string PatientTelno { get; set; }
        public string PatientGender { get; set; }
        public string PatientAge { get; set; }
        public DateTime? PatientDate { get; set; }
        public int? PatientDoctorid { get; set; }
        public int? PatientCompanyid { get; set; }
        public double? PatientAmountPaid { get; set; }
        public int? PatientSampleCollected { get; set; }
        public int? Doctorid2 { get; set; }
        public string BlnCommission { get; set; }
        public int? Labno { get; set; }
        public string WardNo { get; set; }
        public string Hosptype { get; set; }
        public double? TotalAmount { get; set; }
        public double? EmergencyCharges { get; set; }
        public double? Discount { get; set; }
        public double? EmergencyChargesPecent { get; set; }
        public DateTime? SampleDate { get; set; }
        public string Remarks { get; set; }
        public string Userid { get; set; }
        public DateTime? Currentdate { get; set; }
        public int? Patientno { get; set; }
        public double? DiscountPercent { get; set; }
        public string PatientAgeFlag { get; set; }
        public string TestAlias { get; set; }
        public int? BarCopiese { get; set; }
        public int? Urgent { get; set; }
        public bool? Issent { get; set; }
        public string EmployeeName { get; set; }
        public string DoctorName { get; set; }
        public string DoctorName1 { get; set; }
        public string CenterName { get; set; }
        public double? DochdrRate { get; set; }
        public int? TestmstCurrentId { get; set; }
        public string TestmstName { get; set; }
        public string TestmstPrintFormat { get; set; }
        public double? TestmstRate { get; set; }
        public string TestmstReportHeading { get; set; }
        public string Type { get; set; }
        public double? TestmstTestcost { get; set; }
        public string TestmstAlias { get; set; }
        public double? TestmstPercentage { get; set; }
        public double? TestmstLumsum { get; set; }
        public string Active { get; set; }
        public string Comments { get; set; }
        public int? TestmstCompanyid { get; set; }
        public int? TestmstTestTypeId { get; set; }
        public string TestmstCatType { get; set; }
        public string SpecialTest { get; set; }
        public string TestmstSample { get; set; }
        public float? BaseRate { get; set; }
        public float? Discount1 { get; set; }
        public int? ProfileId { get; set; }
    }
}
