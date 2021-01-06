using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_RESULTREGISTERREPORTSMS
    {
        public long PATIENT_id { get; set; }
        public string PATIENT_Name { get; set; }
        public int? labno { get; set; }
        public DateTime? PATIENT_Date { get; set; }
        public string rs { get; set; }
        public string DOCTOR_Name { get; set; }
        public string DOCTOR_MobileNo { get; set; }
        public int DOCHDR_lDocumentId { get; set; }
        public int? DOCHDR_TestCatID { get; set; }
        public string TESTMST_Alias { get; set; }
        public int DOCTOR_id { get; set; }
        public int CENTER_id { get; set; }
        public string CENTER_Name { get; set; }
        public string CENTER_Telno { get; set; }
        public string PATIENT_Telno { get; set; }
        public string TESTDET_sUnit { get; set; }
        public int? TotRepCount { get; set; }
        public int? TotalMarkCompleteCount { get; set; }
    }
}
