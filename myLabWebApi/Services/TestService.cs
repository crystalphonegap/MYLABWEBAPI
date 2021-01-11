using myLabWebApi.Interface;
using myLabWebApi.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Configuration;
using myLabWebApi.Models.New;

namespace myLabWebApi.Services
{
    public class TestService : ITestService
    {
        private readonly IConfiguration _config;
        private readonly IMyLabHelper _MyLabHelper;
        private readonly ILogger _ILogger;

        public TestService(IMyLabHelper MyLabHelper, ILogger ILoggerservice, IConfiguration config)
        {
            _config = config;
            _ILogger = ILoggerservice;
            _MyLabHelper = MyLabHelper;
        }

        public long InsertUpdateTestType(TestTypeModel model)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("TestTypeId", model.TestTypeId, DbType.Int32);
            dbPara.Add("TestTypeName", model.TestTypeName, DbType.String);
            dbPara.Add("TestTypeDescription", model.TestTypeDescription, DbType.String);
            dbPara.Add("TestTypeRemark", model.TestTypeRemark, DbType.String);
            dbPara.Add("TestTypeRemark1", model.TestTypeRemark1, DbType.String);
            #region using dapper  
            var data = _MyLabHelper.Insert<long>("[dbo].[SP_InsertUpdateTestType]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;
            #endregion
        }

        public List<TestTypeModel> GetTestTypeSearch(int PageNo, int PageSize, string KeyWord)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", PageNo, DbType.Int32);
            dbPara.Add("PageSize", PageSize, DbType.Int32);
            if (KeyWord == "NoSearch")
            {
                dbPara.Add("Keyword", "", DbType.String);
            }
            else
            {
                dbPara.Add("Keyword", KeyWord, DbType.String);
            }
            var data = _MyLabHelper.GetAll<TestTypeModel>("[dbo].[SP_TestTypeList]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public long GetTestTypeSearchCount(string KeyWord)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", -1, DbType.Int32);
            dbPara.Add("PageSize", 0, DbType.Int32);
            if (KeyWord == "NoSearch")
            {
                dbPara.Add("Keyword", "", DbType.String);
            }
            else
            {
                dbPara.Add("Keyword", KeyWord, DbType.String);
            }
            var data = _MyLabHelper.GetAll<TestTypeModel>("[dbo].[SP_TestTypeList]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList().Count;
        }

        public TestTypeModel GetTestTypeUsingId(int Id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", Id, DbType.Int32);
            dbPara.Add("Mode", "Get", DbType.String);
            var data = _MyLabHelper.GetAll<TestTypeModel>("[dbo].[SP_GetTestTypeByID]", dbPara, commandType: CommandType.StoredProcedure);
            return data[0];
        }

        public long DeleteTestTypeById(int Id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", Id, DbType.Int32);
            dbPara.Add("Mode", "Delete", DbType.String);
            var data = _MyLabHelper.Insert<long>("[dbo].[SP_GetTestTypeByID]", dbPara, commandType: CommandType.StoredProcedure);
            return data;
        }
    }
}
