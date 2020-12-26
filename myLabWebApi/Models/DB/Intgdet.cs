using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class Intgdet
    {
        public long Id { get; set; }
        public long? Patientid { get; set; }
        public int HeaderId { get; set; }
        public int FieldNo { get; set; }
        public string FieldValue { get; set; }
        public int TestCatId { get; set; }
        public DateTime? SysDateTime { get; set; }
        public long? DocNo { get; set; }
    }
}
