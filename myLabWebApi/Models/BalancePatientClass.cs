using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models
{
    public class BalancePatientClass
    {
        public int ROWNUM { get; set; }
        public int PATIENT_ID { get; set; }
        public int PATIENTNO { get; set; }
        public string PATIENT_Name { get; set; }

        public string LABNO { get; set; }
        public string PATIENT_DATE { get; set; }
        public string DOCTOR_Name { get; set; }

        public string CENTER_Name { get; set; }
        public string CollectionCenterId { get; set; }
        public string TotalAmount { get; set; }
        public string AMOUNTPAID { get; set; }
        public string BALANCEAMOUNT { get; set; }



    }
    public class PaymentSearchFilters
    {
       
        public string Keyword { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string UserId { get; set; }
        public string Type { get; set; }
    }

}
