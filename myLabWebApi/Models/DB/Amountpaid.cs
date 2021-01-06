using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class AMOUNTPAID
    {
        public int Paymentid { get; set; }
        public int? Patientid { get; set; }
        public DateTime? PayDate { get; set; }
        public int? AmountPaid1 { get; set; }
        public string userid { get; set; }
        public DateTime? CurrentDate { get; set; }
        public string Remark { get; set; }
        public string Paymode { get; set; }
    }
}
