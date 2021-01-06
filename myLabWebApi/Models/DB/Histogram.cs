using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class HISTOGRAM
    {
        public int? DOCHDR_lDocumentID { get; set; }
        public int? DOCHDR_lPatientId { get; set; }
        public byte[] WBC_HISTO { get; set; }
        public byte[] RBC_HISTO { get; set; }
        public byte[] PLT_HISTO { get; set; }
        public int? LAB_NO { get; set; }
        public DateTime? LAB_DATE { get; set; }
        public string STATUS { get; set; }
        public decimal SRNO { get; set; }
    }
}
