using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models
{
    public class DOCDETModel
    {
        public long ID { get; set; }
        public int DOCDET_lHeaderId { get; set; }
        public int DOCDET_lFieldNo { get; set; }
        public string DOCDET_tFieldValue { get; set; }
        public int DOCDET_lTestCatId { get; set; }
        public string DOCDET_tFieldValue1 { get; set; }
        public bool isResRec { get; set; }
        public bool Rerun { get; set; }
        public string NormalValue { get; set; }
        public string sUnit { get; set; }
        public float MinValue { get; set; }
        public float MaxValue { get; set; }
        public float MinLimit { get; set; }
        public float MaxLimit { get; set; }
        public string Low_High { get; set; }
        public string ValueForNormal { get; set; }
    }
}
