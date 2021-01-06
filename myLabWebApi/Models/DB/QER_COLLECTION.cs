using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_COLLECTION
    {
        public long? DOCHDR_lPatientId { get; set; }
        public string TESTMST_Name { get; set; }
        public double? DOCHDR_Rate { get; set; }
        public string TESTMST_Alias { get; set; }
        public short? NoOfPrintOuts { get; set; }
        public DateTime? DOCHDR_dDate { get; set; }
        public string IsProfile { get; set; }
        public int? ProfileId { get; set; }
    }
}
