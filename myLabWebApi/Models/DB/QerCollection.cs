using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerCollection
    {
        public long? DochdrLPatientId { get; set; }
        public string TestmstName { get; set; }
        public double? DochdrRate { get; set; }
        public string TestmstAlias { get; set; }
        public short? NoOfPrintOuts { get; set; }
        public DateTime? DochdrDDate { get; set; }
        public string IsProfile { get; set; }
        public int? ProfileId { get; set; }
    }
}
