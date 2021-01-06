using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class tblAppointmentTrack
    {
        public int id { get; set; }
        public string AppointmentId { get; set; }
        public string contactNo { get; set; }
        public DateTime? sysdate { get; set; }
    }
}
