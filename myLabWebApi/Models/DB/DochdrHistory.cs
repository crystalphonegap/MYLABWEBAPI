using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class DochdrHistory
    {
        public long AutoId { get; set; }
        public int HistoryId { get; set; }
        public int DochdrLDocumentId { get; set; }
        public string DochdrSDocNo { get; set; }
        public int? DochdrLPatientId { get; set; }
        public int? DochdrLDoctorId { get; set; }
        public string DochdrSDescription { get; set; }
        public DateTime? DochdrDDate { get; set; }
        public int? DochdrTestCatId { get; set; }
        public string DochdrSex { get; set; }
        public string DochdrAge { get; set; }
        public int? DochdrSample { get; set; }
        public double? DochdrRate { get; set; }
        public bool DochdrBCommission { get; set; }
        public int? DochdrLEmployeeId { get; set; }
        public short? NoOfPrintOuts { get; set; }
        public string MarkComplete { get; set; }
        public int? Doctorid2 { get; set; }
        public int? Labno { get; set; }
        public string WardNo { get; set; }
        public string Hosptype { get; set; }
        public DateTime? SampleDate { get; set; }
        public string Userid { get; set; }
        public DateTime? Currentdate { get; set; }
        public int? ProfileId { get; set; }
        public string IsProfile { get; set; }
        public string DochdrAgeFlag { get; set; }
        public string DochdrPid { get; set; }
        public bool? Issent { get; set; }
        public bool? IssampleReceived { get; set; }
        public bool? IsAllResRec { get; set; }
        public string FlagU { get; set; }
    }
}
