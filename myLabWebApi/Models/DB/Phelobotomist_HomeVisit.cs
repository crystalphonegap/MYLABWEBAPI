using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class Phelobotomist_HomeVisit
    {
        public int ID { get; set; }
        public string PHLEBOMIST_USERNAME { get; set; }
        public string PHLEBOMIST_CONTACT { get; set; }
        public string PATIENT_NAME { get; set; }
        public string PATIENT_CONTACT { get; set; }
        public string AREA { get; set; }
        public string TIME { get; set; }
        public string ATTACHMENT { get; set; }
        public string DECISION { get; set; }
        public string REASON { get; set; }
        public DateTime SYST_DATE { get; set; }
        public bool? FLAG { get; set; }
        public string NewPheloId { get; set; }
        public string NewPheloName { get; set; }
        public string Phelobotomist_ID { get; set; }
        public string HomeVisitId { get; set; }
        public string PaymentMode { get; set; }
        public string SampleCollected { get; set; }
        public double? AmountCollected { get; set; }
        public string patient_add { get; set; }
        public DateTime? BookingDate { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string PatientEmail { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string PaybleAmount { get; set; }
        public string Reference_Doctor { get; set; }
        public string Discount { get; set; }
    }
}
