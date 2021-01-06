using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_SPECIALTESTS
    {
        public long? DOCHDR_lPatientId { get; set; }
        public double? NormalTests { get; set; }
        public double? SpecialTests { get; set; }
    }
}
