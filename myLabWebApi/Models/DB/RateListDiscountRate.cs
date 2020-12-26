using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class RateListDiscountRate
    {
        public int? RateListId { get; set; }
        public string TestCategory { get; set; }
        public double? DiscountPer { get; set; }
    }
}
