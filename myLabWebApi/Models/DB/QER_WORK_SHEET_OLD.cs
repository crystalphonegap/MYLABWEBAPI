﻿using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_WORK_SHEET_OLD
    {
        public int? DOCHDR_lPatientId { get; set; }
        public string PATIENT_Name { get; set; }
        public DateTime? DOCHDR_dDate { get; set; }
        public int? labno { get; set; }
        public int? TESTMST_TestTypeId { get; set; }
        public string TESTMST_Alias { get; set; }
        public string TestTypeName { get; set; }
    }
}
