using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerSpecialtests
    {
        public long? DochdrLPatientId { get; set; }
        public double? NormalTests { get; set; }
        public double? SpecialTests { get; set; }
    }
}
