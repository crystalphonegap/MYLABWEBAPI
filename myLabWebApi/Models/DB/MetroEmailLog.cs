using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class MetroEmailLog
    {
        public long Logid { get; set; }
        public long Patientid { get; set; }
        public string VID { get; set; }
        public string Time { get; set; }
        public string PDFName { get; set; }
        public DateTime SysDate { get; set; }
    }
}
