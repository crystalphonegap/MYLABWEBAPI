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
        public decimal BaseRate { get; set; }
        public decimal Referal_Fee { get; set; }
        public decimal Discount { get; set; }
        public decimal Discount1 { get; set; }
        public decimal TestRate { get; set; }
        public decimal LumSumAmt { get; set; }
        public bool SpecialTest { get; set; }
        public string Type { get; set; }
        public int CENTER_id { get; set; }
        public string CENTER_Name { get; set; }
    }
}
