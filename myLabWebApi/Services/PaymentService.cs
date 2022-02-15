using Dapper;
using Microsoft.Extensions.Configuration;
using myLabWebApi.Interface;
using myLabWebApi.Models;
using myLabWebApi.Models.RequestModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IConfiguration _config;
        private readonly IMyLabHelper _MyLabHelper;
        private readonly ILogger _ILogger;


        public PaymentService(IMyLabHelper MyLabHelper, ILogger ILoggerservice, IConfiguration config)
        {
            _config = config;
            _ILogger = ILoggerservice;
            _MyLabHelper = MyLabHelper;
        }

        public List<PaymentModel> GetPaymentList(PaymentListModel model)
        {
            var dbPara3 = new DynamicParameters();
            DateTime tempDate = DateTime.ParseExact(model.fromDate, "MM-dd-yyyy", null);
            dbPara3.Add("@P_fromDate", tempDate.ToString("yyyy-MM-dd"), DbType.String);
            tempDate = DateTime.ParseExact(model.todate, "MM-dd-yyyy", null);
            dbPara3.Add("@P_todate", tempDate.ToString("yyyy-MM-dd"), DbType.String);
            dbPara3.Add("@P_DoctorName", model.DoctorName, DbType.String);
            dbPara3.Add("@P_PatientName", model.PatientName, DbType.String);
            if (string.IsNullOrEmpty(model.PatientId))
            {
                dbPara3.Add("@P_PatientId", 0, DbType.Int64);

            }
            else
            {
                dbPara3.Add("@P_PatientId", model.PatientId, DbType.Int64);

            }
            dbPara3.Add("@P_UserID", Convert.ToInt64(model.UserID), DbType.Int64);
            var data = _MyLabHelper.GetAll<PaymentModel>("[dbo].[USP_GetAmountPaidList]",
                          dbPara3,
                          commandType: CommandType.StoredProcedure);

            return data;
        }

        public int AddPayment(AmountPaidModel model)
        {
            var dbPara3 = new DynamicParameters();

            dbPara3.Add("@Patientid", model.Patientid, DbType.Int64);
            dbPara3.Add("@Paymode", model.Paymode, DbType.String);
            dbPara3.Add("@Remark", model.Remark, DbType.String);
            dbPara3.Add("@userid", model.userid, DbType.String);
            dbPara3.Add("@AmountPaid", model.AmountPaid, DbType.String);
            var data = _MyLabHelper.Get<int>("[dbo].[USP_AddPayment]",
                          dbPara3,
                          commandType: CommandType.StoredProcedure);

            return data;
        }

        public List<AmountPaidModel> GetPaymentHistory(int Id)
        {
            var dbPara3 = new DynamicParameters();
            dbPara3.Add("@P_PatientID", Id, DbType.Int64);
            var data = _MyLabHelper.GetAll<AmountPaidModel>("[dbo].[USP_GetAmountPaidHistory]",
                          dbPara3,
                          commandType: CommandType.StoredProcedure);
            return data;
        }


       

    }
}
