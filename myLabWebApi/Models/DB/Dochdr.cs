using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class DOCHDR
    {
        public int DOCHDR_lDocumentId { get; set; }
        public string DOCHDR_sDocNo { get; set; }
        public long? DOCHDR_lPatientId { get; set; }
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
        public DateTime? PDFDate { get; set; }
        public string PDFUser { get; set; }
        public DateTime? EmailDate { get; set; }
        public string EmailUser { get; set; }
        public string SampleReceivedRemark { get; set; }
        public string Lable_Sample { get; set; }
        public DateTime? RequestDate { get; set; }
        public string RequestUser { get; set; }
        public DateTime? IntegrationDate { get; set; }
    }
}
