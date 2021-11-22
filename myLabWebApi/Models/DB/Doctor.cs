using System;

namespace myLabWebApi.Models.New
{
    public partial class DOCTOR
    {
        public int DOCTOR_id { get; set; }
        public string DOCTOR_Name { get; set; }
        public string DOCTOR_Address1 { get; set; }
        public string DOCTOR_Address2 { get; set; }
        public string DOCTOR_City { get; set; }
        public string DOCTOR_State { get; set; }
        public string TDS { get; set; }
        public string DOCTOR_Bill { get; set; }
        public string DOCTOR_Pincode { get; set; }
        public string DOCTOR_Telno { get; set; }
        public string DOCTOR_MobileNo { get; set; }
        public string DOCTOR_Email { get; set; }
        public string DOCTOR_Qualification { get; set; }
        public string OFFICE_Address1 { get; set; }
        public string OFFICE_Address2 { get; set; }
        public string OFFICE_City { get; set; }
        public string OFFICE_State { get; set; }
        public string OFFICE_Region { get; set; }
        public string OFFICE_Country { get; set; }
        public string OFFICE_Pincode { get; set; }
        public string OFFICE_Telno { get; set; }
        public string OFFICE_url { get; set; }
        public double? DOCTOR_Commission { get; set; }
        public int? DOCTOR_Companyid { get; set; }
        public bool? DOCTOR_Permanent { get; set; }
        public double? DOCTOR_XCommission { get; set; }
        public int? DOCTOR_SCommission { get; set; }
        public double? DOCTOR_RCommission { get; set; }
        public double? DOCTOR_PFCommission { get; set; }
        public double? DOCTOR_SPCommission { get; set; }
        public double? DOCTOR_MCommission { get; set; }
        public double? DOCTOR_OCommission { get; set; }
        public double? DOCTOR_HCommission { get; set; }
        public double? DOCTOR_EXCommission { get; set; }
        public double? DOCTOR_EX1Commission { get; set; }
        public bool? SendSMS { get; set; }
        public string DOCTOR_UserName { get; set; }
        public string DOCTOR_Password { get; set; }
        public string Password { get; set; }
        public DateTime? DOB { get; set; }
        public string doctor_Code { get; set; }
        public string CENTER_Name { get; set; }
        public int Collection_Center { get; set; }
        public string DOCTOR_Country { get; set; }
       
        public string OFFICE_Area { get; set; }
        public string DOCTOR_Area { get; set; }
    }
}