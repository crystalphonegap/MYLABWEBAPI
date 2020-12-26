using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class Company
    {
        public int? CompanySetupid { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress1 { get; set; }
        public string CompanyAddress2 { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyState { get; set; }
        public string CompanyPostalCode { get; set; }
        public string CompanyCountry { get; set; }
        public string CompanyPhoneNumber { get; set; }
        public string CompanyFaxnumber { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyUrl { get; set; }
        public string CompanyDataLoc { get; set; }
        public string CompanyUsername { get; set; }
        public string CompanyPassword { get; set; }
        public string CompanyReportLoc { get; set; }
        public string CompanyPathologist1 { get; set; }
        public string CompanyPathologist2 { get; set; }
        public string CompanyPathologist3 { get; set; }
        public string CompanyPathoDegree1 { get; set; }
        public string CompanyPathoDegree2 { get; set; }
        public string CompanyPathoDegree3 { get; set; }
        public string CompanyRadiologist1 { get; set; }
        public string CompanyRadiologist2 { get; set; }
        public string CompanyRadiologist3 { get; set; }
        public string CompanyRadDegree1 { get; set; }
        public string CompanyRadDegree2 { get; set; }
        public string CompanyRadDegree3 { get; set; }
        public string CompanyCardiologist1 { get; set; }
        public string CompanyCardiologist2 { get; set; }
        public string CompanyCardiologist3 { get; set; }
        public string CompanyCardDegree1 { get; set; }
        public string CompanyCardDegree2 { get; set; }
        public string CompanyCardDegree3 { get; set; }
        public string CompanySonoLogist { get; set; }
        public string CompanySonoDegree { get; set; }
        public string CompanyAbnormal { get; set; }
        public double? CompanyTopMargin { get; set; }
        public double? CompanyBotMargin { get; set; }
        public string Remarks { get; set; }
        public short? CompanyPaperSize { get; set; }
        public string CompanySeries { get; set; }
    }
}
