using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models
{
    public class PaymentModel
    {
        public long Patientid { get; set; }
        public int labno { get; set; }
        public string Sample_Date { get; set; }
        public string DOCTOR_Name { get; set; }
        public string TotalAmount { get; set; }
        public string PATIENT_Name { get; set; }
        public string CENTER_Name { get; set; }
        public string AmountPaid { get; set; }
        public string BalanceAmount { get; set; } 
    }
}
