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

        //public List<EMPLOYEE> GetAllEmployeeDetails()
        //{
        //    var dbPara = new DynamicParameters();
        //    var data = _MyLabHelper.GetAll<EMPLOYEE>("[dbo].[SP_GetEmployeeDetails]", dbPara, commandType: CommandType.StoredProcedure);
        //    return data.ToList();
        //}

        //public long InsertUpdateEmployee(EMPLOYEE empmodel)
        //{
        //    var dbPara = new DynamicParameters();
        //    dbPara.Add("EMPLOYEE_id", empmodel.EMPLOYEE_id, DbType.Int64);
        //    dbPara.Add("EMPLOYEE_Name", empmodel.EMPLOYEE_Name, DbType.String);
        //    dbPara.Add("EMPLOYEE_Address1", empmodel.EMPLOYEE_Address1, DbType.String);
        //    dbPara.Add("EMPLOYEE_Address2", empmodel.EMPLOYEE_Address2, DbType.String);
        //    dbPara.Add("EMPLOYEE_City", empmodel.EMPLOYEE_City, DbType.String);
        //    dbPara.Add("EMPLOYEE_State", empmodel.EMPLOYEE_State, DbType.String);
        //    dbPara.Add("EMPLOYEE_Region", empmodel.EMPLOYEE_Region, DbType.String);
        //    dbPara.Add("EMPLOYEE_Country", empmodel.EMPLOYEE_Country, DbType.String);
        //    dbPara.Add("EMPLOYEE_Pincode", empmodel.EMPLOYEE_Pincode, DbType.String);
        //    dbPara.Add("EMPLOYEE_Telno", empmodel.EMPLOYEE_Telno, DbType.String);
        //    dbPara.Add("EMPLOYEE_MobileNo", empmodel.EMPLOYEE_MobileNo, DbType.String);
        //    dbPara.Add("EMPLOYEE_Email", empmodel.EMPLOYEE_Email, DbType.String);
        //    dbPara.Add("EMPLOYEE_DateofBirth", empmodel.EMPLOYEE_DateofBirth, DbType.DateTime);
        //    dbPara.Add("EMPLOYEE_DateofJoining", empmodel.EMPLOYEE_DateofJoining, DbType.DateTime);
        //    dbPara.Add("EMPLOYEE_Qualification", empmodel.EMPLOYEE_Qualification, DbType.String);
        //    dbPara.Add("EMPLOYEE_Salary", empmodel.EMPLOYEE_Salary, DbType.Decimal);
        //    dbPara.Add("EMPLOYEE_Gender", empmodel.EMPLOYEE_Gender, DbType.Int16);
        //    dbPara.Add("EMPLOYEE_Status", empmodel.EMPLOYEE_Status, DbType.Int16);
        //    dbPara.Add("EMPLOYEE_Companyid", empmodel.EMPLOYEE_Companyid, DbType.Int16);
        //    dbPara.Add("EMPLOYEE_SalaryType", empmodel.EMPLOYEE_SalaryType, DbType.String);
        //    dbPara.Add("CollectionBoy_Flag", empmodel.CollectionBoy_Flag, DbType.Boolean);
        //    dbPara.Add("LabID", empmodel.LabID, DbType.String);
        //    dbPara.Add("Password", empmodel.Password, DbType.String);
        //    #region using dapper  
        //    var data = _MyLabHelper.Insert<long>("[dbo].[SP_InsertUpdateEmployee]",
        //                    dbPara,
        //                    commandType: CommandType.StoredProcedure);
        //    return data;
        //    #endregion
        //}

        //-------  doctor  -----------------
        //*****************************************
        public List<DOCTOR> GetAllDoctorDetails()
        {
            var dbPara = new DynamicParameters();
            var data = _MyLabHelper.GetAll<DOCTOR>("[dbo].[SP_GetDoctorDetails]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public List<DOCTOR> GetDoctorSearch(int PageNo, int PageSize, string KeyWord)
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
            var data = _MyLabHelper.GetAll<DOCTOR>("[dbo].[SP_DoctorList]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public long GetDoctorSearchCount(string KeyWord)
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
            var data = _MyLabHelper.GetAll<DOCTOR>("[dbo].[SP_DoctorList]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList().Count;
        }

        public DOCTOR GetDoctorUsingId(int Id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("DoctorID", Id, DbType.Int32);
            
            var data = _MyLabHelper.GetAll<DOCTOR>("[dbo].[SP_GetDoctorDetailsByID]", dbPara, commandType: CommandType.StoredProcedure);
            return data[0];
        }


        public long DeleteDoctorById(int Id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("DoctorID", Id, DbType.Int32);
            
            var data = _MyLabHelper.Insert<long>("[dbo].[SP_DeleteDoctorDetailsByID]", dbPara, commandType: CommandType.StoredProcedure);
            return data;
        }

        public long InsertUpdateDoctor(DOCTOR docmodel)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("DOCTOR_id", docmodel.DOCTOR_id, DbType.Int64);
            dbPara.Add("DOCTOR_Name", docmodel.DOCTOR_Name, DbType.String);
            dbPara.Add("DOCTOR_Address1", docmodel.DOCTOR_Address1, DbType.String);
            dbPara.Add("DOCTOR_Address2", docmodel.DOCTOR_Address2, DbType.String);
            dbPara.Add("DOCTOR_City", docmodel.DOCTOR_City, DbType.String);
            dbPara.Add("DOCTOR_State", docmodel.DOCTOR_State, DbType.String);
            dbPara.Add("TDS", docmodel.TDS, DbType.String);
            dbPara.Add("Collection_Center", docmodel.Collection_Center, DbType.String);
            dbPara.Add("DOCTOR_Bill", docmodel.DOCTOR_Bill, DbType.String);
            dbPara.Add("DOCTOR_Pincode", docmodel.DOCTOR_Pincode, DbType.String);
            dbPara.Add("DOCTOR_Telno", docmodel.DOCTOR_Telno, DbType.String);
            dbPara.Add("DOCTOR_MobileNo", docmodel.DOCTOR_MobileNo, DbType.String);
            dbPara.Add("DOCTOR_Email", docmodel.DOCTOR_Email, DbType.String);
            dbPara.Add("DOCTOR_Qualification", docmodel.DOCTOR_Qualification, DbType.String);
            dbPara.Add("OFFICE_Address1", docmodel.OFFICE_Address1, DbType.String);
            dbPara.Add("OFFICE_Address2", docmodel.OFFICE_Address2, DbType.String);
            dbPara.Add("OFFICE_City", docmodel.OFFICE_City, DbType.String);
            dbPara.Add("OFFICE_State", docmodel.OFFICE_State, DbType.String);
            dbPara.Add("OFFICE_Region", docmodel.OFFICE_Region, DbType.String);
            dbPara.Add("OFFICE_Country", docmodel.OFFICE_Country, DbType.String);
            dbPara.Add("OFFICE_Pincode", docmodel.OFFICE_Pincode, DbType.String);
            dbPara.Add("OFFICE_Telno", docmodel.OFFICE_Telno, DbType.String);
            dbPara.Add("OFFICE_url", docmodel.OFFICE_url, DbType.String);
            dbPara.Add("DOCTOR_Commission", docmodel.DOCTOR_Commission, DbType.Decimal);
            dbPara.Add("DOCTOR_Companyid", docmodel.DOCTOR_Companyid, DbType.Int16);
            dbPara.Add("DOCTOR_Permanent", docmodel.DOCTOR_Permanent, DbType.Boolean);
            dbPara.Add("DOCTOR_XCommission", docmodel.DOCTOR_XCommission, DbType.Decimal);
            dbPara.Add("DOCTOR_SCommission", docmodel.DOCTOR_SCommission, DbType.Decimal);
            dbPara.Add("DOCTOR_RCommission", docmodel.DOCTOR_RCommission, DbType.Decimal);
            dbPara.Add("DOCTOR_PFCommission", docmodel.DOCTOR_PFCommission, DbType.Decimal);
            dbPara.Add("DOCTOR_SPCommission", docmodel.DOCTOR_SPCommission, DbType.Decimal);
            dbPara.Add("DOCTOR_MCommission", docmodel.DOCTOR_MCommission, DbType.Decimal);
            dbPara.Add("DOCTOR_OCommission", docmodel.DOCTOR_OCommission, DbType.Decimal);
            dbPara.Add("DOCTOR_HCommission", docmodel.DOCTOR_HCommission, DbType.Decimal);
            dbPara.Add("DOCTOR_EXCommission", docmodel.DOCTOR_EXCommission, DbType.Decimal);
            dbPara.Add("DOCTOR_EX1Commission", docmodel.DOCTOR_EX1Commission, DbType.Decimal);
            dbPara.Add("SendSMS", docmodel.SendSMS, DbType.Boolean);
            dbPara.Add("DOCTOR_UserName", docmodel.DOCTOR_UserName, DbType.String);
            dbPara.Add("DOCTOR_Password", docmodel.DOCTOR_Password, DbType.String);
            dbPara.Add("Password", docmodel.Password, DbType.String);
            //DateTime dobdt = DateTime.ParseExact(docmodel.DOB.ToString(), "dd-MM-yyyy", null);
            //dbPara.Add("DOB", Convert.ToDateTime(dobdt).ToString("yyyy-MM-dd"), DbType.String);
            dbPara.Add("doctor_Code", docmodel.doctor_Code, DbType.String);
            #region using dapper  
            var data = _MyLabHelper.Insert<long>("[dbo].[SP_InsertUpdateDoctor]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;
            #endregion
        }

        //--Collectio Center-----------------------
        //*****************************************

        public List<COLLECTIONCENTER> GetAllCollectionCenterDetails()
        {
            var dbPara = new DynamicParameters();
            var data = _MyLabHelper.GetAll<COLLECTIONCENTER>("[dbo].[SP_GetCollectionCenterDetails]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public List<COLLECTIONCENTER> GetCollectionCenterSearch(int PageNo, int PageSize, string KeyWord)
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
            var data = _MyLabHelper.GetAll<COLLECTIONCENTER>("[dbo].[SP_CollectionCenterList]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public long GetCollectionCenterSearchCount(string KeyWord)
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
            var data = _MyLabHelper.GetAll<COLLECTIONCENTER>("[dbo].[SP_CollectionCenterList]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList().Count;
        }

        public COLLECTIONCENTER GetCollectionCenterById(int Id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", Id, DbType.Int32);
            
            var data = _MyLabHelper.GetAll<COLLECTIONCENTER>("[dbo].[SP_GetCollectionCenterDetailsByID]", dbPara, commandType: CommandType.StoredProcedure);
            return data[0];
        }


        public long DeleteCollectionCenterById(int Id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", Id, DbType.Int32);
            
            var data = _MyLabHelper.Insert<long>("[dbo].[SP_DeleteCollectionCenterDetailsByID]", dbPara, commandType: CommandType.StoredProcedure);
            return data;
        }

        public long insertUpdollectionCenter(COLLECTIONCENTER centermodel)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("CENTER_id", centermodel.CENTER_id, DbType.Int64);
            dbPara.Add("CENTER_Name", centermodel.CENTER_Name, DbType.String);
            dbPara.Add("CENTER_Address1", centermodel.CENTER_Address1, DbType.String);
            dbPara.Add("CENTER_Address2", centermodel.CENTER_Address2, DbType.String);
            dbPara.Add("CENTER_City", centermodel.CENTER_City, DbType.String);
            dbPara.Add("CENTER_Mobileno", centermodel.CENTER_Mobileno, DbType.String);
            dbPara.Add("CENTER_Percentage", centermodel.CENTER_Percentage, DbType.Double);
            dbPara.Add("CENTER_Email", centermodel.CENTER_Email, DbType.String);
            dbPara.Add("CENTER_RATELIST_ID", centermodel.CENTER_RATELIST_ID, DbType.Int64);
            dbPara.Add("CENTER_CREDIT", centermodel.CENTER_CREDIT, DbType.Boolean);
            dbPara.Add("CENTER_Discount", centermodel.CENTER_Discount, DbType.Boolean);
            #region using dapper  
            var data = _MyLabHelper.Insert<long>("[dbo].[InsertUpdateCollectionCenter]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;
            #endregion
        }

        //--Rate List-----------------------
        //*****************************************


        public List<RATELISTHDR> GetRateListSearch(int PageNo, int PageSize, string KeyWord)
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
            var data = _MyLabHelper.GetAll<RATELISTHDR>("[dbo].[SP_Rate_List]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public long GetRateListSearchCount(string KeyWord)
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
            var data = _MyLabHelper.GetAll<RATELISTHDR>("[dbo].[SP_Rate_List]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList().Count;
        }

        public RATELISTHDR GetRateListById(int Id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", Id, DbType.Int32);

            var data = _MyLabHelper.GetAll<RATELISTHDR>("[dbo].[SP_GetRateListDetailsByID]", dbPara, commandType: CommandType.StoredProcedure);
            return data[0];
        }


        public long DeleteRateListById(int Id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", Id, DbType.Int32);

            var data = _MyLabHelper.Insert<long>("[dbo].[SP_DeleteRateListDetailsByID]", dbPara, commandType: CommandType.StoredProcedure);
            return data;
        }

        public long insertUpdateRateList(RATELISTHDR RATELISTHDR)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("RateListId", RATELISTHDR.RateListId, DbType.Int64);
            dbPara.Add("RateListName", RATELISTHDR.RateListName, DbType.String);
            dbPara.Add("SysUser", RATELISTHDR.SysUser, DbType.String);
            dbPara.Add("Routine", RATELISTHDR.Routine, DbType.Double);
            dbPara.Add("Special", RATELISTHDR.Special, DbType.Double);
            dbPara.Add("Microbiology", RATELISTHDR.Microbiology, DbType.Double);
            dbPara.Add("Outside", RATELISTHDR.Outside, DbType.Double);
            dbPara.Add("Histo", RATELISTHDR.Histo, DbType.Double);
            dbPara.Add("other", RATELISTHDR.other, DbType.Double);
            dbPara.Add("other1", RATELISTHDR.other1, DbType.Double);
            #region using dapper  
            var data = _MyLabHelper.Insert<long>("[dbo].[InsertUpdateRateList]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;
            #endregion
        }

    }
}
