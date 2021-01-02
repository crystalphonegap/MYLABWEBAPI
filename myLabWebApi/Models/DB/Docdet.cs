using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class Docdet
    {
        public int DocdetLHeaderId { get; set; }
        public int DocdetLFieldNo { get; set; }
        public string DocdetTFieldValue { get; set; }
        public int? DocdetLTestCatId { get; set; }
        public string DocdetTFieldValue1 { get; set; }
        public bool? IsResRec { get; set; }
        public bool? Rerun { get; set; }
        public string NormalValue { get; set; }
        public string SUnit { get; set; }
        public double? MinValue { get; set; }
        public double? MaxValue { get; set; }
        public double? MinLimit { get; set; }
        public double? MaxLimit { get; set; }
        public string LowHHigh { get; set; }
        public string ValueForNormal { get; set; }
    }
}
