using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models
{
    public class AmountPaidModel 
    {
        public int Paymentid { get; set; }   
        public string userid { get; set; } 
        public string Remark { get; set; }
        public string Paymode { get; set; }
        public string UserName { get; set; }
        public string PaymentMode { get; set; }
        public int? Patientid { get; set; }
        public DateTime? PayDate { get; set; }
        public int? AmountPaid { get; set; }
        public DateTime? CurrentDate { get; set; }
    }
}
