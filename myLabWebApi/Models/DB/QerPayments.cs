using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerPayments
    {
        public long PatientId { get; set; }
        public string PatientName { get; set; }
        public int? Labno { get; set; }
        public DateTime? PatientDate { get; set; }
        public double? BillAmount { get; set; }
        public int? TotalAmountPaid { get; set; }
        public string DoctorName { get; set; }
        public string CenterName { get; set; }
        public int? CenterId { get; set; }
        public string CenterRegion { get; set; }
    }
}
