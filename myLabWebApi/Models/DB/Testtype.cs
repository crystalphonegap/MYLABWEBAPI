using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class Testtype
    {
        public int TestTypeId { get; set; }
        public string TestTypeName { get; set; }
        public string TestTypeDescription { get; set; }
        public string TestTypeRemark { get; set; }
        public string TestTypeRemark1 { get; set; }
    }
}
