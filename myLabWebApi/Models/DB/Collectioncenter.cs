using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class Collectioncenter
    {
        public int CenterId { get; set; }
        public string CenterName { get; set; }
        public string CenterAddress1 { get; set; }
        public string CenterAddress2 { get; set; }
        public string CenterCity { get; set; }
        public string CenterState { get; set; }
        public string CenterRegion { get; set; }
        public string CenterCountry { get; set; }
        public string CenterPincode { get; set; }
        public string CenterTelno { get; set; }
        public short? CenterStatus { get; set; }
        public int? CenterCompanyid { get; set; }
        public double? Percentage { get; set; }
        public string OutSourceLab { get; set; }
    }
}
