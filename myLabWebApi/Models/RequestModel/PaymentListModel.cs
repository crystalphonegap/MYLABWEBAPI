using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models.RequestModel
{
    public class PaymentListModel
    {
        public string fromDate { get; set; }
        public string todate { get; set; }
        public string DoctorName { get; set; }
        public string PatientName { get; set; }
        public string PatientId { get; set; }
        public string UserID { get; set; }
    }
}
