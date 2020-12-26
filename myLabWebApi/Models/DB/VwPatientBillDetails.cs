using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class VwPatientBillDetails
    {
        public long PatientId { get; set; }
        public DateTime? PatientDate { get; set; }
        public string PatientName { get; set; }
        public string PatientAddress1 { get; set; }
        public string PatientAddress2 { get; set; }
        public string PatientCity { get; set; }
        public string PatientState { get; set; }
        public string PatientRegion { get; set; }
        public long PatientCountry { get; set; }
        public string PatientPincode { get; set; }
        public string PatientTelno { get; set; }
        public string PatientGender { get; set; }
        public string PatientAge { get; set; }
        public int? PatientSampleCollected { get; set; }
        public string CenterName { get; set; }
        public int? PatientDoctorid { get; set; }
        public string DoctorName1 { get; set; }
        public int? Doctorid2 { get; set; }
        public string DoctorName2 { get; set; }
        public double? PatientAmountPaid { get; set; }
        public string BlnCommission { get; set; }
        public int? Labno { get; set; }
        public double? TotalAmount { get; set; }
        public double? EmergencyCharges { get; set; }
        public double? Discount { get; set; }
        public double? EmergencyChargesPecent { get; set; }
        public double? DiscountPercent { get; set; }
        public int? Patientno { get; set; }
        public int? DochdrTestCatId { get; set; }
        public double? DochdrRate { get; set; }
        public string TestmstName { get; set; }
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
        public int? CollectedatHospitalPaid { get; set; }
        public int? Upipaid { get; set; }
        public int? Neftpaid { get; set; }
    }
}
