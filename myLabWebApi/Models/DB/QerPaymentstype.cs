using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerPaymentstype
    {
        public long PatientId { get; set; }
        public string PatientName { get; set; }
        public int? Labno { get; set; }
        public DateTime? PatientDate { get; set; }
        public double? BillAmount { get; set; }
        public string DoctorName { get; set; }
        public string CenterName { get; set; }
        public int? CenterId { get; set; }
        public string CenterRegion { get; set; }
        public int? Patientid1 { get; set; }
        public int? TotalAmountPaid { get; set; }
        public int? CashPaid { get; set; }
        public int? ChequePaid { get; set; }
        public int? CreditCardPaid { get; set; }
        public int? CollectedatHospitalPaid { get; set; }
        public int? Upipaid { get; set; }
        public int? Neftpaid { get; set; }
    }
}
