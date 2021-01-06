using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_PENDING_TEST
    {
        public int? intRecords { get; set; }
        public int? IntPrintOuts { get; set; }
        public long? DOCHDR_lPatientId { get; set; }
        public DateTime? DOCHDR_dDate { get; set; }
        public int? labno { get; set; }
        public string PATIENT_Name { get; set; }
        public string TESTMST_Name { get; set; }
        public string DOCTOR_Name { get; set; }
    }
}
