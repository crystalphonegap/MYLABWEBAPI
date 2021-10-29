using myLabWebApi.Models;
using myLabWebApi.Models.New;
using System.Collections.Generic;

namespace myLabWebApi.Interface
{
   public  interface IPaymentModeService
    {
        List<PaymentModeClass> GetAllPaymentMode();

        List<TPAClass> GetAllTAPLIST();
    }
}
