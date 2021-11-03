using Dapper;
using Microsoft.Extensions.Configuration;
using myLabWebApi.Interface;
using myLabWebApi.Models;
using myLabWebApi.Models.New;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace myLabWebApi.Services
{
    public class PaymentModeService : IPaymentModeService
    {

        private readonly IConfiguration _config;
        private readonly IMyLabHelper _MyLabHelper;
        private readonly ILogger _ILogger;

        public PaymentModeService(IMyLabHelper MyLabHelper, ILogger ILoggerservice, IConfiguration config)
        {
            _config = config;
            _ILogger = ILoggerservice;
            _MyLabHelper = MyLabHelper;
        }
        public List<PaymentModeClass> GetAllPaymentMode()
        {
            var dbPara = new DynamicParameters();
            var data = _MyLabHelper.GetAll<PaymentModeClass>("[dbo].[PRC_MS_GETPAYMENTMOD]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public List<TPAClass> GetAllTAPLIST()
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("@P_ID", 0, DbType.Int32);
            dbPara.Add("@P_TYPE", "ALL", DbType.String);
            var data = _MyLabHelper.GetAll<TPAClass>("[dbo].[PRC_MS_GETTPALIST]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }
        public int InsertUpdatePaymentMode(PaymentModeClass model)
        {
            int data = 0;
            var dbPara = new DynamicParameters();
            dbPara.Add("@P_ID", model.Id, DbType.Int32);
            dbPara.Add("@P_PAYMENTMODE", model.PaymentMode, DbType.String);
            dbPara.Add("@P_ACTION", "I", DbType.String);
            data = _MyLabHelper.Insert<int>("[dbo].[PRC_MS_PAYMENTMODE_IUD]",
                          dbPara,
                          commandType: CommandType.StoredProcedure);
            return data;
        }
    }
}
