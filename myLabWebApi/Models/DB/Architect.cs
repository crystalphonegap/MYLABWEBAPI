using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class Architect
    {
        public int TestId { get; set; }
        public string TestName { get; set; }
        public int MylabTestMstid { get; set; }
        public int MylabTestFieldnoOne { get; set; }
        public int? MylabTestFieldnoTwo { get; set; }
        public string Type { get; set; }
        public long Id { get; set; }
    }
}
