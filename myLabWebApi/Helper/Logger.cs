using Dapper;
using Microsoft.Extensions.Configuration;
using myLabWebApi.Interface;
using System;
using System.Data;
using System.Text;

namespace myLabWebApi.Helper
{
    public class Logger : ILogger
    {
        private readonly IMyLabHelper _MyLabHelper;
        public IConfiguration Configuration { get; }

        public Logger(IMyLabHelper MyLabHelper, IConfiguration configuration)
        {
            _MyLabHelper = MyLabHelper;

            Configuration = configuration;
        }

        public void Log(Exception exception)
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
            if (value == "Yes")
            {
                LogToDB(sbExceptionMessage.ToString());
            }
        }

        private void LogToDB(string log)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ExceptionMessage", log, DbType.String);

            #region using dapper

            var data = _MyLabHelper.Insert<int>("[dbo].[spInsertLog]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);

            #endregion using dapper
        }

        void ILogger.LogToDB(string log)
        {
            LogToDB(log);
        }
    }
}