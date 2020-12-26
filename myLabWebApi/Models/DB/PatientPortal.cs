using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class PatientPortal
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Dob { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string Pincode { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string Age { get; set; }
        public DateTime? RegDate { get; set; }
        public string RowSent { get; set; }
    }
}
