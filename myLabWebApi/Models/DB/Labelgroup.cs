using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class LABELGROUP
    {
        public int GRPID { get; set; }
        public string GRPNAME { get; set; }
        public string Active { get; set; }
        public int? Companyid { get; set; }
        public string Prefix { get; set; }
    }
}
