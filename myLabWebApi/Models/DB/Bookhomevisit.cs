using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class Bookhomevisit
    {
        public int Id { get; set; }
        public string PatientId { get; set; }
        public string PatientName { get; set; }
        public DateTime? Date { get; set; }
        public string Time { get; set; }
        public string Contact { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public string PreferedLab { get; set; }
        public string Remark { get; set; }
        public string Filename { get; set; }
        public string Filepath { get; set; }
        public bool? BookedFlag { get; set; }
        public DateTime? CurrentDate { get; set; }
        public string Cancel { get; set; }
        public string Status { get; set; }
        public string BookedBy { get; set; }
        public string PatientContact { get; set; }
        public string PatientEmail { get; set; }
        public string LabCode { get; set; }
        public string HomevisitId { get; set; }
        public string CancleReason { get; set; }
        public bool? RowSent { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public DateTime? SysDate { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
