using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_RESULTREGISTERREPORT
    {
        public long PATIENT_id { get; set; }
        public string PATIENT_Name { get; set; }
        public int? labno { get; set; }
        public DateTime? PATIENT_Date { get; set; }
        public string rs { get; set; }
        public bool? issent { get; set; }
        public int? TESTMST_TestTypeId { get; set; }
        public string TestTypeName { get; set; }
        public string PATIENT_Gender { get; set; }
        public string PATIENT_Age { get; set; }
        public string DOCTOR_Name { get; set; }
        public string CENTER_Name { get; set; }
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
