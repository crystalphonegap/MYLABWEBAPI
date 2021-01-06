using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_DOCTOR_COMM
    {
        public long PATIENT_id { get; set; }
        public DateTime? PATIENT_Date { get; set; }
        public string PATIENT_Name { get; set; }
        public double? PATIENT_AmountPaid { get; set; }
        public int? PATIENT_Doctorid { get; set; }
        public string DOCTOR_Name { get; set; }
        public double? DOCTOR_Commission { get; set; }
        public double? DOCTOR_XCommission { get; set; }
        public int? DOCTOR_SCommission { get; set; }
        public double? DOCTOR_RCommission { get; set; }
        public double? DOCTOR_PFCommission { get; set; }
        public double? DOCTOR_SPCommission { get; set; }
        public double? DOCTOR_MCommission { get; set; }
        public double? DOCTOR_OCommission { get; set; }
        public double? DOCTOR_HCommission { get; set; }
        public double? DOCTOR_EXCommission { get; set; }
        public double? DOCTOR_EX1Commission { get; set; }
        public string DOCHDR_sDocNo { get; set; }
        public DateTime? DOCHDR_dDate { get; set; }
        public int? DOCHDR_TestCatID { get; set; }
        public double? DOCHDR_Rate { get; set; }
        public int? labno { get; set; }
        public string WardNo { get; set; }
        public string TESTMST_Name { get; set; }
        public string Type { get; set; }
        public int? PATIENT_SampleCollected { get; set; }
        public string CENTER_Name { get; set; }
    }
}
