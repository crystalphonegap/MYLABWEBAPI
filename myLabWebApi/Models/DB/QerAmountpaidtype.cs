using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerAmountpaidtype
    {
        public int? Patientid { get; set; }
        public int? TotalAmountPaid { get; set; }
        public int? CashPaid { get; set; }
        public int? ChequePaid { get; set; }
        public int? CreditCardPaid { get; set; }
        public int? CollectedatHospitalPaid { get; set; }
        public int? Upipaid { get; set; }
        public int? Neftpaid { get; set; }
    }
}
