using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models
{
    public class TestMaster
    {
        public int RateListHID { get; set; }
        public int TestId { get; set; }
        public string TESTMST_Name { get; set; }
        public double? BaseRate { get; set; }
        public double? Discount { get; set; }
        public double? Discount1 { get; set; }
        public double? TestRate { get; set; }
        public double? LumSumAmt { get; set; }
        public string SpecialTest { get; set; }
        public string Type { get; set; }
    }
}
