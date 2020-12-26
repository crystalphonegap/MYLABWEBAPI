using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class LabMst
    {
        public int Id { get; set; }
        public string LabCode { get; set; }
        public string LabName { get; set; }
        public string LabAddress { get; set; }
        public string LabEmail { get; set; }
        public string LabContact { get; set; }
        public string LabWebserviceUrl { get; set; }
    }
}
