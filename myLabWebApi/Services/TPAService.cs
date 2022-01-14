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
    public class TPAService :ITPAService
    {
        private readonly IConfiguration _config;
        private readonly IMyLabHelper _MyLabHelper;
        private readonly ILogger _ILogger;

        public TPAService(IMyLabHelper MyLabHelper, ILogger ILoggerservice, IConfiguration config)
        {
            _config = config;
            _ILogger = ILoggerservice;
            _MyLabHelper = MyLabHelper;
        }

        public List<TPAClass> GetAllTPADetails(SearchFilters m)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", m.PageNo, DbType.Int32);
            dbPara.Add("PageSize", m.PageSize, DbType.Int32);
            dbPara.Add("Keyword", m.Keyword == "NoSearch" ? "" : m.Keyword.Trim(), DbType.String);
            var data = _MyLabHelper.GetAll<TPAClass>("[dbo].[PRC_AD_GETTPALIST]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public long GetAllTPADetailsCount(SearchFilters m)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", -2, DbType.Int32);
            dbPara.Add("PageSize", 0, DbType.Int32);
            dbPara.Add("Keyword", m.Keyword == "NoSearch" ? "" : m.Keyword.Trim(), DbType.String);
            var data = _MyLabHelper.GetAll<TPAClass>("[dbo].[PRC_AD_GETTPALIST]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList().Count;
        }

        public long InsertUpdateTPADetails(TPAClass model)
        {
            if(model.Id==0 || model.Id==null)
            {
                model.Action = "I";
            }
            else
            {
                model.Action = "U";
            }
            var dbPara = new DynamicParameters();
            dbPara.Add("@P_ID", model.Id, DbType.Int32);
            dbPara.Add("@P_Name", model.Name, DbType.String);
            dbPara.Add("@P_Address", model.Address, DbType.String);
            dbPara.Add("@P_ACTION", model.Action, DbType.String);
            dbPara.Add("@P_Address2", model.Address2, DbType.String);
            dbPara.Add("@P_City", model.City, DbType.String);
            dbPara.Add("@P_Area", model.Area, DbType.String);
            dbPara.Add("@P_State", model.State, DbType.String);
            dbPara.Add("@P_Pincode", model.Pincode, DbType.String);
            dbPara.Add("@P_TelephoneNo", model.TelephoneNo, DbType.String);
            dbPara.Add("@P_Country", model.Country, DbType.String);
            dbPara.Add("@P_UserId", model.UserId, DbType.Int32);

            #region using dapper

            var data = _MyLabHelper.Insert<long>("[dbo].[PRC_MS_TPALIST_IUD]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;

            #endregion using dapper
        }


        public TPAClass GetTPADetailsByID(int Id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("@P_ID", Id, DbType.Int32);
            dbPara.Add("@P_TYPE", "Single", DbType.String);
            var data = _MyLabHelper.GetAll<TPAClass>("[dbo].[PRC_MS_GETTPALIST]", dbPara, commandType: CommandType.StoredProcedure);
            return data[0];
        }

        public string DeleteTPAById(int Id)
        {
            //change sp for use
            TPAClass model = new TPAClass();
            var dbPara = new DynamicParameters();
            dbPara.Add("@P_ID", Id, DbType.Int32);
            dbPara.Add("@P_Name", model.Name, DbType.String);
            dbPara.Add("@P_Address", model.Address, DbType.String);
            dbPara.Add("@P_ACTION", "D", DbType.String);
            dbPara.Add("@P_Address2", model.Address2, DbType.String);
            dbPara.Add("@P_City", model.City, DbType.String);
            var data = _MyLabHelper.Insert<string>("[dbo].[PRC_MS_TPALIST_IUD]", dbPara, commandType: CommandType.StoredProcedure);
            return data;
        }
    }
}
