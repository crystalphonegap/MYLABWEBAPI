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
    public class LabelGroupService : ILabelGroupService
    {

        private readonly IConfiguration _config;
        private readonly IMyLabHelper _MyLabHelper;
        private readonly ILogger _ILogger;

        public LabelGroupService(IMyLabHelper MyLabHelper, ILogger ILoggerservice, IConfiguration config)
        {
            _config = config;
            _ILogger = ILoggerservice;
            _MyLabHelper = MyLabHelper;
        }
        public long InsertUpdateLabelGroupMaster(LabelGroupMaster LabelGroupMaster)
        {

            var dbPara = new DynamicParameters();
            dbPara.Add("@P_GRPID", LabelGroupMaster.GRPID, DbType.Int32);
            dbPara.Add("@P_GRPNAME", LabelGroupMaster.GRPNAME, DbType.String);
            dbPara.Add("@P_Active", LabelGroupMaster.Active, DbType.Boolean);
            dbPara.Add("@P_Companyid", LabelGroupMaster.Companyid, DbType.String);
            dbPara.Add("@P_Prefix", LabelGroupMaster.Prefix, DbType.String);
            dbPara.Add("@P_ACTION", "D", DbType.String);
            dbPara.Add("@P_INSERTTYPE", "MASTER", DbType.String);
            dbPara.Add("@P_TESTID", 0, DbType.Int32);
            var data = _MyLabHelper.Insert<int>("[dbo].[PRC_MS_LABELGROUP_IUD]",
                          dbPara,
                          commandType: CommandType.StoredProcedure);

            try
            {

                var dbPara2 = new DynamicParameters();
                dbPara2.Add("@P_GRPID", LabelGroupMaster.GRPID, DbType.Int32);
                dbPara2.Add("@P_GRPNAME", LabelGroupMaster.GRPNAME, DbType.String);
               if(LabelGroupMaster.GRPID!=0)
                {
                    LabelGroupMaster.Action = "U";
                }
               
                dbPara2.Add("@P_Active", LabelGroupMaster.Active, DbType.Boolean);
                dbPara2.Add("@P_Companyid", LabelGroupMaster.Companyid, DbType.String);
                dbPara2.Add("@P_Prefix", LabelGroupMaster.Prefix, DbType.String);
                dbPara2.Add("@P_ACTION", LabelGroupMaster.Action, DbType.String);
                dbPara2.Add("@P_INSERTTYPE", "MASTER", DbType.String);
                dbPara2.Add("@P_TESTID", 0, DbType.Int32);
                dbPara2.Add("@P_UserId", LabelGroupMaster.UserId, DbType.Int32);
                
                LabelGroupMaster.GRPID = _MyLabHelper.Insert<int>("[dbo].[PRC_MS_LABELGROUP_IUD]",
                              dbPara2,
                              commandType: CommandType.StoredProcedure);

            }
            catch(Exception)
            {

            }
          

            for (int i=0;i< LabelGroupMaster.TestDetailsClass.Count();i++)
            {

                var dbPara3 = new DynamicParameters();
                dbPara3.Add("@P_GRPID", LabelGroupMaster.GRPID, DbType.Int32);
                dbPara3.Add("@P_GRPNAME", LabelGroupMaster.GRPNAME, DbType.String);
                dbPara3.Add("@P_Active", LabelGroupMaster.Active, DbType.Boolean);
                dbPara3.Add("@P_Companyid", LabelGroupMaster.Companyid, DbType.String);
                dbPara3.Add("@P_Prefix", LabelGroupMaster.Prefix, DbType.String);
                dbPara3.Add("@P_ACTION", LabelGroupMaster.Action, DbType.String);
                dbPara3.Add("@P_INSERTTYPE", "DETAILS", DbType.String);
                dbPara3.Add("@P_TESTID", LabelGroupMaster.TestDetailsClass[i].TestId, DbType.Int32);
                var data3 = _MyLabHelper.Insert<int>("[dbo].[PRC_MS_LABELGROUP_IUD]",
                              dbPara3,
                              commandType: CommandType.StoredProcedure);

            }
            return LabelGroupMaster.GRPID;
        }

        public List<TestDetailsClass> GetTestList()
        {
            var dbPara = new DynamicParameters();
            
            var data = _MyLabHelper.GetAll<TestDetailsClass>("[dbo].[PRC_MS_GETTESTLIST]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public List<LabelGroupMaster> GetLabelGroupList(SearchByKeywordType m)
        {
            LabelGroupMaster LabelGroupMaster = new LabelGroupMaster();
            var dbPara = new DynamicParameters();
            dbPara.Add("@P_ID", 0, DbType.Int32);
            dbPara.Add("@P_TYPE", "Master", DbType.String);
            dbPara.Add("@P_PAGENO", m.PageNo, DbType.Int32);
            dbPara.Add("@P_PAGESIZE", m.PageSize, DbType.Int32);
            dbPara.Add("@P_KEYWORD", m.Keyword == "NoSearch" ? "" : m.Keyword.Trim(), DbType.String);
            var data = _MyLabHelper.GetAll<LabelGroupMaster>("[dbo].[PRC_MS_GETLABELGROUPLIST]", dbPara, commandType: CommandType.StoredProcedure);
            
            return data.ToList();
        }

        public List<LabelGroupDetailsClass> GetLabelGroupDetailsById(int Id)
        {

            LabelGroupDetailsClass LabelGroupDetailsClass = new LabelGroupDetailsClass();
            var dbPara = new DynamicParameters();
            dbPara.Add("@P_ID", Id, DbType.Int32);
            dbPara.Add("@P_TYPE", "Details", DbType.String);
            dbPara.Add("@P_PAGENO", 0, DbType.Int32);
            dbPara.Add("@P_PAGESIZE", 0, DbType.Int32);
            dbPara.Add("@P_KEYWORD", "", DbType.String);
            var data = _MyLabHelper.GetAll<LabelGroupDetailsClass>("[dbo].[PRC_MS_GETLABELGROUPLIST]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }
    }
}
