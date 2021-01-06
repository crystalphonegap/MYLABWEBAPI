using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class AbnormalSMSLog
    {
        public long LogId { get; set; }
        public string PATIENT_Name { get; set; }
        public DateTime? PATIENT_Date { get; set; }
        public string PATIENT_Telno { get; set; }
        public string TemplateName { get; set; }
        public string SMS { get; set; }
        public DateTime? LastSMSDate { get; set; }
        public string sysFlag { get; set; }
        public DateTime? SysDate { get; set; }
        public DateTime? SysDateTime { get; set; }
    }
}
