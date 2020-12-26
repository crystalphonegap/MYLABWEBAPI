using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerCbcWorkSheet
    {
        public int? DochdrLDocumentId { get; set; }
        public long PatientId { get; set; }
        public string PatientName { get; set; }
        public int? DocdetLFieldNo { get; set; }
        public string DocdetTFieldValue { get; set; }
        public int? DochdrTestCatId { get; set; }
        public string DochdrSex { get; set; }
        public string DochdrAge { get; set; }
        public int? Labno { get; set; }
        public DateTime? DochdrDDate { get; set; }
        public string TestdetSAlias { get; set; }
        public string TestdetFieldName { get; set; }
        public int? DochdrLDoctorId { get; set; }
    }
}
