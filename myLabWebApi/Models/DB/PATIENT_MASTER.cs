using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class PATIENT_MASTER
    {
        public long PATIENT_id { get; set; }
        public string PATIENT_Name { get; set; }
        public string PATIENT_Address1 { get; set; }
        public string PATIENT_Address2 { get; set; }
        public string PATIENT_City { get; set; }
        public string PATIENT_State { get; set; }
        public string PATIENT_Region { get; set; }
        public string PATIENT_Country { get; set; }
        public string PATIENT_Pincode { get; set; }
        public string PATIENT_Telno { get; set; }
        public string PATIENT_MobileNo { get; set; }
        public string PATIENT_Email { get; set; }
        public string Patient_Age { get; set; }
        public string PATIENT_DateofJoining { get; set; }
        public string PATIENT_Qualification { get; set; }
        public double? PATIENT_Salary { get; set; }
        public short? PATIENT_Gender { get; set; }
        public short? PATIENT_Status { get; set; }
        public int? PATIENT_Companyid { get; set; }
        public string PATIENT_SalaryType { get; set; }
        public long? PATIENT_DOCTOR_ID { get; set; }
        public string Patient_Code { get; set; }
        public DateTime? Patient_DateofBirth { get; set; }
        public int? Center_id { get; set; }
    }
}
