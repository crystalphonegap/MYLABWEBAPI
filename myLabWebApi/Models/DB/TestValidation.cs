using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class TestValidation
    {
        public int? TestmstCurrentId { get; set; }
        public decimal? TotalVal { get; set; }
        public string FieldNos { get; set; }
        public string Msg { get; set; }
    }
}
