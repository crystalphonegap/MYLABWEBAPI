using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class BookAppointment
    {
        public int Id { get; set; }
        public string UsernameBook { get; set; }
        public string PatientId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Contact { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public string PreferedLab { get; set; }
        public string Remark { get; set; }
        public bool? Flag { get; set; }
        public string Filename { get; set; }
        public string Filepath { get; set; }
        public string Cancel { get; set; }
        public string Status { get; set; }
        public string BookedBy { get; set; }
        public string PatientContact { get; set; }
        public string PatientEmail { get; set; }
        public string AppointmentId { get; set; }
        public string Age { get; set; }
        public string LabCode { get; set; }
        public string CancleReason { get; set; }
        public bool? RowSent { get; set; }
        public string Gender { get; set; }
    }
}
