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
    public class AmountPaidClass
    {
        public int PatientId { get; set; }
        public decimal AmountPaid { get; set; }
        public int UserId { get; set; }
        public int PAYMENTMODE { get; set; }
        public decimal CASHAMOUNT { get; set; }
        public string PAYDATE { get; set; }
    }
}
