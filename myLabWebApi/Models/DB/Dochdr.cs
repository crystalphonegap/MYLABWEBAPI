using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class Dochdr
    {
        public int DochdrLDocumentId { get; set; }
        public string DochdrSDocNo { get; set; }
        public long? DochdrLPatientId { get; set; }
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
        public float? BaseRate { get; set; }
        public float? Discount { get; set; }
        public DateTime? RegistationDate { get; set; }
        public string RegistationUser { get; set; }
        public DateTime? SampleReceivedDate { get; set; }
        public string SampleReceivedUser { get; set; }
        public DateTime? DataEntryDate { get; set; }
        public string DataEntryUser { get; set; }
        public DateTime? ValidateDate { get; set; }
        public string ValidateUser { get; set; }
        public DateTime? ResampleDate { get; set; }
        public string ResampleUser { get; set; }
        public DateTime? RerunDate { get; set; }
        public string RerunUser { get; set; }
        public DateTime? AuntheticateDate { get; set; }
        public string AuthenticateUser { get; set; }
        public DateTime? PrintDate { get; set; }
        public string PrintUser { get; set; }
        public DateTime? Pdfdate { get; set; }
        public string Pdfuser { get; set; }
        public DateTime? EmailDate { get; set; }
        public string EmailUser { get; set; }
        public string SampleReceivedRemark { get; set; }
        public string LableSample { get; set; }
        public DateTime? RequestDate { get; set; }
        public string RequestUser { get; set; }
        public DateTime? IntegrationDate { get; set; }
    }
}
