using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class PHLEBOMIST_COLLECTED_TEST
    {
        public int ID { get; set; }
        public string PHLEBOTOMIST_ID { get; set; }
        public string PHLEBOTOMIST_NAME { get; set; }
        public string ACCEPTHMVST_ID { get; set; }
        public string PATIENT_NAME { get; set; }
        public string TEST_NAME { get; set; }
        public DateTime? SYST_DATE { get; set; }
        public bool? FLAG { get; set; }
        public string PAtientContact { get; set; }
        public string TestID { get; set; }
        public string HomeVisitId { get; set; }
        public int? TestRate { get; set; }
        public string TestType { get; set; }
    }
}
