using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class DOCHDR_HISTORY
    {
        public long AutoID { get; set; }
        public int HISTORY_ID { get; set; }
        public int DOCHDR_lDocumentId { get; set; }
        public string DOCHDR_sDocNo { get; set; }
        public int? DOCHDR_lPatientId { get; set; }
        public int? DOCHDR_lDoctorId { get; set; }
        public string DOCHDR_sDescription { get; set; }
        public DateTime? DOCHDR_dDate { get; set; }
        public int? DOCHDR_TestCatID { get; set; }
        public string DOCHDR_Sex { get; set; }
        public string DOCHDR_Age { get; set; }
        public int? DOCHDR_Sample { get; set; }
        public double? DOCHDR_Rate { get; set; }
        public bool DOCHDR_bCommission { get; set; }
        public int? DOCHDR_lEmployeeId { get; set; }
        public short? NoOfPrintOuts { get; set; }
        public string MarkComplete { get; set; }
        public int? Doctorid2 { get; set; }
        public int? labno { get; set; }
        public string WardNo { get; set; }
        public string HOSPTYPE { get; set; }
        public DateTime? Sample_Date { get; set; }
        public string userid { get; set; }
        public DateTime? Currentdate { get; set; }
        public int? ProfileId { get; set; }
        public string IsProfile { get; set; }
        public string DOCHDR_AgeFlag { get; set; }
        public string DOCHDR_PID { get; set; }
        public bool? issent { get; set; }
        public bool? issampleReceived { get; set; }
        public bool? isAllResRec { get; set; }
        public string flag_u { get; set; }
    }
}
