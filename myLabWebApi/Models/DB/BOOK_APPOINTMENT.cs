using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class BOOK_APPOINTMENT
    {
        public int ID { get; set; }
        public string USERNAME_Book { get; set; }
        public string PATIENT_ID { get; set; }
        public string DATE { get; set; }
        public string TIME { get; set; }
        public string CONTACT { get; set; }
        public string AREA { get; set; }
        public string ADDRESS { get; set; }
        public string PREFERED_LAB { get; set; }
        public string REMARK { get; set; }
        public bool? FLAG { get; set; }
        public string FILENAME { get; set; }
        public string FILEPATH { get; set; }
        public string Cancel { get; set; }
        public string Status { get; set; }
        public string BookedBy { get; set; }
        public string PatientContact { get; set; }
        public string PatientEmail { get; set; }
        public string AppointmentID { get; set; }
        public string age { get; set; }
        public string LabCode { get; set; }
        public string CancleReason { get; set; }
        public bool? RowSent { get; set; }
        public string gender { get; set; }
    }
}
