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
    public class CompanyService:ICompanyService
    {
        private readonly IConfiguration _config;
        private readonly IMyLabHelper _MyLabHelper;
        private readonly ILogger _ILogger;

        public CompanyService(IMyLabHelper myLabHelper,IConfiguration configuration,ILogger logger)
        {
            _config = configuration;
            _MyLabHelper = myLabHelper;
            _ILogger = logger;

        }
        public CompanyResponseModel InsertUpdateCompany(CompanyModel model)
        {
            var dbPara = new DynamicParameters();

            dbPara.Add("@P_COMPANY_Setupid", model.COMPANY_Setupid, DbType.Int32);
            dbPara.Add("@P_COMPANY_Name", model.COMPANY_Name, DbType.String);
            dbPara.Add("@P_COMPANY_Address1", model.COMPANY_Address1, DbType.String);
            dbPara.Add("@P_COMPANY_Address2", model.COMPANY_Address2, DbType.String);
            dbPara.Add("@P_COMPANY_City", model.COMPANY_City, DbType.String);
            dbPara.Add("@P_COMPANY_State", model.COMPANY_State, DbType.String);
            dbPara.Add("@P_COMPANY_PostalCode", model.COMPANY_PostalCode, DbType.String);
            dbPara.Add("@P_COMPANY_Country", model.COMPANY_Country, DbType.String);
            dbPara.Add("@P_COMPANY_PhoneNumber",model.COMPANY_PhoneNumber, DbType.String);
            dbPara.Add("@P_COMPANY_Faxnumber", model.COMPANY_Faxnumber, DbType.String);
            dbPara.Add("@P_COMPANY_Email", model.COMPANY_Email, DbType.String);
            dbPara.Add("@P_COMPANY_Url", model.COMPANY_Url, DbType.String);
            dbPara.Add("@P_COMPANY_DataLoc", model.COMPANY_DataLoc, DbType.String);
            dbPara.Add("@P_COMPANY_Username", model.COMPANY_Username, DbType.String);
            dbPara.Add("@P_COMPANY_Password", model.COMPANY_Password, DbType.String);
            dbPara.Add("@P_COMPANY_ReportLoc", model.COMPANY_ReportLoc, DbType.String);
            dbPara.Add("@P_COMPANY_Pathologist", model.COMPANY_Pathologist, DbType.String);
            dbPara.Add("@P_COMPANY_PathoDegree", model.COMPANY_PathoDegree, DbType.String);
            dbPara.Add("@P_COMPANY_Radiologist", model.COMPANY_Radiologist, DbType.String);
            dbPara.Add("@P_COMPANY_RadiologistDegree", model.COMPANY_RadiologistDegree, DbType.String);
            dbPara.Add("@P_COMPANY_SonoLogist", model.COMPANY_SonoLogist, DbType.String);
            dbPara.Add("@P_COMPANY_SonoDegree", model.COMPANY_SonoDegree, DbType.String);
            dbPara.Add("@P_COMPANY_Abnormal", model.COMPANY_Abnormal, DbType.String);
            dbPara.Add("@P_COMPANY_TopMargin", model.COMPANY_TopMargin, DbType.String);
            dbPara.Add("@P_COMPANY_BotMargin", model.COMPANY_BotMargin, DbType.String);
            dbPara.Add("@P_Remarks", model.Remarks, DbType.String);
            dbPara.Add("@P_COMPANY_PaperSize", model.COMPANY_PaperSize, DbType.String);
            dbPara.Add("@P_ISSMSSEND", model.IsSMSSend, DbType.Boolean);
            dbPara.Add("@P_COMPANY_Series", model.COMPANY_Series, DbType.String);
            dbPara.Add("@P_UserId", model.Userid, DbType.Int32);
            if(model.COMPANY_Setupid==0)
            {
                dbPara.Add("@P_ACTION", "I", DbType.String);
            }
            else
            {
                dbPara.Add("@P_ACTION", "U", DbType.String);
            }
            
            
            var data = _MyLabHelper.Insert<CompanyResponseModel>("[dbo].[PRC_MS_COMPANY_IUD]",
                          dbPara,
                          commandType: CommandType.StoredProcedure);
            return data;
        }

        public List<CompanyModel> GetCompanyList( CompanySearchModel model)
        {

            var dbPara = new DynamicParameters();

            dbPara.Add("@P_PageNo", model.PageNo, DbType.Int32);
            dbPara.Add("@P_PageSize", model.PageSize, DbType.Int32);

            if(model.Keyword==null)
            {
                dbPara.Add("@P_Keyword", "", DbType.String);
            }
            else
            {
                dbPara.Add("@P_Keyword", model.Keyword, DbType.String);
            }
            
            dbPara.Add("@P_TYPE", "All", DbType.String);
            dbPara.Add("@P_COMPNAYID", 0, DbType.Int32);
            var data = _MyLabHelper.GetAll<CompanyModel>("[dbo].[PRC_MS_GETCOMPANYLIST]",
                         dbPara,
                         commandType: CommandType.StoredProcedure);
            return data;
        }

        public CompanyModel GetCompanyDetails(int CompanyId)
        {

            var dbPara = new DynamicParameters();
            dbPara.Add("@P_PageNo", 0, DbType.Int32);
            dbPara.Add("@P_PageSize", 0, DbType.Int32);
            dbPara.Add("@P_Keyword", "", DbType.String);
            dbPara.Add("@P_TYPE", "Single", DbType.String);
            dbPara.Add("@P_COMPNAYID", CompanyId, DbType.Int32);
            var data = _MyLabHelper.Get<CompanyModel>("[dbo].[PRC_MS_GETCOMPANYLIST]",
                         dbPara,
                         commandType: CommandType.StoredProcedure);
            return data;
        }
    }
}
