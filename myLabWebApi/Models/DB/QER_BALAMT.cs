using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_BALAMT
    {
        public long PATIENT_id { get; set; }
        public string PATIENT_Name { get; set; }
        public int? labno { get; set; }
        public DateTime? PATIENT_Date { get; set; }
        public double? BillAmount { get; set; }
        public int? TotalAmountPaid { get; set; }
        public double? BalanceAmt { get; set; }
        public string DOCTOR_Name { get; set; }
        public string CENTER_Name { get; set; }
        public int? CENTER_id { get; set; }
        public string CENTER_Region { get; set; }
        public string PATIENT_Pincode { get; set; }
        public string TEST_ALIAS { get; set; }
        public int? Urgent { get; set; }
        public string DOCTOR_MobileNo { get; set; }
    }
}
