using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class LabMST
    {
        public int id { get; set; }
        public string LabCode { get; set; }
        public string LabName { get; set; }
        public string LabAddress { get; set; }
        public string LabEmail { get; set; }
        public string LabContact { get; set; }
        public string LabWebserviceURL { get; set; }
    }
}
