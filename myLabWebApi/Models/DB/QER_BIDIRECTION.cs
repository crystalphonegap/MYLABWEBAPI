using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_BIDIRECTION
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
        public int? TESTMST_CurrentId { get; set; }
        public int? DOCHDR_TestCatID { get; set; }
        public string ProfileName { get; set; }
        public int? ProfileId { get; set; }
        public short? NoOfPrintOuts { get; set; }
        public int? TESTMST_TestTypeId { get; set; }
        public string PATIENT_Gender { get; set; }
        public string PATIENT_Age { get; set; }
        public DateTime? Sample_Date { get; set; }
        public string WardNo { get; set; }
    }
}
