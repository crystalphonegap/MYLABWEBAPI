using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class ADMIN_LOGIN
    {
        public int ID { get; set; }
        public string USERNAME { get; set; }
        public string CONTACT { get; set; }
        public string EMAIL { get; set; }
        public string PASSWORD { get; set; }
        public DateTime SYS_DATE { get; set; }
        public string Type { get; set; }
        public string LabName { get; set; }
        public int? LabID { get; set; }
        public DateTime? SysDate { get; set; }
    }
}
