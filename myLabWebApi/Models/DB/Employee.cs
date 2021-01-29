using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class EMPLOYEE
    {
        public int EMPLOYEE_id { get; set; }
        public string EMPLOYEE_Name { get; set; }
        public string EMPLOYEE_Address1 { get; set; }
        public string EMPLOYEE_Address2 { get; set; }
        public string EMPLOYEE_City { get; set; }
        public string EMPLOYEE_State { get; set; }
        public string EMPLOYEE_Region { get; set; }
        public string EMPLOYEE_Country { get; set; }
        public string EMPLOYEE_Pincode { get; set; }
        public string EMPLOYEE_Telno { get; set; }
        public string EMPLOYEE_MobileNo { get; set; }
        public string EMPLOYEE_Email { get; set; }
        public DateTime EMPLOYEE_DateofBirth { get; set; }
        public DateTime EMPLOYEE_DateofJoining { get; set; }
        public string EMPLOYEE_Qualification { get; set; }
        public double? EMPLOYEE_Salary { get; set; }
        public string EMPLOYEE_Gender { get; set; }
        public string EMPLOYEE_Status { get; set; }
        public int? EMPLOYEE_Companyid { get; set; }
        public bool? EMPLOYEE_Salary_Mode { get; set; }
        public bool? CollectionBoy_Flag { get; set; }
        public int? LabID { get; set; }
        public string Password { get; set; }
    }
}
