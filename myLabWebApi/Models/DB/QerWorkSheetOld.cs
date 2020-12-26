using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerWorkSheetOld
    {
        public int? DochdrLPatientId { get; set; }
        public string PatientName { get; set; }
        public DateTime? DochdrDDate { get; set; }
        public int? Labno { get; set; }
        public int? TestmstTestTypeId { get; set; }
        public string TestmstAlias { get; set; }
        public string TestTypeName { get; set; }
    }
}
