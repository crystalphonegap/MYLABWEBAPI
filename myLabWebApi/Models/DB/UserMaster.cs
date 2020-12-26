﻿using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class UserMaster
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public string Dob { get; set; }
        public string Gender { get; set; }
        public string Qualification { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string Pincode { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string Age { get; set; }
        public DateTime? RegDate { get; set; }
        public string RowSent { get; set; }
        public bool? Flag { get; set; }
        public int? LabId { get; set; }
        public string LabName { get; set; }
        public int? CentrId { get; set; }
        public string LabCode { get; set; }
        public DateTime? SysDate { get; set; }
    }
}
