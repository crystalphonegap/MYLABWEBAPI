using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class AppointmentImage
    {
        public int Id { get; set; }
        public string AppointmentId { get; set; }
        public string ImageString { get; set; }
    }
}
