using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class NEXTGENDATA
    {
        public int? LAB_NO { get; set; }
        public DateTime? LAB_DATE { get; set; }
        public string WBC { get; set; }
        public string RBC { get; set; }
        public string HGB { get; set; }
        public string HCT { get; set; }
        public string MCV { get; set; }
        public string MCH { get; set; }
        public string MCHC { get; set; }
        public string RDW_CV { get; set; }
        public string PLT { get; set; }
        public string MPV { get; set; }
        public string PCT { get; set; }
        public string PDW { get; set; }
        public string LYMPH_PER { get; set; }
        public string MON_PER { get; set; }
        public string NEU_PER { get; set; }
        public string EOS_PER { get; set; }
        public string BAS_PER { get; set; }
        public string GRAN_PER { get; set; }
        public string MID_PER { get; set; }
        public string GRAN_NUM { get; set; }
        public string LYMPH_NUM { get; set; }
        public string RDW_SD { get; set; }
        public string MID_NUM { get; set; }
        public byte[] WBC_HISTOGRAM { get; set; }
        public byte[] RBC_HISTOGRAM { get; set; }
        public byte[] PLT_HISTOGRAM { get; set; }
        public string STATUS { get; set; }
    }
}
