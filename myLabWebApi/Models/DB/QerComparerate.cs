using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerComparerate
    {
        public string TestmstName { get; set; }
        public double? TestRate { get; set; }
        public double? Discount { get; set; }
        public int Centerid { get; set; }
        public string Type { get; set; }
        public string CenterName { get; set; }
    }
}
