using myLabWebApi.Models;
using myLabWebApi.Models.RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Interface
{
    public interface IPaymentService
    {
        List<PaymentModel> GetPaymentList(PaymentListModel model);
        List<AmountPaidModel> GetPaymentHistory(int Id);
        int AddPayment(AmountPaidModel model);
     
    }
}
