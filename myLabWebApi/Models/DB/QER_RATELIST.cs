using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_RATELIST
    {
        public string TESTMST_Name { get; set; }
        public double? TestRate { get; set; }
        public double? Discount { get; set; }
        public int? Centerid { get; set; }
        public string Type { get; set; }
        public string TestTypeName { get; set; }
        public int? TestId { get; set; }
        public float? BaseRate { get; set; }
        public float? Discount1 { get; set; }
    }
}
