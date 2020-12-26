using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class Amountpaid
    {
        public int Paymentid { get; set; }
        public int? Patientid { get; set; }
        public DateTime? PayDate { get; set; }
        public int? AmountPaid1 { get; set; }
        public string Userid { get; set; }
        public DateTime? CurrentDate { get; set; }
        public string Remark { get; set; }
        public string Paymode { get; set; }
    }
}
