using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerResultregisterreport
    {
        public long PatientId { get; set; }
        public string PatientName { get; set; }
        public int? Labno { get; set; }
        public DateTime? PatientDate { get; set; }
        public string Rs { get; set; }
        public bool? Issent { get; set; }
        public int? TestmstTestTypeId { get; set; }
        public string TestTypeName { get; set; }
        public string PatientGender { get; set; }
        public string PatientAge { get; set; }
        public string DoctorName { get; set; }
        public string CenterName { get; set; }
        public DateTime? RegistationDate { get; set; }
        public string RegistationUser { get; set; }
        public DateTime? SampleReceivedDate { get; set; }
        public string SampleReceivedUser { get; set; }
        public DateTime? DataEntryDate { get; set; }
        public string DataEntryUser { get; set; }
        public DateTime? ValidateDate { get; set; }
        public string ValidateUser { get; set; }
        public DateTime? ResampleDate { get; set; }
        public string ResampleUser { get; set; }
        public DateTime? RerunDate { get; set; }
        public string RerunUser { get; set; }
        public DateTime? AuntheticateDate { get; set; }
        public string AuthenticateUser { get; set; }
        public DateTime? PrintDate { get; set; }
        public string PrintUser { get; set; }
    }
}
