using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_PAYMENTSTYPE
    {
        public long PATIENT_id { get; set; }
        public string PATIENT_Name { get; set; }
        public int? labno { get; set; }
        public DateTime? PATIENT_Date { get; set; }
        public double? BillAmount { get; set; }
        public string DOCTOR_Name { get; set; }
        public string CENTER_Name { get; set; }
        public int? CENTER_id { get; set; }
        public string CENTER_Region { get; set; }
        public int? Patientid { get; set; }
        public int? TotalAmountPaid { get; set; }
        public int? CashPaid { get; set; }
        public int? ChequePaid { get; set; }
        public int? CreditCardPaid { get; set; }
        public int? COLLECTEDAtHospitalPaid { get; set; }
        public int? UPIPaid { get; set; }
        public int? NEFTPaid { get; set; }
    }
}
