using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class AbnormalSmslog
    {
        public long LogId { get; set; }
        public string PatientName { get; set; }
        public DateTime? PatientDate { get; set; }
        public string PatientTelno { get; set; }
        public string TemplateName { get; set; }
        public string Sms { get; set; }
        public DateTime? LastSmsdate { get; set; }
        public string SysFlag { get; set; }
        public DateTime? SysDate { get; set; }
        public DateTime? SysDateTime { get; set; }
    }
}
