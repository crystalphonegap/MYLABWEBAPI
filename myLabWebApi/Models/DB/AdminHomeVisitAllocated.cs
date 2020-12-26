using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class AdminHomeVisitAllocated
    {
        public int Id { get; set; }
        public string BookedhomevisitId { get; set; }
        public string PatientName { get; set; }
        public string PatientContact { get; set; }
        public string PatientArea { get; set; }
        public string PhlebId { get; set; }
        public string PhlebName { get; set; }
        public string AllotTime { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime? SendDatetime { get; set; }
        public string Userid { get; set; }
        public string Remark { get; set; }
        public bool Flag { get; set; }
        public int? LabId { get; set; }
        public string LabName { get; set; }
        public string PatientAddress { get; set; }
        public DateTime? BookingDate { get; set; }
        public DateTime? SysDate { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
