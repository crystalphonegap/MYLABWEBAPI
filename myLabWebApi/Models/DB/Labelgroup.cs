using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class Labelgroup
    {
        public int Grpid { get; set; }
        public string Grpname { get; set; }
        public string Active { get; set; }
        public int? Companyid { get; set; }
        public string Prefix { get; set; }
    }
}
