using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_COMPARERATE
    {
        public string TESTMST_Name { get; set; }
        public double? TestRate { get; set; }
        public double? Discount { get; set; }
        public int Centerid { get; set; }
        public string Type { get; set; }
        public string CENTER_Name { get; set; }
    }
}
