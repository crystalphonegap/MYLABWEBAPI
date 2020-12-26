using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerPendingTest
    {
        public int? IntRecords { get; set; }
        public int? IntPrintOuts { get; set; }
        public long? DochdrLPatientId { get; set; }
        public DateTime? DochdrDDate { get; set; }
        public int? Labno { get; set; }
        public string PatientName { get; set; }
        public string TestmstName { get; set; }
        public string DoctorName { get; set; }
    }
}
