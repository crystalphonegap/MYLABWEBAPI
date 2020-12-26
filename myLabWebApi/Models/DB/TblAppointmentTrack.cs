using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class TblAppointmentTrack
    {
        public int Id { get; set; }
        public string AppointmentId { get; set; }
        public string ContactNo { get; set; }
        public DateTime? Sysdate { get; set; }
    }
}
