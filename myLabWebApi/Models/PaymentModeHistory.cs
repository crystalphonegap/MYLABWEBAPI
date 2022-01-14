
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models
{
    public class PaymentModeHistory
    {
        public int Patientid { get; set; }
        public DateTime? PayDate { get; set; }
        public int? AmountPaid { get; set; }
        public string PaymentMode { get; set; }
        public string UserName { get; set; }
    }
}
