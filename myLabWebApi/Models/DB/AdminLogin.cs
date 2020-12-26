using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class AdminLogin
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime SysDate { get; set; }
        public string Type { get; set; }
        public string LabName { get; set; }
        public int? LabId { get; set; }
        public DateTime? SysDate1 { get; set; }
    }
}
