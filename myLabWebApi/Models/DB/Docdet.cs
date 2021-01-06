using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class DOCDET
    {
        public int DOCDET_lHeaderId { get; set; }
        public int DOCDET_lFieldNo { get; set; }
        public string DOCDET_tFieldValue { get; set; }
        public int? DOCDET_lTestCatId { get; set; }
        public string DOCDET_tFieldValue1 { get; set; }
        public bool? isResRec { get; set; }
        public bool? Rerun { get; set; }
        public string NormalValue { get; set; }
        public string sUnit { get; set; }
        public double? MinValue { get; set; }
        public double? MaxValue { get; set; }
        public double? MinLimit { get; set; }
        public double? MaxLimit { get; set; }
        public string LowH_High { get; set; }
        public string ValueForNormal { get; set; }
    }
}
