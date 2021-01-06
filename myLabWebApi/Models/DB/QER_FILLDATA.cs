using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_FILLDATA
    {
        public int DOCHDR_lDocumentId { get; set; }
        public string MarkComplete { get; set; }
        public string DOCHDR_sDocNo { get; set; }
        public string PATIENT_Name { get; set; }
        public int? labno { get; set; }
        public string DOCTOR_Name { get; set; }
        public DateTime? DOCHDR_dDate { get; set; }
        public string TESTMST_Name { get; set; }
        public string TESTMST_PrintFormat { get; set; }
        public string Type { get; set; }
        public long? DOCHDR_lPatientId { get; set; }
        public int TESTMST_CurrentId { get; set; }
        public int? DOCHDR_TestCatID { get; set; }
        public string ProfileName { get; set; }
        public int? TESTMST_TestTypeId { get; set; }
        public short? NoOfPrintOuts { get; set; }
        public string CENTER_Name { get; set; }
        public string DOCTOR_MobileNo { get; set; }
        public string PATIENT_Telno { get; set; }
        public int? Urgent { get; set; }
        public string WardNo { get; set; }
        public DateTime? EmailDate { get; set; }
    }
}
