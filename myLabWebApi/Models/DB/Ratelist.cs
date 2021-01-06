using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class RATELIST
    {
        public int Centerid { get; set; }
        public int TestId { get; set; }
        public double? TestRate { get; set; }
        public double? Discount { get; set; }
        public double? LumSumAmt { get; set; }
        public string SpecialTest { get; set; }
        public float? BaseRate { get; set; }
        public float? Discount1 { get; set; }
    }
}
