using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_DOCTORWISE_COMMISSION_OLD
    {
        public int? DOCHDR_lPatientId { get; set; }
        public string PATIENT_Name { get; set; }
        public DateTime? PATIENT_Date { get; set; }
        public int? DOCHDR_lDoctorId { get; set; }
        public string DOCTOR_Name { get; set; }
        public int? DOCHDR_TestCatID { get; set; }
        public string TESTMST_Name { get; set; }
        public double? DOCHDR_Rate { get; set; }
        public bool DOCHDR_bCommission { get; set; }
        public int? labno { get; set; }
        public string WardNo { get; set; }
        public string TESTMST_CATTYPE { get; set; }
        public double? Discount { get; set; }
        public double? Comm { get; set; }
        public double? X_Comm { get; set; }
        public double? S_Comm { get; set; }
        public double? R_COMM { get; set; }
        public double? PF_COMM { get; set; }
        public double? SP_COMM { get; set; }
        public double? M_COMM { get; set; }
        public double? O_COMM { get; set; }
        public double? HC_COMM { get; set; }
        public double? EX_COMM { get; set; }
        public double? EX1_COMM { get; set; }
        public int? DOCHDR_SAMPLE { get; set; }
        public string CENTER_Name { get; set; }
        public double? LumSumAmt { get; set; }
        public string SpecialTest { get; set; }
    }
}
