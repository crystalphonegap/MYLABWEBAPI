using Dapper;
using Microsoft.Extensions.Configuration;
using myLabWebApi.Interface;
using myLabWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

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
            dbPara.Add("UserId", model.UserId, DbType.Int32);

            #region using dapper

            var data = _MyLabHelper.Insert<long>("[dbo].[SP_InsertUpdateTestType]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;

            #endregion using dapper
        }

        public List<TestTypeModel> GetTestTypeSearch(SearchFilters m)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", m.PageNo, DbType.Int32);
            dbPara.Add("PageSize", m.PageSize, DbType.Int32);
            dbPara.Add("Keyword", m.Keyword == "NoSearch" ? "" : m.Keyword.Trim(), DbType.String);
            var data = _MyLabHelper.GetAll<TestTypeModel>("[dbo].[SP_TestTypeList]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public long GetTestTypeSearchCount(SearchFilters m)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", -1, DbType.Int32);
            dbPara.Add("PageSize", 0, DbType.Int32);
            dbPara.Add("Keyword", m.Keyword == "NoSearch" ? "" : m.Keyword.Trim(), DbType.String);
            var data = _MyLabHelper.GetAll<CountModel>("[dbo].[SP_TestTypeList]", dbPara, commandType: CommandType.StoredProcedure);
            return data[0].ListCount;
        }

        public TestTypeModel GetTestTypeUsingId(int Id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", Id, DbType.Int32);
            dbPara.Add("Mode", "Get", DbType.String);
            var data = _MyLabHelper.GetAll<TestTypeModel>("[dbo].[SP_GetTestTypeByID]", dbPara, commandType: CommandType.StoredProcedure);
            return data[0];
        }
        public List<TestDetModel> GetPTestResult(long Id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", Id, DbType.Int32); 
            var data = _MyLabHelper.GetAll<TestDetModel>("[dbo].[SP_GetTestResultByTestMstID]", dbPara, commandType: CommandType.StoredProcedure);
            return data;
        }

        public long DeleteTestTypeById(int Id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", Id, DbType.Int32);
            dbPara.Add("Mode", "Delete", DbType.String);
            var data = _MyLabHelper.Insert<long>("[dbo].[SP_GetTestTypeByID]", dbPara, commandType: CommandType.StoredProcedure);
            return data;
        }

        public long InsertUpdatePathalogyTest(PathalogyTestMaster model)
        {
            long MSTID;
            long DETID;
            var dbPara = new DynamicParameters();
            using (IDbConnection db = new SqlConnection(_config.GetConnectionString("DatabaseContext")))
            { 
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    using (var tran = db.BeginTransaction())
                    {
                        try
                        {
                            dbPara.Add("TESTMST_CurrentId", string.IsNullOrEmpty(model.TESTMST_CurrentId) ? 0: Convert.ToInt64(model.TESTMST_CurrentId), DbType.Int64);
                            dbPara.Add("TESTMST_Name", model.TESTMST_Name, DbType.String);
                            dbPara.Add("TESTMST_PrintFormat", model.TESTMST_PrintFormat, DbType.String);
                            dbPara.Add("TESTMST_Rate",string.IsNullOrEmpty(model.TESTMST_Rate) ? null : Convert.ToDecimal( model.TESTMST_Rate), DbType.Decimal);
                            dbPara.Add("TESTMST_ReportHeading", model.TESTMST_ReportHeading, DbType.String);
                            dbPara.Add("Type", model.Type, DbType.String);
                            dbPara.Add("TESTMST_Testcost", string.IsNullOrEmpty(model.TESTMST_Testcost) ? null : Convert.ToDecimal(model.TESTMST_Testcost), DbType.Decimal);
                            dbPara.Add("TESTMST_Alias", model.TESTMST_Alias, DbType.String);
                            dbPara.Add("TESTMST_Percentage", string.IsNullOrEmpty(model.TESTMST_Percentage) ? null : Convert.ToDecimal(model.TESTMST_Percentage), DbType.Decimal);
                            dbPara.Add("TESTMST_Lumsum", string.IsNullOrEmpty(model.TESTMST_Lumsum) ? null : Convert.ToDecimal(model.TESTMST_Lumsum), DbType.Decimal);
                            dbPara.Add("Active", model.Active, DbType.Boolean);
                            dbPara.Add("Comments", model.Comments, DbType.String);
                            dbPara.Add("TESTMST_Companyid", string.IsNullOrEmpty(model.TESTMST_Companyid) ? null : Convert.ToInt64(model.TESTMST_Companyid), DbType.Int64);
                            dbPara.Add("TESTMST_TestTypeId", string.IsNullOrEmpty(model.TESTMST_TestTypeId) ? null : Convert.ToInt64(model.TESTMST_TestTypeId), DbType.Int64);
                            dbPara.Add("TESTMST_CatType", model.TESTMST_CatType, DbType.String);
                            dbPara.Add("SpecialTest", model.SpecialTest, DbType.Boolean);
                            dbPara.Add("TESTMST_sample", model.TESTMST_sample, DbType.String);
                            dbPara.Add("IsKitImageCompulsary", model.IsKitImageCompulsary, DbType.Boolean);
                            dbPara.Add("TAT", model.TAT, DbType.String);
                            dbPara.Add("IsNABL", model.IsNABL, DbType.Boolean);
                            dbPara.Add("UserId", model.UserId, DbType.Int32);
                            MSTID = db.Query<long>("[dbo].[SP_InsertUpdateTestMasterList]", dbPara,commandType: CommandType.StoredProcedure, transaction: tran).FirstOrDefault();

                            dbPara = new DynamicParameters();
                            dbPara.Add("TestMasterID", MSTID, DbType.Int64);
                            var temp =  db.Query<long>("[dbo].[SP_DeletePREDEFVAL]", dbPara, commandType: CommandType.StoredProcedure, transaction: tran).FirstOrDefault();

                            dbPara = new DynamicParameters();
                            dbPara.Add("TESTDET_TestMasterID", MSTID, DbType.Int64);
                            temp = db.Query<long>("[dbo].[SP_DeleteTESTDETByTestMasterID]", dbPara, commandType: CommandType.StoredProcedure, transaction: tran).FirstOrDefault();
                        
                            if (model.PathalogyTestDetails.Count > 0)
                            {
                                for (int count = 0; count < model.PathalogyTestDetails.Count; count++)
                                {
                                    dbPara = new DynamicParameters();
                                    dbPara.Add("TESTDET_TestMasterID", MSTID, DbType.Int64);
                                    dbPara.Add("TESTDET_FieldNo",string.IsNullOrEmpty(model.PathalogyTestDetails[count].TESTDET_FieldNo)?null: Convert.ToInt64( model.PathalogyTestDetails[count].TESTDET_FieldNo), DbType.Int64);
                                    dbPara.Add("TESTDET_FieldName", model.PathalogyTestDetails[count].TESTDET_FieldName, DbType.String);
                                    dbPara.Add("TESTDET_FieldType", string.IsNullOrEmpty(model.PathalogyTestDetails[count].TESTDET_FieldType) ? null : Convert.ToInt64(model.PathalogyTestDetails[count].TESTDET_FieldType), DbType.Int64);
                                    dbPara.Add("TESTDET_NormalValue", model.PathalogyTestDetails[count].TESTDET_NormalValue, DbType.String);
                                    dbPara.Add("TESTDET_Description", model.PathalogyTestDetails[count].TESTDET_Description, DbType.String);
                                    dbPara.Add("TESTDET_GroupName", model.PathalogyTestDetails[count].TESTDET_GroupName, DbType.String);
                                    dbPara.Add("TESTDET_GroupNo", string.IsNullOrEmpty(model.PathalogyTestDetails[count].TESTDET_GroupNo) ? null : Convert.ToInt64(model.PathalogyTestDetails[count].TESTDET_GroupNo), DbType.Int64);
                                    dbPara.Add("TESTDET_FieldStyle", string.IsNullOrEmpty(model.PathalogyTestDetails[count].TESTDET_FieldStyle) ? null : Convert.ToInt64(model.PathalogyTestDetails[count].TESTDET_FieldStyle), DbType.Int64);
                                    dbPara.Add("TESTDET_Compulsory",  model.PathalogyTestDetails[count].TESTDET_Compulsory, DbType.Boolean);
                                    dbPara.Add("TESTDET_MaxValue", string.IsNullOrEmpty(model.PathalogyTestDetails[count].TESTDET_MaxValue) ? null : Convert.ToDecimal(model.PathalogyTestDetails[count].TESTDET_MaxValue), DbType.Decimal);
                                    dbPara.Add("TESTDET_MinValue", string.IsNullOrEmpty(model.PathalogyTestDetails[count].TESTDET_MinValue) ? null : Convert.ToDecimal(model.PathalogyTestDetails[count].TESTDET_MinValue), DbType.Decimal);
                                    dbPara.Add("TESTDET_sDefault", model.PathalogyTestDetails[count].TESTDET_sDefault, DbType.String);
                                    dbPara.Add("TESTDET_sAlias", model.PathalogyTestDetails[count].TESTDET_sAlias, DbType.String);
                                    dbPara.Add("TESTDET_sUnit", model.PathalogyTestDetails[count].TESTDET_sUnit, DbType.String);
                                    dbPara.Add("TESTDET_sFormula", model.PathalogyTestDetails[count].TESTDET_sFormula, DbType.String);
                                    dbPara.Add("TESTDET_MaxLimit", string.IsNullOrEmpty(model.PathalogyTestDetails[count].TESTDET_MaxLimit) ? null : Convert.ToDecimal(model.PathalogyTestDetails[count].TESTDET_MaxLimit), DbType.Decimal);
                                    dbPara.Add("TESTDET_MinLimit", string.IsNullOrEmpty(model.PathalogyTestDetails[count].TESTDET_MinLimit) ? null : Convert.ToDecimal(model.PathalogyTestDetails[count].TESTDET_MinLimit), DbType.Decimal);
                                    dbPara.Add("TESTDET_Validate", model.PathalogyTestDetails[count].TESTDET_Validate, DbType.Boolean);
                                    dbPara.Add("TESTDET_ANormalValue",  model.PathalogyTestDetails[count].TESTDET_ANormalValue, DbType.String);
                                    dbPara.Add("TESTDET_BNormalValue", model.PathalogyTestDetails[count].TESTDET_BNormalValue, DbType.String);
                                    dbPara.Add("TESTDET_CNormalValue",  model.PathalogyTestDetails[count].TESTDET_CNormalValue, DbType.String);
                                    dbPara.Add("TESTDET_DNormalValue",  model.PathalogyTestDetails[count].TESTDET_DNormalValue, DbType.String);
                                    dbPara.Add("TESTDET_AMaxValue", string.IsNullOrEmpty(model.PathalogyTestDetails[count].TESTDET_AMaxValue) ? null : Convert.ToDecimal(model.PathalogyTestDetails[count].TESTDET_AMaxValue), DbType.Decimal);
                                    dbPara.Add("TESTDET_AMinValue", string.IsNullOrEmpty(model.PathalogyTestDetails[count].TESTDET_AMinValue) ? null : Convert.ToDecimal(model.PathalogyTestDetails[count].TESTDET_AMinValue), DbType.Decimal);
                                    dbPara.Add("TESTDET_BMaxValue", string.IsNullOrEmpty(model.PathalogyTestDetails[count].TESTDET_BMaxValue) ? null : Convert.ToDecimal(model.PathalogyTestDetails[count].TESTDET_BMaxValue), DbType.Decimal);
                                    dbPara.Add("TESTDET_BMinValue", string.IsNullOrEmpty(model.PathalogyTestDetails[count].TESTDET_BMinValue) ? null : Convert.ToDecimal(model.PathalogyTestDetails[count].TESTDET_BMinValue), DbType.Decimal);
                                    dbPara.Add("TESTDET_CMaxValue", string.IsNullOrEmpty(model.PathalogyTestDetails[count].TESTDET_CMaxValue) ? null : Convert.ToDecimal(model.PathalogyTestDetails[count].TESTDET_CMaxValue), DbType.Decimal);
                                    dbPara.Add("TESTDET_CMinValue", string.IsNullOrEmpty(model.PathalogyTestDetails[count].TESTDET_CMinValue) ? null : Convert.ToDecimal(model.PathalogyTestDetails[count].TESTDET_CMinValue), DbType.Decimal);
                                    dbPara.Add("TESTDET_DMaxValue", string.IsNullOrEmpty(model.PathalogyTestDetails[count].TESTDET_DMaxValue) ? null : Convert.ToDecimal(model.PathalogyTestDetails[count].TESTDET_DMaxValue), DbType.Decimal);
                                    dbPara.Add("TESTDET_DMinValue", string.IsNullOrEmpty(model.PathalogyTestDetails[count].TESTDET_DMinValue) ? null : Convert.ToDecimal(model.PathalogyTestDetails[count].TESTDET_DMinValue), DbType.Decimal);
                                    dbPara.Add("TESTDET_TestTypeId", string.IsNullOrEmpty(model.PathalogyTestDetails[count].TESTDET_TestTypeId) ? null : Convert.ToInt64(model.PathalogyTestDetails[count].TESTDET_TestTypeId), DbType.Int64);
                                    dbPara.Add("TESTDET_CatTypeId", string.IsNullOrEmpty(model.PathalogyTestDetails[count].TESTDET_CatTypeId) ? null : Convert.ToInt64(model.PathalogyTestDetails[count].TESTDET_CatTypeId), DbType.Int64);
                                    dbPara.Add("ValueForNormal", model.PathalogyTestDetails[count].ValueForNormal, DbType.String);
                                    DETID= db.Query<long>("[dbo].[SP_InsertTestDetails]", dbPara,commandType: CommandType.StoredProcedure, transaction: tran).FirstOrDefault();
                          
                                    if (model.PathalogyTestDetails[count].PREDEFVALModel != null)
                                    {
                                        for (int count2 = 0; count2 < model.PathalogyTestDetails[count].PREDEFVALModel.Count; count2++)
                                        {
                                            dbPara = new DynamicParameters();
                                            dbPara.Add("PREDEFVAL_Fieldid", DETID, DbType.Int64);
                                            dbPara.Add("PREDEFVAL_ValNo", count2, DbType.Int64);
                                            dbPara.Add("PREDEFVAL_Value", model.PathalogyTestDetails[count].PREDEFVALModel[count2].PREDEFVAL_Value, DbType.String);
                                            db.Query<long>("[dbo].[SP_InsertPREDEFVAL]", dbPara,commandType: CommandType.StoredProcedure, transaction: tran).FirstOrDefault();
                                        }
                                    }
                                }
                            }

                            tran.Commit();
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            throw ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (db.State == ConnectionState.Open)
                        db.Close();
                }

                return MSTID;
            }

            #region using dapper


            #endregion using dapper
        }

        public long InsertUpdateTest(PathalogyTestMaster model)
        {
            long MSTID;
            long DETID;
            var dbPara = new DynamicParameters();
            using (IDbConnection db = new SqlConnection(_config.GetConnectionString("DatabaseContext")))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    using (var tran = db.BeginTransaction())
                    {
                        try
                        {
                            dbPara.Add("TESTMST_CurrentId", string.IsNullOrEmpty(model.TESTMST_CurrentId) ? 0 : Convert.ToInt64(model.TESTMST_CurrentId), DbType.Int64);
                            dbPara.Add("TESTMST_Name", model.TESTMST_Name, DbType.String);
                            dbPara.Add("TESTMST_PrintFormat", model.TESTMST_PrintFormat, DbType.String);
                            dbPara.Add("TESTMST_Rate", string.IsNullOrEmpty(model.TESTMST_Rate) ? null : Convert.ToDecimal(model.TESTMST_Rate), DbType.Decimal);
                            dbPara.Add("TESTMST_ReportHeading", model.TESTMST_ReportHeading, DbType.String);
                            dbPara.Add("Type", model.Type, DbType.String);
                            dbPara.Add("TESTMST_Testcost", string.IsNullOrEmpty(model.TESTMST_Testcost) ? null : Convert.ToDecimal(model.TESTMST_Testcost), DbType.Decimal);
                            dbPara.Add("TESTMST_Alias", model.TESTMST_Alias, DbType.String);
                            dbPara.Add("TESTMST_Percentage", string.IsNullOrEmpty(model.TESTMST_Percentage) ? null : Convert.ToDecimal(model.TESTMST_Percentage), DbType.Decimal);
                            dbPara.Add("TESTMST_Lumsum", string.IsNullOrEmpty(model.TESTMST_Lumsum) ? null : Convert.ToDecimal(model.TESTMST_Lumsum), DbType.Decimal);
                            dbPara.Add("Active", model.Active, DbType.Boolean);
                            dbPara.Add("Comments", model.Comments, DbType.String);
                            dbPara.Add("TESTMST_Companyid", string.IsNullOrEmpty(model.TESTMST_Companyid) ? null : Convert.ToInt64(model.TESTMST_Companyid), DbType.Int64);
                            dbPara.Add("TESTMST_TestTypeId", string.IsNullOrEmpty(model.TESTMST_TestTypeId) ? null : Convert.ToInt64(model.TESTMST_TestTypeId), DbType.Int64);
                            dbPara.Add("TESTMST_CatType", model.TESTMST_CatType, DbType.String);
                            dbPara.Add("SpecialTest", model.SpecialTest, DbType.Boolean);
                            dbPara.Add("TESTMST_sample", model.TESTMST_sample, DbType.String);
                            dbPara.Add("IsKitImageCompulsary",null, DbType.Boolean);
                            dbPara.Add("TAT", model.TAT, DbType.String);
                            dbPara.Add("IsNABL", model.IsNABL, DbType.Boolean);
                            dbPara.Add("UserId", model.UserId, DbType.Int32);
                            MSTID = db.Query<long>("[dbo].[SP_InsertUpdateTestMasterList]", dbPara, commandType: CommandType.StoredProcedure, transaction: tran).FirstOrDefault();

                            dbPara = new DynamicParameters();
                            dbPara.Add("TEST_TestMasterID", MSTID, DbType.Int64);
                            var temp = db.Query<long>("[dbo].[SP_DeleteTestFormatDetails]", dbPara, commandType: CommandType.StoredProcedure, transaction: tran).FirstOrDefault();

                             if (model.TestFormatDetails != null)
                            {
                                for (int count = 0; count < model.TestFormatDetails.Count; count++)
                                {
                                    dbPara = new DynamicParameters();
                                    dbPara.Add("TEST_TestMasterID", MSTID, DbType.Int64);
                                    dbPara.Add("TEST_FieldName", model.TestFormatDetails[count].TEST_FieldName, DbType.String);
                                    dbPara.Add("TEST_FormatSrNo",count, DbType.Int64);
                                    dbPara.Add("TEST_sDefault", model.TestFormatDetails[count].TEST_sDefault, DbType.String);

                                    DETID = db.Query<long>("[dbo].[SP_InsertTestFormatDetails]", dbPara, commandType: CommandType.StoredProcedure, transaction: tran).FirstOrDefault();
                                 }
                            }

                            tran.Commit();
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            throw ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (db.State == ConnectionState.Open)
                        db.Close();
                }

                return MSTID;
            }

            #region using dapper


            #endregion using dapper
        }

        public long InsertUpdateProfileTest(ProfileTestModel model)
        {
            long MSTID;
            long DETID;
            var dbPara = new DynamicParameters();
            using (IDbConnection db = new SqlConnection(_config.GetConnectionString("DatabaseContext")))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    using (var tran = db.BeginTransaction())
                    {
                        try
                        {
                            dbPara.Add("TESTMST_CurrentId", string.IsNullOrEmpty(model.TESTMST_CurrentId) ? 0 : Convert.ToInt64(model.TESTMST_CurrentId), DbType.Int64);
                            dbPara.Add("TESTMST_Name", model.TESTMST_Name, DbType.String);
                            dbPara.Add("TESTMST_PrintFormat", model.TESTMST_PrintFormat, DbType.String);
                            dbPara.Add("TESTMST_Rate", string.IsNullOrEmpty(model.TESTMST_Rate) ? null : Convert.ToDecimal(model.TESTMST_Rate), DbType.Decimal);
                            dbPara.Add("TESTMST_ReportHeading", model.TESTMST_ReportHeading, DbType.String);
                            dbPara.Add("Type", model.Type, DbType.String);
                            dbPara.Add("TESTMST_Testcost", string.IsNullOrEmpty(model.TESTMST_Testcost) ? null : Convert.ToDecimal(model.TESTMST_Testcost), DbType.Decimal);
                            dbPara.Add("TESTMST_Alias", model.TESTMST_Alias, DbType.String);
                            dbPara.Add("TESTMST_Percentage", string.IsNullOrEmpty(model.TESTMST_Percentage) ? null : Convert.ToDecimal(model.TESTMST_Percentage), DbType.Decimal);
                            dbPara.Add("TESTMST_Lumsum", string.IsNullOrEmpty(model.TESTMST_Lumsum) ? null : Convert.ToDecimal(model.TESTMST_Lumsum), DbType.Decimal);
                            dbPara.Add("Active", model.Active, DbType.Boolean);
                            dbPara.Add("Comments", model.Comments, DbType.String);
                            dbPara.Add("TESTMST_Companyid", string.IsNullOrEmpty(model.TESTMST_Companyid) ? null : Convert.ToInt64(model.TESTMST_Companyid), DbType.Int64);
                            dbPara.Add("TESTMST_TestTypeId", string.IsNullOrEmpty(model.TESTMST_TestTypeId) ? null : Convert.ToInt64(model.TESTMST_TestTypeId), DbType.Int64);
                            dbPara.Add("TESTMST_CatType", model.TESTMST_CatType, DbType.String);
                            dbPara.Add("SpecialTest", model.SpecialTest, DbType.Boolean);
                            dbPara.Add("TESTMST_sample", model.TESTMST_sample, DbType.String);
                            dbPara.Add("IsKitImageCompulsary", null, DbType.Boolean);
                            dbPara.Add("TAT", model.TAT, DbType.String);
                            dbPara.Add("IsNABL", model.IsNABL, DbType.Boolean);
                            dbPara.Add("UserId", model.UserId, DbType.Int32);
                            MSTID = db.Query<long>("[dbo].[SP_InsertUpdateTestMasterList]", dbPara, commandType: CommandType.StoredProcedure, transaction: tran).FirstOrDefault();

                            dbPara = new DynamicParameters();
                            dbPara.Add("TEST_TestMasterID", MSTID, DbType.Int64);
                            var temp = db.Query<long>("[dbo].[SP_DeleteTestFormatDetails]", dbPara, commandType: CommandType.StoredProcedure, transaction: tran).FirstOrDefault();

                            if (model.TestFormatDetails != null)
                            {
                                for (int count = 0; count < model.TestFormatDetails.Count; count++)
                                {
                                    dbPara = new DynamicParameters();
                                    dbPara.Add("TEST_TestMasterID", MSTID, DbType.Int64);
                                    dbPara.Add("TEST_FieldName", model.TestFormatDetails[count].TESTMST_Name, DbType.String);
                                    dbPara.Add("TEST_FormatSrNo", model.TestFormatDetails[count].TESTMST_CurrentId, DbType.Int64);
                                    dbPara.Add("TEST_sDefault", model.TestFormatDetails[count].TEST_sDefault, DbType.String);
                                    DETID = db.Query<long>("[dbo].[SP_InsertTestFormatDetails]", dbPara, commandType: CommandType.StoredProcedure, transaction: tran).FirstOrDefault();
                                }
                            }

                            tran.Commit();
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            throw ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (db.State == ConnectionState.Open)
                        db.Close();
                }

                return MSTID;
            }

            #region using dapper


            #endregion using dapper
        }

        public long InsertUpdatePathalogyTestDetails(PathalogyTestDetails model)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("TESTDET_CurrentId   ", model.TESTDET_CurrentId, DbType.Int32);
            dbPara.Add("TESTDET_TestMasterID", model.TESTDET_TestMasterID, DbType.String);
            dbPara.Add("TESTDET_FieldNo  	", model.TESTDET_FieldNo, DbType.Int32);
            dbPara.Add("TESTDET_FieldName	", model.TESTDET_FieldName, DbType.String);
            dbPara.Add("TESTDET_FieldType	", model.TESTDET_FieldType, DbType.Int32);
            dbPara.Add("TESTDET_NormalValue	", model.TESTDET_NormalValue, DbType.String);
            dbPara.Add("TESTDET_Description	", model.TESTDET_Description, DbType.String);
            dbPara.Add("TESTDET_GroupName  	", model.TESTDET_GroupName, DbType.String);
            dbPara.Add("TESTDET_GroupNo  	", model.TESTDET_GroupNo, DbType.Int32);
            dbPara.Add("TESTDET_FieldStyle 	", model.TESTDET_FieldStyle, DbType.Int32);
            dbPara.Add("TESTDET_Compulsory 	", model.TESTDET_Compulsory, DbType.Boolean);
            dbPara.Add("TESTDET_MaxValue  	", model.TESTDET_MaxValue, DbType.Decimal);
            dbPara.Add("TESTDET_MinValue  	", model.TESTDET_MinValue, DbType.Decimal);
            dbPara.Add("TESTDET_sDefault  	", model.TESTDET_sDefault, DbType.String);
            dbPara.Add("TESTDET_sAlias 		", model.TESTDET_sAlias, DbType.String);
            dbPara.Add("TESTDET_sUnit  		", model.TESTDET_sUnit, DbType.String);
            dbPara.Add("TESTDET_sFormula  	", model.TESTDET_sFormula, DbType.String);
            dbPara.Add("TESTDET_MaxLimit  	", model.TESTDET_MaxLimit, DbType.Decimal);
            dbPara.Add("TESTDET_MinLimit  	", model.TESTDET_MinLimit, DbType.Decimal);
            dbPara.Add("TESTDET_Validate  	", model.TESTDET_Validate, DbType.Boolean);
            dbPara.Add("TESTDET_ANormalValue", model.TESTDET_ANormalValue, DbType.String);
            dbPara.Add("TESTDET_BNormalValue", model.TESTDET_BNormalValue, DbType.String);
            dbPara.Add("TESTDET_CNormalValue", model.TESTDET_CNormalValue, DbType.String);
            dbPara.Add("TESTDET_DNormalValue", model.TESTDET_DNormalValue, DbType.String);
            dbPara.Add("TESTDET_AMaxValue	", model.TESTDET_AMaxValue, DbType.Decimal);
            dbPara.Add("TESTDET_AMinValue	", model.TESTDET_AMinValue, DbType.Decimal);
            dbPara.Add("TESTDET_BMaxValue	", model.TESTDET_BMaxValue, DbType.Decimal);
            dbPara.Add("TESTDET_BMinValue	", model.TESTDET_BMinValue, DbType.Decimal);
            dbPara.Add("TESTDET_CMaxValue	", model.TESTDET_CMaxValue, DbType.Decimal);
            dbPara.Add("TESTDET_CMinValue	", model.TESTDET_CMinValue, DbType.Decimal);
            dbPara.Add("TESTDET_DMaxValue	", model.TESTDET_DMaxValue, DbType.Decimal);
            dbPara.Add("TESTDET_DMinValue	", model.TESTDET_DMinValue, DbType.Decimal);
            dbPara.Add("TESTDET_TestTypeId	", model.TESTDET_TestTypeId, DbType.Int32);
            dbPara.Add("TESTDET_CatTypeId 	", model.TESTDET_CatTypeId, DbType.Int32);
            dbPara.Add("ValueForNormal		", model.ValueForNormal, DbType.String);

            #region using dapper

            var data = _MyLabHelper.Insert<long>("[dbo].[SP_InsertPathalogyTestDetails]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;

            #endregion using dapper
        }

        public PathalogyTestMaster GetPathalogyTestMasterUsingId(int Id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", Id, DbType.Int32);
            dbPara.Add("Mode", "Header", DbType.String);
            var data = _MyLabHelper.GetAll<PathalogyTestMaster>("[dbo].[SP_GetPathalogyTestByID]", dbPara, commandType: CommandType.StoredProcedure);
            return data[0];
        }

        public long DeletePathalogyTestMaster(int Id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", Id, DbType.Int32);
            dbPara.Add("Mode", "Delete", DbType.String);
            var data = _MyLabHelper.Insert<long>("[dbo].[SP_GetPathalogyTestByID]", dbPara, commandType: CommandType.StoredProcedure);
            return data;
        }

        public List<PathalogyTestDetails> GetPathalogyTestDetailsUsingId(int Id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", Id, DbType.Int32);
            dbPara.Add("Mode", "Details", DbType.String);
            var data = _MyLabHelper.GetAll<PathalogyTestDetails>("[dbo].[SP_GetPathalogyTestByID]", dbPara, commandType: CommandType.StoredProcedure);
            return data;
        }

        public List<PathalogyTestMaster> GetPathalogyTestSearch(SearchByKeywordPageNoPageSizeType m)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", m.PageNo, DbType.Int32);
            dbPara.Add("PageSize", m.PageSize, DbType.Int32);
            dbPara.Add("Keyword", m.Keyword == "NoSearch" ? "" : m.Keyword.Trim(), DbType.String);
            dbPara.Add("Type", m.Type == "NoSearch" ? "" : m.Type.Trim(), DbType.String);
            var data = _MyLabHelper.GetAll<PathalogyTestMaster>("[dbo].[SP_GetTestListByType]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public long GetPathalogyTestSearchCount(SearchByKeywordType m)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", -1, DbType.Int32);
            dbPara.Add("PageSize", 0, DbType.Int32);
            dbPara.Add("Keyword", m.Keyword == "NoSearch" ? "" : m.Keyword.Trim(), DbType.String);
            dbPara.Add("Type", m.Type == "NoSearch" ? "" : m.Type.Trim(), DbType.String);
            var data = _MyLabHelper.Get<Count>("[dbo].[SP_GetTestListByType]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ListCount;
        }

        public long InsertTestFormatDetails(TestFormatDetails model)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("TEST_TestMasterID", model.TEST_TestMasterID, DbType.Int32);
            dbPara.Add("TEST_FieldName", model.TEST_FieldName, DbType.String);
            dbPara.Add("TEST_FormatSrNo", model.TEST_FormatSrNo, DbType.Int32);
            dbPara.Add("TEST_sDefault", model.TEST_sDefault, DbType.String);

            #region using dapper

            var data = _MyLabHelper.Insert<long>("[dbo].[SP_InsertTestFormatDetails]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;

            #endregion using dapper
        }

        public long DeleteTestFormat(int Id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", Id, DbType.Int32);
            dbPara.Add("Mode", "Delete", DbType.String);
            var data = _MyLabHelper.Insert<long>("[dbo].[SP_GetTestForamtDetailsByID]", dbPara, commandType: CommandType.StoredProcedure);
            return data;
        }

        public List<TestFormatDetails> GetTestFormatDetailList(int Id)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", Id, DbType.Int32);
            dbPara.Add("Mode", "List", DbType.String);
            var data = _MyLabHelper.GetAll<TestFormatDetails>("[dbo].[SP_GetTestForamtDetailsByID]", dbPara, commandType: CommandType.StoredProcedure);
            return data;
        }


        public long InsertUpdateNarration(NarrationModel model)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("NarrationId", model.NarrationId, DbType.Int32);
            dbPara.Add("NarrationText", model.NarrationText, DbType.String);

            #region using dapper

            var data = _MyLabHelper.Insert<long>("[dbo].[SP_InsertUpdateNARRATIONS]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;

            #endregion using dapper
        }
        public List<NarrationModel> GetNarrationSearch(SearchFilters m)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", m.PageNo, DbType.Int32);
            dbPara.Add("PageSize", m.PageSize, DbType.Int32);
            dbPara.Add("Keyword", m.Keyword == "NoSearch" ? "" : m.Keyword.Trim(), DbType.String);
            var data = _MyLabHelper.GetAll<NarrationModel>("[dbo].[SP_NARRATIONSList]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public long GetNarrationSearchCount(SearchFilters m)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", -1, DbType.Int32);
            dbPara.Add("PageSize", 0, DbType.Int32);
            dbPara.Add("Keyword", m.Keyword == "NoSearch" ? "" : m.Keyword.Trim(), DbType.String);
            var data = _MyLabHelper.GetAll<CountModel>("[dbo].[SP_NARRATIONSList]", dbPara, commandType: CommandType.StoredProcedure);
            return data[0].ListCount;
        }



        public long InsertUpdateReSampleReason(NarrationModel model)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("NarrationId", model.NarrationId, DbType.Int32);
            dbPara.Add("NarrationText", model.NarrationText, DbType.String);
            dbPara.Add("UserId", model.UserId, DbType.Int32);
            #region using dapper

            var data = _MyLabHelper.Insert<long>("[dbo].[SP_InsertUpdateReSampleNARRATIONS]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;

            #endregion using dapper
        }
        public List<NarrationModel> GetReSampleReasonSearch(SearchFilters m)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", m.PageNo, DbType.Int32);
            dbPara.Add("PageSize", m.PageSize, DbType.Int32);
            dbPara.Add("Keyword", m.Keyword == "NoSearch" ? "" : m.Keyword.Trim(), DbType.String);
            var data = _MyLabHelper.GetAll<NarrationModel>("[dbo].[SP_ReSampleNARRATIONSList]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public long GetReSampleReasonSearchCount(SearchFilters m)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", -1, DbType.Int32);
            dbPara.Add("PageSize", 0, DbType.Int32);
            dbPara.Add("Keyword", m.Keyword == "NoSearch" ? "" : m.Keyword.Trim(), DbType.String);
            var data = _MyLabHelper.GetAll<CountModel>("[dbo].[SP_ReSampleNARRATIONSList]", dbPara, commandType: CommandType.StoredProcedure);
            return data[0].ListCount;
        }

        public long InsertRemarkMaster( List< TestDetModel> model,string ID)
        {
            long MSTID=0;
            var dbPara = new DynamicParameters();
            using (IDbConnection db = new SqlConnection(_config.GetConnectionString("DatabaseContext")))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    using (var tran = db.BeginTransaction())
                    {
                        try
                        {
                           
                             dbPara = new DynamicParameters();
                            dbPara.Add("TESTDET_TestMasterID", model[0].TESTDET_TestMasterID, DbType.Int64);
                            var temp = db.Query<long>("[dbo].[SP_DeleteResultMaster]", dbPara, commandType: CommandType.StoredProcedure, transaction: tran).FirstOrDefault();
                            int counter=0;
                            if (model != null)
                            {

                                foreach (var item in model)
                                {
                                    if (item.sms == true)
                                    {
                                        dbPara = new DynamicParameters();
                                        dbPara.Add("TESTDET_TestMasterID", model[0].TESTDET_TestMasterID, DbType.Int64);
                                        dbPara.Add("TESTDET_FieldNo", item.TESTDET_FieldNo, DbType.Int64);
                                        dbPara.Add("type", "sms", DbType.String);
                                        dbPara.Add("UserId", ID, DbType.Int32);

                                        
                                        MSTID = db.Query<long>("[dbo].[SP_InsertResultMaster]", dbPara, commandType: CommandType.StoredProcedure, transaction: tran).FirstOrDefault();
                                    }
                                    if (model[counter].work == true)
                                    {
                                        dbPara = new DynamicParameters();
                                        dbPara.Add("TESTDET_TestMasterID", model[0].TESTDET_TestMasterID, DbType.Int64);
                                        dbPara.Add("TESTDET_FieldNo", item.TESTDET_FieldNo, DbType.Int64);
                                        dbPara.Add("type", "work", DbType.String);
                                        dbPara.Add("UserId", ID, DbType.Int32);
                                        MSTID = db.Query<long>("[dbo].[SP_InsertResultMaster]", dbPara, commandType: CommandType.StoredProcedure, transaction: tran).FirstOrDefault();
                                    }

                                } 

                            }

                            tran.Commit();
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            throw ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (db.State == ConnectionState.Open)
                        db.Close();
                }

                return MSTID;
            }

            #region using dapper


            #endregion using dapper
        }

        #region "Added by suman"
        public List<PAIT_HDR_DET_TEST_New> GetAllTestDetailsbyPatientID(long ID)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Mode", "Details", DbType.String);
            dbPara.Add("Keyword", "", DbType.String);
            DateTime FDate = DateTime.ParseExact(DateTime.Now.Date.ToString("MM-dd-yyyy"), "MM-dd-yyyy", null);
            dbPara.Add("FromDate", FDate, DbType.DateTime);
            dbPara.Add("ToDate", FDate, DbType.DateTime);
            dbPara.Add("Id", ID, DbType.Int32);
            var data = _MyLabHelper.GetAll<PAIT_HDR_DET_TEST_New>("[dbo].[USP_AllTestorPatientEntry]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public List<PatientMasterModel> GetPatientListforDataEntry(string Keyword, string FromDate, string ToDate)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Mode", "List", DbType.String);
            
            if (Keyword == "" || Keyword == null | Keyword == "null")
            {
                dbPara.Add("Keyword", "", DbType.String);
            }
            else
            {
                dbPara.Add("Keyword", Keyword, DbType.String);
            }
            //DateTime FDate = DateTime.ParseExact(DateTime.Now.Date.ToString("MM-dd-yyyy"), "MM-dd-yyyy", null);
            if (FromDate == null || ToDate == "null" || ToDate == "")
            {

                DateTime FDate = DateTime.ParseExact(DateTime.Now.Date.ToString("MM-dd-yyyy"), "MM-dd-yyyy", null);
                dbPara.Add("FromDate", FDate, DbType.DateTime);
                dbPara.Add("ToDate", FDate, DbType.DateTime);
            }
            else
            {
                dbPara.Add("FromDate", DateTime.ParseExact(FromDate, "MM-dd-yyyy", null), DbType.DateTime);
                dbPara.Add("ToDate", DateTime.ParseExact(ToDate, "MM-dd-yyyy", null), DbType.DateTime);
            }
            dbPara.Add("Id", 0, DbType.Int32);
            var data = _MyLabHelper.GetAll<PatientMasterModel>("[dbo].[USP_AllTestorPatientEntry]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public List<PAIT_HDR_DET_TEST_New> GetPatientAllTestDetail(long ID)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", ID, DbType.Int32);

            var data = _MyLabHelper.GetAll<PAIT_HDR_DET_TEST_New>("[dbo].[SP_GetAllTestDetailByPatientId]", dbPara, commandType: CommandType.StoredProcedure);
            for (int i = 0; i < data.Count; i++)
            {
                if (Convert.ToInt32(data[i].TESTDET_FieldType) == 1)
                {
                    List<PREDEFVALModel> PREDEFVALModel = new List<PREDEFVALModel>();
                    var PREDEFVALSTRING = GetPreDefineValue(data[i].DOCDET_lHeaderId, data[i].DOCDET_lFieldNo, "Patient Detail");
                    if (PREDEFVALSTRING != null)
                    {

                        List<string> result = PREDEFVALSTRING.Split(',').ToList();
                        for (int k = 0; k < result.Count; k++)
                        {
                            PREDEFVALModel PREDEFVALModel1 = new PREDEFVALModel();
                            PREDEFVALModel1.PREDEFVAL_Value = result[k];
                            PREDEFVALModel.Add(PREDEFVALModel1);
                        }
                        data[i].PREDEFVALModel = PREDEFVALModel;
                    }
                }

            }
            return data.ToList();
        }

        public string GetPreDefineValue(int HeaderId, int FieldNo, string type)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("HeaderId", HeaderId, DbType.Int32);
            dbPara.Add("FieldNo", FieldNo, DbType.Int32);
            dbPara.Add("type", type, DbType.String);
            var data = _MyLabHelper.Get<string>("[dbo].[USP_GETPREDEFINEVALUE]", dbPara, commandType: CommandType.StoredProcedure);
            return data;
        }

        #endregion
    }
}