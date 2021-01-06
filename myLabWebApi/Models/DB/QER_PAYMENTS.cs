using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_PAYMENTS
    {
        public long PATIENT_id { get; set; }
        public string PATIENT_Name { get; set; }
        public int? labno { get; set; }
        public DateTime? PATIENT_Date { get; set; }
        public double? BillAmount { get; set; }
        public int? TotalAmountPaid { get; set; }
        public string DOCTOR_Name { get; set; }
        public string CENTER_Name { get; set; }
        public int? CENTER_id { get; set; }
        public string CENTER_Region { get; set; }
    }
}
