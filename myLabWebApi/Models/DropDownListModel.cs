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
    }
}
