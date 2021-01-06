using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_PendingTestsNew
    {
        public int DOCHDR_lDocumentId { get; set; }
        public string TESTMST_Name { get; set; }
        public string Type { get; set; }
        public long? DOCHDR_lPatientId { get; set; }
        public int TESTMST_CurrentId { get; set; }
        public string TESTMST_Alias { get; set; }
        public double? TESTMST_Rate { get; set; }
    }
}
