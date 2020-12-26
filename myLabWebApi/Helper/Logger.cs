using myLabWebApi.Interface;
using Dapper;
using System;
using System.Data;
using System.Linq;
using System.Text;

using Microsoft.Extensions.Configuration;
namespace myLabWebApi.Helper
{
    public class Logger : ILogger
    {
        private readonly ICustomerPortalHelper _customerPortalHelper;
        public IConfiguration Configuration { get; }
        public Logger(ICustomerPortalHelper customerPortalHelper , IConfiguration configuration)
        {
            _customerPortalHelper = customerPortalHelper;

            Configuration = configuration;
        }


        public  void Log(Exception exception)
        {
            StringBuilder sbExceptionMessage = new StringBuilder();

            do
            {
                sbExceptionMessage.Append("Exception Type" + Environment.NewLine);
                sbExceptionMessage.Append(exception.GetType().Name);
                sbExceptionMessage.Append(Environment.NewLine + Environment.NewLine);
                sbExceptionMessage.Append("Message" + Environment.NewLine);
                sbExceptionMessage.Append(exception.Message + Environment.NewLine + Environment.NewLine);
                sbExceptionMessage.Append("Stack Trace" + Environment.NewLine);
                sbExceptionMessage.Append(exception.StackTrace + Environment.NewLine + Environment.NewLine);

                exception = exception.InnerException;
            }
            while (exception != null);
            string value = Configuration["LogtoSQL:Enable"];
            if(value== "Yes")
            {
                LogToDB(sbExceptionMessage.ToString());
            }
        }

        private  void LogToDB(string log)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ExceptionMessage", log, DbType.String);
            #region using dapper  
            var data = _customerPortalHelper.Insert<int>("[dbo].[spInsertLog]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
           
            #endregion

        }

        void ILogger.LogToDB(string log)
        {
            LogToDB( log);
        }
    }
}
