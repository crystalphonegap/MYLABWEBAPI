using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerResultregisterreport1
    {
        public long PatientId { get; set; }
        public string PatientName { get; set; }
        public int? Labno { get; set; }
        public DateTime? PatientDate { get; set; }
        public string Rs { get; set; }
        public int? TestCatId { get; set; }
    }
}
