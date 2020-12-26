using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class Employee
    {
        public int? EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress1 { get; set; }
        public string EmployeeAddress2 { get; set; }
        public string EmployeeCity { get; set; }
        public string EmployeeState { get; set; }
        public string EmployeeRegion { get; set; }
        public string EmployeeCountry { get; set; }
        public string EmployeePincode { get; set; }
        public string EmployeeTelno { get; set; }
        public string EmployeeMobileNo { get; set; }
        public string EmployeeEmail { get; set; }
        public DateTime? EmployeeDateofBirth { get; set; }
        public DateTime? EmployeeDateofJoining { get; set; }
        public string EmployeeQualification { get; set; }
        public double? EmployeeSalary { get; set; }
        public short? EmployeeGender { get; set; }
        public short? EmployeeStatus { get; set; }
        public int? EmployeeCompanyid { get; set; }
        public string EmployeeSalaryType { get; set; }
        public bool? CollectionBoyFlag { get; set; }
        public int? LabId { get; set; }
        public string Password { get; set; }
    }
}
