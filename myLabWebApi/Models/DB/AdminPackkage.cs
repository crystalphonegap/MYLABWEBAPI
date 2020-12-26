using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class AdminPackkage
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Contact { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string PackkageName { get; set; }
        public string TestName { get; set; }
        public string Price { get; set; }
        public bool? Flag { get; set; }
        public string LabCode { get; set; }
        public string LabName { get; set; }
        public string LabArea { get; set; }
        public string LabAddress { get; set; }
        public string PackageCode { get; set; }
        public DateTime? Sysdate { get; set; }
    }
}
