using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class PhelobotomistHomeVisit
    {
        public int Id { get; set; }
        public string PhlebomistUsername { get; set; }
        public string PhlebomistContact { get; set; }
        public string PatientName { get; set; }
        public string PatientContact { get; set; }
        public string Area { get; set; }
        public string Time { get; set; }
        public string Attachment { get; set; }
        public string Decision { get; set; }
        public string Reason { get; set; }
        public DateTime SystDate { get; set; }
        public bool? Flag { get; set; }
        public string NewPheloId { get; set; }
        public string NewPheloName { get; set; }
        public string PhelobotomistId { get; set; }
        public string HomeVisitId { get; set; }
        public string PaymentMode { get; set; }
        public string SampleCollected { get; set; }
        public double? AmountCollected { get; set; }
        public string PatientAdd { get; set; }
        public DateTime? BookingDate { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string PatientEmail { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string PaybleAmount { get; set; }
        public string ReferenceDoctor { get; set; }
        public string Discount { get; set; }
    }
}
