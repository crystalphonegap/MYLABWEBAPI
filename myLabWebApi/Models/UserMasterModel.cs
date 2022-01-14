using System;
using System.Collections.Generic;

namespace myLabWebApi.Models
{
    public class UserMasterModel
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Contact_No { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public string DOB { get; set; }
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
        public bool Flag { get; set; }
        public int LabID { get; set; }
        public string LabName { get; set; }
        public int CentrID { get; set; }

        public string LabCode { get; set; }
        public DateTime? Sys_Date { get; set; }

        public string NewPassword { get; set; }
        public virtual ICollection<RefreshToken> RefreshTokens { get; set; }

       // public string Flag { get; set; }
        public string BrowserName { get; set; }
        public string IpAddress { get; set; }
        public string Region { get; set; }
        public string Branch { get; set; }
        public string Territory { get; set; }
        public string ResetTokenvtxt { get; set; }
    }
    public class LoginModel
    { 
        public string UserCodetxt { get; set; }  
        public string Passwordvtxt { get; set; }
    }

    }