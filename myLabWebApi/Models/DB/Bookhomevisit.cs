using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class BOOKHOMEVISIT
    {
        public int ID { get; set; }
        public string PATIENT_ID { get; set; }
        public string Patient_name { get; set; }
        public DateTime? DATE { get; set; }
        public string TIME { get; set; }
        public string CONTACT { get; set; }
        public string AREA { get; set; }
        public string ADDRESS { get; set; }
        public string PREFERED_LAB { get; set; }
        public string REMARK { get; set; }
        public string FILENAME { get; set; }
        public string FILEPATH { get; set; }
        public bool? BOOKED_FLAG { get; set; }
        public DateTime? Current_date { get; set; }
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
        public DateTime? Sys_Date { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
