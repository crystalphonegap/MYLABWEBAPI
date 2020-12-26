using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerResultregisterreportsms
    {
        public long PatientId { get; set; }
        public string PatientName { get; set; }
        public int? Labno { get; set; }
        public DateTime? PatientDate { get; set; }
        public string Rs { get; set; }
        public string DoctorName { get; set; }
        public string DoctorMobileNo { get; set; }
        public int DochdrLDocumentId { get; set; }
        public int? DochdrTestCatId { get; set; }
        public string TestmstAlias { get; set; }
        public int DoctorId { get; set; }
        public int CenterId { get; set; }
        public string CenterName { get; set; }
        public string CenterTelno { get; set; }
        public string PatientTelno { get; set; }
        public string TestdetSUnit { get; set; }
        public int? TotRepCount { get; set; }
        public int? TotalMarkCompleteCount { get; set; }
    }
}
