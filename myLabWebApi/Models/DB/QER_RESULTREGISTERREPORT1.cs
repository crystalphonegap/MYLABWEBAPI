using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_RESULTREGISTERREPORT1
    {
        public long PATIENT_id { get; set; }
        public string PATIENT_Name { get; set; }
        public int? labno { get; set; }
        public DateTime? PATIENT_Date { get; set; }
        public string rs { get; set; }
        public int? TestCatID { get; set; }
    }
}
