using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class qer_paidrefund
    {
        public int? Patientid { get; set; }
        public int? TotalAmountPaid { get; set; }
        public int? TotalRefund { get; set; }
    }
}
