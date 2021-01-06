using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class ADMIN_HOME_VISIT_ALLOCATED
    {
        public int ID { get; set; }
        public string BOOKEDHOMEVISIT_ID { get; set; }
        public string PATIENT_NAME { get; set; }
        public string PATIENT_CONTACT { get; set; }
        public string PATIENT_AREA { get; set; }
        public string PHLEB_ID { get; set; }
        public string PHLEB_NAME { get; set; }
        public string ALLOT_TIME { get; set; }
        public string FILE_NAME { get; set; }
        public string FILE_PATH { get; set; }
        public DateTime? SEND_DATETIME { get; set; }
        public string USERID { get; set; }
        public string REMARK { get; set; }
        public bool FLAG { get; set; }
        public int? LabId { get; set; }
        public string LabName { get; set; }
        public string patient_address { get; set; }
        public DateTime? bookingDate { get; set; }
        public DateTime? SysDate { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
