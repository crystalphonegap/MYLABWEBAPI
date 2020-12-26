using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class Ratelisthdr
    {
        public int RateListId { get; set; }
        public string RateListName { get; set; }
        public DateTime SysDate { get; set; }
        public string SysUser { get; set; }
        public double? Routine { get; set; }
        public double? Special { get; set; }
        public double? Microbiology { get; set; }
        public double? Outside { get; set; }
        public double? Histo { get; set; }
        public double? Other { get; set; }
        public double? Other1 { get; set; }
    }
}
