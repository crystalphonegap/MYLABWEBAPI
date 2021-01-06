using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class COLLECTIONCENTER
    {
        public int CENTER_id { get; set; }
        public string CENTER_Name { get; set; }
        public string CENTER_Address1 { get; set; }
        public string CENTER_Address2 { get; set; }
        public string CENTER_City { get; set; }
        public string CENTER_State { get; set; }
        public string CENTER_Region { get; set; }
        public string CENTER_Country { get; set; }
        public string CENTER_Pincode { get; set; }
        public string CENTER_Telno { get; set; }
        public short? CENTER_Status { get; set; }
        public int? CENTER_Companyid { get; set; }
        public double? Percentage { get; set; }
        public string OutSourceLab { get; set; }
    }
}
