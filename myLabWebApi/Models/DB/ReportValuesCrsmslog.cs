﻿using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class ReportValuesCrsmslog
    {
        public decimal Autoid { get; set; }
        public long Patientid { get; set; }
        public string Type { get; set; }
    }
}
