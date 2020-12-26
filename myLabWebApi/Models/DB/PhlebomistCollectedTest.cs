using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class PhlebomistCollectedTest
    {
        public int Id { get; set; }
        public string PhlebotomistId { get; set; }
        public string PhlebotomistName { get; set; }
        public string AccepthmvstId { get; set; }
        public string PatientName { get; set; }
        public string TestName { get; set; }
        public DateTime? SystDate { get; set; }
        public bool? Flag { get; set; }
        public string PatientContact { get; set; }
        public string TestId { get; set; }
        public string HomeVisitId { get; set; }
        public int? TestRate { get; set; }
        public string TestType { get; set; }
    }
}
