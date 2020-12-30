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

namespace myLabWebApi.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IConfiguration _config;
        private readonly IMyLabHelper _MyLabHelper;
        private readonly ILogger _ILogger;

        public EmployeeService(IMyLabHelper MyLabHelper, ILogger ILoggerservice, IConfiguration config)
        {
            _config = config;
            _ILogger = ILoggerservice;
            _MyLabHelper = MyLabHelper;
        }

        public List<EmployeeModel> GetAllEmployeeDetails()
        {
            var dbPara = new DynamicParameters();
            var data = _MyLabHelper.GetAll<EmployeeModel>("[dbo].[SP_GetEmployeeDetails]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public List<DoctorModel> GetAllDoctorDetails()
        {
            var dbPara = new DynamicParameters();
            var data = _MyLabHelper.GetAll<DoctorModel>("[dbo].[SP_GetDoctorDetails]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public long InsertUpdateDoctor(DoctorModel orderHeaderdetails)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("RefNovtxt", orderHeaderdetails.DOCTOR_id, DbType.String);
            dbPara.Add("DOCTOR_Name", orderHeaderdetails.DOCTOR_Name, DbType.String);
            dbPara.Add("DOCTOR_Address1", orderHeaderdetails.DOCTOR_Address1, DbType.String);
            dbPara.Add("DOCTOR_Address2", orderHeaderdetails.DOCTOR_Address2, DbType.String);
            dbPara.Add("DOCTOR_City", orderHeaderdetails.DOCTOR_City, DbType.Int64);
            dbPara.Add("DOCTOR_State", orderHeaderdetails.DOCTOR_State, DbType.String);
            dbPara.Add("DOCTOR_Region", orderHeaderdetails.DOCTOR_Region, DbType.String);
            dbPara.Add("DOCTOR_Country", orderHeaderdetails.DOCTOR_Country, DbType.String);
            dbPara.Add("DOCTOR_Pincode", orderHeaderdetails.DOCTOR_Pincode, DbType.String);
            dbPara.Add("DOCTOR_Telno", orderHeaderdetails.DOCTOR_Telno, DbType.String);
            dbPara.Add("DOCTOR_MobileNo", orderHeaderdetails.DOCTOR_MobileNo, DbType.String);
            dbPara.Add("DOCTOR_Email", orderHeaderdetails.DOCTOR_Email, DbType.String);
            dbPara.Add("DOCTOR_Qualification", orderHeaderdetails.DOCTOR_Qualification, DbType.String);
            dbPara.Add("OFFICE_Address1", orderHeaderdetails.OFFICE_Address1, DbType.String);
            dbPara.Add("OFFICE_Address2", orderHeaderdetails.OFFICE_Address2, DbType.String);
            dbPara.Add("OFFICE_City", orderHeaderdetails.OFFICE_City, DbType.String);
            dbPara.Add("OFFICE_State", orderHeaderdetails.OFFICE_State, DbType.String);
            dbPara.Add("OFFICE_Region", orderHeaderdetails.OFFICE_Region, DbType.String);
            dbPara.Add("OFFICE_Country", orderHeaderdetails.OFFICE_Country, DbType.String);
            dbPara.Add("OFFICE_Pincode", orderHeaderdetails.OFFICE_Pincode, DbType.String);
            dbPara.Add("OFFICE_Telno", orderHeaderdetails.OFFICE_Telno, DbType.String);
            dbPara.Add("OFFICE_url", orderHeaderdetails.OFFICE_url, DbType.String);
            dbPara.Add("DOCTOR_Commission", orderHeaderdetails.DOCTOR_Commission, DbType.Decimal);
            dbPara.Add("DOCTOR_Companyid", orderHeaderdetails.DOCTOR_Companyid, DbType.Int16);
            dbPara.Add("DOCTOR_Permanent", orderHeaderdetails.DOCTOR_Permanent, DbType.String);
            dbPara.Add("DOCTOR_XCommission", orderHeaderdetails.DOCTOR_XCommission, DbType.Decimal);
            dbPara.Add("DOCTOR_SCommission", orderHeaderdetails.DOCTOR_SCommission, DbType.Decimal);
            dbPara.Add("DOCTOR_RCommission", orderHeaderdetails.DOCTOR_RCommission, DbType.Decimal);
            dbPara.Add("DOCTOR_PFCommission", orderHeaderdetails.DOCTOR_PFCommission, DbType.Decimal);
            dbPara.Add("DOCTOR_SPCommission", orderHeaderdetails.DOCTOR_SPCommission, DbType.Decimal);
            dbPara.Add("DOCTOR_MCommission", orderHeaderdetails.DOCTOR_MCommission, DbType.Decimal);
            dbPara.Add("DOCTOR_OCommission", orderHeaderdetails.DOCTOR_OCommission, DbType.Decimal);
            dbPara.Add("DOCTOR_HCommission", orderHeaderdetails.DOCTOR_HCommission, DbType.Decimal);
            dbPara.Add("DOCTOR_EXCommission", orderHeaderdetails.DOCTOR_EXCommission, DbType.Decimal);
            dbPara.Add("DOCTOR_EX1Commission", orderHeaderdetails.DOCTOR_EX1Commission, DbType.Decimal);
            dbPara.Add("SendSMS", orderHeaderdetails.SendSMS, DbType.Int16);
            dbPara.Add("DOCTOR_UserName", orderHeaderdetails.DOCTOR_UserName, DbType.String);
            dbPara.Add("DOCTOR_Password", orderHeaderdetails.DOCTOR_Password, DbType.String);
            dbPara.Add("Password", orderHeaderdetails.Password, DbType.String);
            dbPara.Add("DOB", orderHeaderdetails.DOB, DbType.DateTime);
            dbPara.Add("doctor_Code", orderHeaderdetails.doctor_Code, DbType.String);
            #region using dapper  
            var data = _MyLabHelper.Insert<long>("[dbo].[SP_InsertUpdateDoctor]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;
            #endregion
        }
    }
}
