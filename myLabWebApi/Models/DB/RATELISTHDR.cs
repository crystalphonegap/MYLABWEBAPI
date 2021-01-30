using System;

namespace myLabWebApi.Models.New
{
    public partial class RATELISTHDR
    {
        public int RateListId { get; set; }
        public string RateListName { get; set; }
        public DateTime SysDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string SysUser { get; set; }
        public double? Routine { get; set; }
        public double? Special { get; set; }
        public double? Microbiology { get; set; }
        public double Outside { get; set; }
        public double? Histo { get; set; }
        public double? other { get; set; }
        public double? other1 { get; set; }
    }

    public partial class RATELISTHDRSAVEAS
    {
        public int RateListId { get; set; }
        public string RateListName { get; set; }
        public string SysUser { get; set; }
    }
}