using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_PATIENT_HISTORY
    {
        public int History_Id { get; set; }
        public int PATIENT_id { get; set; }
        public string PATIENT_Name { get; set; }
        public DateTime? PATIENT_Date { get; set; }
        public int? labno { get; set; }
        public double? TotalAmount { get; set; }
        public double? EmergencyCharges { get; set; }
        public double? Discount { get; set; }
        public string PATIENT_State { get; set; }
        public DateTime? Currentdate { get; set; }
        public string userid { get; set; }
        public string Remarks { get; set; }
        public DateTime History_date { get; set; }
        public string flag { get; set; }
        public string TESTMST_Name { get; set; }
        public double? DOCHDR_Rate { get; set; }
    }
}
