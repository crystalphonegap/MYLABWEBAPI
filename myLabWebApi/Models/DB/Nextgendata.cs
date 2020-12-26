using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class Nextgendata
    {
        public int? LabNo { get; set; }
        public DateTime? LabDate { get; set; }
        public string Wbc { get; set; }
        public string Rbc { get; set; }
        public string Hgb { get; set; }
        public string Hct { get; set; }
        public string Mcv { get; set; }
        public string Mch { get; set; }
        public string Mchc { get; set; }
        public string RdwCv { get; set; }
        public string Plt { get; set; }
        public string Mpv { get; set; }
        public string Pct { get; set; }
        public string Pdw { get; set; }
        public string LymphPer { get; set; }
        public string MonPer { get; set; }
        public string NeuPer { get; set; }
        public string EosPer { get; set; }
        public string BasPer { get; set; }
        public string GranPer { get; set; }
        public string MidPer { get; set; }
        public string GranNum { get; set; }
        public string LymphNum { get; set; }
        public string RdwSd { get; set; }
        public string MidNum { get; set; }
        public byte[] WbcHistogram { get; set; }
        public byte[] RbcHistogram { get; set; }
        public byte[] PltHistogram { get; set; }
        public string Status { get; set; }
    }
}
