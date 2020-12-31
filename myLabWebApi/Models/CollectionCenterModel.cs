using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models
{
    public class CollectionCenterModel
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

        public int CENTER_Status { get; set; }

        public int CENTER_Companyid { get; set; }

        public decimal Percentage { get; set; }

        public string OutSourceLab { get; set; }

    }
}
