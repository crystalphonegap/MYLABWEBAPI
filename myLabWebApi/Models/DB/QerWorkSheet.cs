using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerWorkSheet
    {
        public long? DochdrLPatientId { get; set; }
        public string PatientName { get; set; }
        public DateTime? DochdrDDate { get; set; }
        public int? Labno { get; set; }
        public int? TestmstTestTypeId { get; set; }
        public string TestmstAlias { get; set; }
        public string TestTypeName { get; set; }
        public string DoctorName { get; set; }
        public string PatientGender { get; set; }
        public string PatientAge { get; set; }
        public string PatientAgeFlag { get; set; }
    }
}
