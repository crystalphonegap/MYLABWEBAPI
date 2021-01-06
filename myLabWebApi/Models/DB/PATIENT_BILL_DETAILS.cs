using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class PATIENT_BILL_DETAILS
    {
        public decimal Bill_id { get; set; }
        public decimal Bill_No { get; set; }
        public DateTime Bill_date { get; set; }
        public DateTime Patient_Date { get; set; }
        public long? Patient_id { get; set; }
        public long? PatientNo { get; set; }
        public string Patient_Name { get; set; }
        public string Patient_address1 { get; set; }
        public string Patient_address2 { get; set; }
        public string Patient_City { get; set; }
        public string Patient_State { get; set; }
        public string Patient_Country { get; set; }
        public string Patient_Age { get; set; }
        public string Patient_Region { get; set; }
        public string Patient_Sex { get; set; }
        public string Patient_Pincode { get; set; }
        public string Patient_TelNo { get; set; }
        public string Patient_Collection_Center { get; set; }
        public string DoctorName1 { get; set; }
        public string DoctorName2 { get; set; }
        public double? Emergency_Charge { get; set; }
        public double? EmergencyChargesPercentage { get; set; }
        public double? Discount { get; set; }
        public double? DiscountPercentage { get; set; }
        public double? DocHdrRate { get; set; }
        public string TestName { get; set; }
        public double? AmtPaid { get; set; }
        public int? labno { get; set; }
        public double? BillAmt { get; set; }
        public double? TotalAmtPaid { get; set; }
        public string PatientBillDetId { get; set; }
        public string Bill_Category { get; set; }
        public double? BaseRate { get; set; }
        public double? Discount1 { get; set; }
        public double? cashPaid { get; set; }
        public double? ChequePaid { get; set; }
        public double? CreditCardPaid { get; set; }
        public double? CollectedAtHospital { get; set; }
        public decimal? UPIPaid { get; set; }
        public decimal? NEFTPAID { get; set; }
    }
}
