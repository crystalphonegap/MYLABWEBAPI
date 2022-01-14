using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models
{
    public class DropDownListModel
    {
    }
    public class PaymentModeClass
    {
        public int Id { get; set; }
        public string PaymentMode { get; set; }
    }

    public class TPAClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Action { get; set; }
        public string Area { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
        public string TelephoneNo { get; set; }
        public string Country { get; set; }
        public int UserId { get; set; }
    }
}
