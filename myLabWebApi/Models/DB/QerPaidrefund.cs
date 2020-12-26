using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerPaidrefund
    {
        public int? Patientid { get; set; }
        public int? TotalAmountPaid { get; set; }
        public int? TotalRefund { get; set; }
    }
}
