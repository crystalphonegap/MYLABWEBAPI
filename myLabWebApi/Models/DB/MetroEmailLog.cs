using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class MetroEmailLog
    {
        public long Logid { get; set; }
        public long Patientid { get; set; }
        public string Vid { get; set; }
        public string Time { get; set; }
        public string Pdfname { get; set; }
        public DateTime SysDate { get; set; }
    }
}
