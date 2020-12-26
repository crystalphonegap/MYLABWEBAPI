using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerPendingTestsNew
    {
        public int DochdrLDocumentId { get; set; }
        public string TestmstName { get; set; }
        public string Type { get; set; }
        public long? DochdrLPatientId { get; set; }
        public int TestmstCurrentId { get; set; }
        public string TestmstAlias { get; set; }
        public double? TestmstRate { get; set; }
    }
}
