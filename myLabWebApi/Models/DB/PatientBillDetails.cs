using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class PatientBillDetails
    {
        public decimal BillId { get; set; }
        public decimal BillNo { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime PatientDate { get; set; }
        public long? PatientId { get; set; }
        public long? PatientNo { get; set; }
        public string PatientName { get; set; }
        public string PatientAddress1 { get; set; }
        public string PatientAddress2 { get; set; }
        public string PatientCity { get; set; }
        public string PatientState { get; set; }
        public string PatientCountry { get; set; }
        public string PatientAge { get; set; }
        public string PatientRegion { get; set; }
        public string PatientSex { get; set; }
        public string PatientPincode { get; set; }
        public string PatientTelNo { get; set; }
        public string PatientCollectionCenter { get; set; }
        public string DoctorName1 { get; set; }
        public string DoctorName2 { get; set; }
        public double? EmergencyCharge { get; set; }
        public double? EmergencyChargesPercentage { get; set; }
        public double? Discount { get; set; }
        public double? DiscountPercentage { get; set; }
        public double? DocHdrRate { get; set; }
        public string TestName { get; set; }
        public double? AmtPaid { get; set; }
        public int? Labno { get; set; }
        public double? BillAmt { get; set; }
        public double? TotalAmtPaid { get; set; }
        public string PatientBillDetId { get; set; }
        public string BillCategory { get; set; }
        public double? BaseRate { get; set; }
        public double? Discount1 { get; set; }
        public double? CashPaid { get; set; }
        public double? ChequePaid { get; set; }
        public double? CreditCardPaid { get; set; }
        public double? CollectedAtHospital { get; set; }
        public decimal? Upipaid { get; set; }
        public decimal? Neftpaid { get; set; }
    }
}
