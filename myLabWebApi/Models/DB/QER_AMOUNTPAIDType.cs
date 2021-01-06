using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_AMOUNTPAIDType
    {
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
