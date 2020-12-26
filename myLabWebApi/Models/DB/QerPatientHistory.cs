using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerPatientHistory
    {
        public int HistoryId { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public DateTime? PatientDate { get; set; }
        public int? Labno { get; set; }
        public double? TotalAmount { get; set; }
        public double? EmergencyCharges { get; set; }
        public double? Discount { get; set; }
        public string PatientState { get; set; }
        public DateTime? Currentdate { get; set; }
        public string Userid { get; set; }
        public string Remarks { get; set; }
        public DateTime HistoryDate { get; set; }
        public string Flag { get; set; }
        public string TestmstName { get; set; }
        public double? DochdrRate { get; set; }
    }
}
