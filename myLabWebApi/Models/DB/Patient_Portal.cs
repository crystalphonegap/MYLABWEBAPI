using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class Patient_Portal
    {
        public int Patient_id { get; set; }
        public string Patient_name { get; set; }
        public string Contact_no { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string Pincode { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string age { get; set; }
        public DateTime? RegDate { get; set; }
        public string RowSent { get; set; }
    }
}
