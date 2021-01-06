using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class ADMIN_PACKKAGE
    {
        public int ID { get; set; }
        public string USER_ID { get; set; }
        public string CONTACT { get; set; }
        public string FROM_DATE { get; set; }
        public string TO_DATE { get; set; }
        public string PACKKAGE_NAME { get; set; }
        public string TEST_NAME { get; set; }
        public string PRICE { get; set; }
        public bool? FLAG { get; set; }
        public string LabCode { get; set; }
        public string LabName { get; set; }
        public string LabArea { get; set; }
        public string LabAddress { get; set; }
        public string PackageCode { get; set; }
        public DateTime? Sysdate { get; set; }
    }
}
