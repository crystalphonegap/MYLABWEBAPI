using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorAddress1 { get; set; }
        public string DoctorAddress2 { get; set; }
        public string DoctorCity { get; set; }
        public string DoctorState { get; set; }
        public string Tds { get; set; }
        public string DoctorBill { get; set; }
        public string DoctorPincode { get; set; }
        public string DoctorTelno { get; set; }
        public string DoctorMobileNo { get; set; }
        public string DoctorEmail { get; set; }
        public string DoctorQualification { get; set; }
        public string OfficeAddress1 { get; set; }
        public string OfficeAddress2 { get; set; }
        public string OfficeCity { get; set; }
        public string OfficeState { get; set; }
        public string OfficeRegion { get; set; }
        public string OfficeCountry { get; set; }
        public string OfficePincode { get; set; }
        public string OfficeTelno { get; set; }
        public string OfficeUrl { get; set; }
        public double? DoctorCommission { get; set; }
        public int? DoctorCompanyid { get; set; }
        public bool? DoctorPermanent { get; set; }
        public double? DoctorXcommission { get; set; }
        public int? DoctorScommission { get; set; }
        public double? DoctorRcommission { get; set; }
        public double? DoctorPfcommission { get; set; }
        public double? DoctorSpcommission { get; set; }
        public double? DoctorMcommission { get; set; }
        public double? DoctorOcommission { get; set; }
        public double? DoctorHcommission { get; set; }
        public double? DoctorExcommission { get; set; }
        public double? DoctorEx1commission { get; set; }
        public bool? SendSms { get; set; }
        public string DoctorUserName { get; set; }
        public string DoctorPassword { get; set; }
        public string Password { get; set; }
        public DateTime? Dob { get; set; }
        public string DoctorCode { get; set; }
        public string CollectionCenter { get; set; }
    }
}
