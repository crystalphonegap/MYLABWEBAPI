using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class PatientMaster
    {
        public long PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientAddress1 { get; set; }
        public string PatientAddress2 { get; set; }
        public string PatientCity { get; set; }
        public string PatientState { get; set; }
        public string PatientRegion { get; set; }
        public string PatientCountry { get; set; }
        public string PatientPincode { get; set; }
        public string PatientTelno { get; set; }
        public string PatientMobileNo { get; set; }
        public string PatientEmail { get; set; }
        public string PatientAge { get; set; }
        public string PatientDateofJoining { get; set; }
        public string PatientQualification { get; set; }
        public double? PatientSalary { get; set; }
        public short? PatientGender { get; set; }
        public short? PatientStatus { get; set; }
        public int? PatientCompanyid { get; set; }
        public string PatientSalaryType { get; set; }
        public long? PatientDoctorId { get; set; }
        public string PatientCode { get; set; }
        public DateTime? PatientDateofBirth { get; set; }
        public int? CenterId { get; set; }
    }
}
