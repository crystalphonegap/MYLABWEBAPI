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
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;

namespace myLabWebApi.Services
{
    public class PATIENTService : IPatientService
    {
        private readonly IConfiguration _config;
        private readonly IMyLabHelper _MyLabHelper;
        private readonly ILogger _ILogger;


        public PATIENTService(IMyLabHelper MyLabHelper, ILogger ILoggerservice, IConfiguration config)
        {
            _config = config;
            _ILogger = ILoggerservice;
            _MyLabHelper = MyLabHelper;
        }

        public int Create(PatientMasterModel PATIENT, string strMode)
        {

            var dbPara = new DynamicParameters();
            dbPara.Add("AddEditFlag", strMode, DbType.String);
            dbPara.Add("LabSeriesSetting", PATIENT.LabSeriesSetting, DbType.String);
            dbPara.Add("Patient_Id", PATIENT.Patient_Id, DbType.Int16);
            dbPara.Add("PATIENT_Name", PATIENT.PATIENT_Name, DbType.String);
            dbPara.Add("PATIENT_Address1", PATIENT.PATIENT_Address1, DbType.String);
            dbPara.Add("PATIENT_Address2", PATIENT.PATIENT_Address2, DbType.String);
            dbPara.Add("PATIENT_SendSms", PATIENT.PATIENT_SendSms, DbType.String);
            dbPara.Add("PATIENT_VisitTime", PATIENT.PATIENT_VisitTime, DbType.String);
            dbPara.Add("PATIENT_Email", PATIENT.PATIENT_Email, DbType.String);
            dbPara.Add("PATIENT_Country", PATIENT.PATIENT_Country, DbType.String);
            dbPara.Add("PATIENT_PaymentMode", PATIENT.Paymode, DbType.String);
            dbPara.Add("PATIENT_Telno", PATIENT.PATIENT_Telno, DbType.String);
            dbPara.Add("PATIENT_Gender", PATIENT.PATIENT_Gender, DbType.String);
            dbPara.Add("PATIENT_Age", PATIENT.PATIENT_Age, DbType.String);
            dbPara.Add("Patient_DocType", PATIENT.Patient_DocType, DbType.String);
            dbPara.Add("CollectionCenterId", PATIENT.CollectionCenterId, DbType.Int64);
            try
            {
                if (string.IsNullOrEmpty(PATIENT.PATIENT_Date))
                {
                    dbPara.Add("PATIENT_Date", null, DbType.DateTime);

                }
                else
                {
                    dbPara.Add("PATIENT_Date", Convert.ToDateTime(PATIENT.PATIENT_Date), DbType.DateTime);

                }
            }
            catch (Exception)
            {
                dbPara.Add("PATIENT_Date", DateTime.Now, DbType.DateTime);
            }


            dbPara.Add("PATIENT_Doctorid", PATIENT.PATIENT_Doctorid, DbType.Int32);
            dbPara.Add("PATIENT_Companyid", PATIENT.PATIENT_Companyid, DbType.Int32);
            dbPara.Add("PATIENT_AmountPaid", string.IsNullOrEmpty(PATIENT.PATIENT_AmountPaid) ? null : Convert.ToDecimal(PATIENT.PATIENT_AmountPaid), DbType.Decimal);
            dbPara.Add("PATIENT_SampleCollected", PATIENT.PATIENT_SampleCollected, DbType.Int32);
            dbPara.Add("Doctorid2", PATIENT.Doctorid2, DbType.Int32);
            dbPara.Add("blnCommission", PATIENT.blnCommission, DbType.Boolean);
            dbPara.Add("labno", PATIENT.labno, DbType.Int32);
            dbPara.Add("WardNo", PATIENT.WardNo, DbType.String);
            dbPara.Add("HOSPTYPE", PATIENT.HOSPTYPE, DbType.String);
            dbPara.Add("TotalAmount", string.IsNullOrEmpty(PATIENT.TotalAmount) ? null : Convert.ToDecimal(PATIENT.TotalAmount), DbType.Decimal);
            dbPara.Add("EmergencyCharges", string.IsNullOrEmpty(PATIENT.EmergencyCharges) ? null : Convert.ToDecimal(PATIENT.EmergencyCharges), DbType.Decimal);
            dbPara.Add("Discount", string.IsNullOrEmpty(PATIENT.Discount) ? null : Convert.ToDecimal(PATIENT.Discount), DbType.Decimal);
            dbPara.Add("EmergencyChargesPecent", string.IsNullOrEmpty(PATIENT.EmergencyChargesPecent) ? null : Convert.ToDecimal(PATIENT.EmergencyChargesPecent), DbType.Decimal);
            try
            {
                if (string.IsNullOrEmpty(PATIENT.Sample_Date))
                {
                    dbPara.Add("Sample_Date", null, DbType.DateTime);

                }
                else
                {
                    dbPara.Add("Sample_Date", Convert.ToDateTime(PATIENT.Sample_Date), DbType.DateTime);

                }
            }
            catch (Exception)
            {
                dbPara.Add("Sample_Date", DateTime.Now, DbType.DateTime);
            }

            try
            {
                if (string.IsNullOrEmpty(PATIENT.PATIENT_DOB))
                {
                    dbPara.Add("PATIENT_DOB", null, DbType.DateTime);

                }
                else
                {
                    dbPara.Add("PATIENT_DOB", Convert.ToDateTime(PATIENT.PATIENT_DOB), DbType.DateTime);

                }
            }
            catch (Exception)
            {
                dbPara.Add("PATIENT_DOB", null, DbType.DateTime);
            }

           

            dbPara.Add("Remarks", PATIENT.Remarks, DbType.String);
            dbPara.Add("DiscountPercent", string.IsNullOrEmpty(PATIENT.DiscountPercent) ? null : Convert.ToDecimal(PATIENT.DiscountPercent), DbType.Decimal);
            dbPara.Add("PATIENT_AgeFlag", PATIENT.PATIENT_AgeFlag, DbType.String);
            dbPara.Add("userid", PATIENT.username, DbType.String);
            dbPara.Add("test_alias", PATIENT.TEST_ALIAS, DbType.String);
            dbPara.Add("Bar_Copiese", PATIENT.Bar_Copiese, DbType.Int32);
            dbPara.Add("Urgent", PATIENT.Urgent, DbType.Int32);
            dbPara.Add("Issent", PATIENT.Issent, DbType.Boolean);
            dbPara.Add("PrintUrgent", PATIENT.PrintUrgent, DbType.Boolean);
            dbPara.Add("Patient_key", PATIENT.Patient_key, DbType.String);
            dbPara.Add("AppointmentId", PATIENT.AppointmentId, DbType.String);
            dbPara.Add("TEST", PATIENT.TEST, DbType.String);
            dbPara.Add("Remark", PATIENT.Remark, DbType.String);
            dbPara.Add("Paymode", PATIENT.Paymode, DbType.String);
            dbPara.Add("UPI_WalletAmount", string.IsNullOrEmpty(PATIENT.UPI_WalletAmount) ? null : Convert.ToDecimal(PATIENT.UPI_WalletAmount), DbType.Decimal);
            dbPara.Add("ChequeAmount", string.IsNullOrEmpty(PATIENT.ChequeAmount) ? null : Convert.ToDecimal(PATIENT.ChequeAmount), DbType.Decimal);
            dbPara.Add("CreditCardAmount", string.IsNullOrEmpty(PATIENT.CreditCardAmount) ? null : Convert.ToDecimal(PATIENT.CreditCardAmount), DbType.Decimal);
            dbPara.Add("NEFT_RTGSAmount", string.IsNullOrEmpty(PATIENT.NEFT_RTGSAmount) ? null : Convert.ToDecimal(PATIENT.NEFT_RTGSAmount), DbType.Decimal);
            dbPara.Add("CashAmount", string.IsNullOrEmpty(PATIENT.CashAmount) ? null : Convert.ToDecimal(PATIENT.CashAmount), DbType.Decimal);
            dbPara.Add("OtherRemarks", PATIENT.OtherRemarks, DbType.String);

            dbPara.Add("TPAID", PATIENT.TPAId, DbType.Int32);
            dbPara.Add("HospitalizeRemark", PATIENT.HospitalizeRemark, DbType.String);
            dbPara.Add("Email1", PATIENT.Email1, DbType.String);
            dbPara.Add("Email2", PATIENT.Email2, DbType.String);
            dbPara.Add("Mobile1", PATIENT.Mobile1, DbType.String);
            dbPara.Add("Mobile2", PATIENT.Mobile2, DbType.String);
            dbPara.Add("City", PATIENT.City, DbType.String);
            dbPara.Add("Area", PATIENT.Area, DbType.String);
            dbPara.Add("State", PATIENT.State, DbType.String);
            dbPara.Add("Pincode", PATIENT.Pincode, DbType.String);
            dbPara.Add("TelephoneNo", PATIENT.TelephoneNo, DbType.String);
            dbPara.Add("FileName", PATIENT.SavedFileName, DbType.String);
            dbPara.Add("ProposalNumber", PATIENT.ProposalNumber, DbType.String);
            dbPara.Add("SavedFileName", PATIENT.SavedFileName, DbType.String);
            dbPara.Add("AddedBy", PATIENT.userid, DbType.String);
            


            var data = _MyLabHelper.Insert<int>("[dbo].[SP_PatientAdd]",
                          dbPara,
                          commandType: CommandType.StoredProcedure);

            if(PATIENT.SavedFileName !=null)
            {
            var dbPara2 = new DynamicParameters();
            dbPara2.Add("@P_DOCUMENTNAME", PATIENT.SavedFileName, DbType.String);
            dbPara2.Add("@P_PATIENTID", PATIENT.Patient_Id, DbType.Int32);
            dbPara2.Add("@P_ADDEDBY", PATIENT.userid, DbType.Int32);
            dbPara2.Add("@P_DocFrom", "Register", DbType.String);

                
            if (strMode=="A")
            {
                dbPara2.Add("@P_ACTION", 'I', DbType.String);
            }
            else
            {
                dbPara2.Add("@P_ACTION", 'U', DbType.String);
            }
           
           
            var data2 = _MyLabHelper.Insert<int>("[dbo].[PRC_MS_PATIENTDOCUMENT_IUD]",
                         dbPara2,
                         commandType: CommandType.StoredProcedure);
            }
            return data;
        }



        public List<PatientMasterModel> GetPatientSearch(int PageNo, int PageSize, string Keyword, string FromDate, string ToDate,string UserId)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", PageNo, DbType.Int32);
            dbPara.Add("PageSize", PageSize, DbType.Int32);
            if (Keyword == "NoSearch")
            {
                dbPara.Add("Keyword", "", DbType.String);
            }
            else
            {
                dbPara.Add("Keyword", Keyword, DbType.String);
            }

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
            dbPara.Add("UserId", UserId, DbType.Int32);
            var data = _MyLabHelper.GetAll<PatientMasterModel>("[dbo].[SP_PatientList]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public long GetPatientSearchCount(string Keyword, string FromDate, string ToDate,string UserId)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", -1, DbType.Int32);
            dbPara.Add("PageSize", 0, DbType.Int32);
            if (Keyword == "NoSearch")
            {
                dbPara.Add("Keyword", "", DbType.String);
            }
            else
            {
                dbPara.Add("Keyword", Keyword, DbType.String);
            }
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
            dbPara.Add("UserId", UserId, DbType.Int32);
            var data = _MyLabHelper.GetAll<PatientMasterModel>("[dbo].[SP_PatientList]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList().Count;
        }
        public List<PAIT_HDR_DET_TEST_New> GetPatientDetail(long ID)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", -3, DbType.Int32);
            dbPara.Add("PageSize", ID, DbType.Int32);
            dbPara.Add("Keyword", "", DbType.String);
            DateTime FDate = DateTime.ParseExact(DateTime.Now.Date.ToString("MM-dd-yyyy"), "MM-dd-yyyy", null);
            dbPara.Add("FromDate", FDate, DbType.DateTime);
            dbPara.Add("ToDate", FDate, DbType.DateTime);
            var data = _MyLabHelper.GetAll<PAIT_HDR_DET_TEST_New>("[dbo].[SP_PatientList]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }



        public List<PAIT_HDR_DET_TEST> GetPatientDetail2(string mobile)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("@P_MOBILE", mobile, DbType.String);

            var data = _MyLabHelper.GetAll<PAIT_HDR_DET_TEST>("[dbo].[PRC_MS_GETPATIENTLISTBY_MOBOILE]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }


        //Use for Get Patient By Mobile No
        public int GetPatientByMobileNoCount(string MobileNo)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("MobileNo", MobileNo, DbType.String);
            var data = _MyLabHelper.GetAll<PatientMasterModel>("[dbo].[USP_GetPatientDetailsByMobileNo]", dbPara, commandType: CommandType.StoredProcedure);
            return data.Count;
        }

        public List<PatientMasterModel> GetPatientByMobileNo(string MobileNo)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("MobileNo", MobileNo, DbType.String);
            var data = _MyLabHelper.GetAll<PatientMasterModel>("[dbo].[USP_GetPatientDetailsByMobileNo]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }
        //Use for Get Patient By Mobile No



        //Commented by suman 23-11-2021
        //public long  UpdateDocDetTestValue(List<PAIT_HDR_DET_TEST> model)
        //{
        //    long data=0;
        //    for (int i = 0; i < model.Count; i++)
        //    {
        //        var dbPara = new DynamicParameters();
        //        dbPara.Add("DOCDET_lHeaderId", model[i].DOCDET_lHeaderId, DbType.Int32);
        //        dbPara.Add("DOCDET_lFieldNo", model[i].DOCDET_lFieldNo, DbType.String);
        //        dbPara.Add("DOCDET_tFieldValue", model[i].DOCDET_tFieldValue, DbType.String);
        //        dbPara.Add("DOCHDR_sDescription", model[0].DOCHDR_sDescription, DbType.String);
        //        dbPara.Add("ResampleReason", model[0].ResampleReason, DbType.String);
        //        dbPara.Add("MarkComplete", model[0].MarkComplete, DbType.String);
        //        dbPara.Add("Rerun", string.IsNullOrEmpty( model[i].Rerun)?false: model[i].Rerun, DbType.Boolean);
        //        data = _MyLabHelper.Insert<long>("[dbo].[SP_UpdateDocDetTestValue]",
        //                      dbPara,
        //                      commandType: CommandType.StoredProcedure);
        //    }
        //    return data;
        //}

        //Commented by suman 23-11-2021

        #region "Added By Suman"

        public long UpdateDocDetTestValue(List<PAIT_HDR_DET_TEST> model)
        {
            long data = 0;
            for (int i = 0; i < model.Count; i++)
            {
                var dbPara = new DynamicParameters();
                dbPara.Add("DOCDET_lHeaderId", model[i].DOCDET_lHeaderId, DbType.Int32);
                dbPara.Add("DOCDET_lFieldNo", model[i].DOCDET_lFieldNo, DbType.String);
                dbPara.Add("DOCDET_tFieldValue", model[i].DOCDET_tFieldValue, DbType.String);
                dbPara.Add("Rerun", string.IsNullOrEmpty(model[i].Rerun) ? false : model[i].Rerun, DbType.Boolean);
                data = _MyLabHelper.Insert<long>("[dbo].[SP_UpdateDocDetTestValue]",
                              dbPara,
                              commandType: CommandType.StoredProcedure);
            }
            if (model.Count > 0)
            {
                int dochdrid = 0;
                for (int j = 0; j < model.Count; j++)
                {

                    if (dochdrid != model[j].DOCDET_lHeaderId)
                    {
                        var dbPara = new DynamicParameters();
                        dbPara.Add("DOCDET_lHeaderId", model[j].DOCDET_lHeaderId, DbType.Int32);
                        dbPara.Add("DOCHDR_sDescription", model[j].DOCHDR_sDescription, DbType.String);
                        dbPara.Add("ResampleReason", model[j].ResampleReason, DbType.String);
                        dbPara.Add("MarkComplete", model[j].MarkComplete, DbType.String);
                        dbPara.Add("User", model[j].MylabUserName, DbType.String);
                        data = _MyLabHelper.Insert<long>("[dbo].[SP_UpdateDOCHDRTestValue]",
                                      dbPara,
                                      commandType: CommandType.StoredProcedure);
                        dochdrid = model[j].DOCDET_lHeaderId;
                    }
                }

            }

            return data;
        }

        #endregion

        public List<PAIT_HDR_DET_TEST> GetPatientTestDetail(string ID)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("TestId", Convert.ToInt32(ID), DbType.Int32);

            var data = _MyLabHelper.GetAll<PAIT_HDR_DET_TEST>("[dbo].[USP_GETTESTDETAIL]", dbPara, commandType: CommandType.StoredProcedure);
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

        public List<PAIT_HDR_DET_TEST> GetAllTESTDETForPathTest(string search)
        {
            var dbPara = new DynamicParameters();
            if (search == "NoSearch")
            {
                dbPara.Add("search", "", DbType.String);

            }
            else
            {
                dbPara.Add("search", search, DbType.String);
            }
            var data = _MyLabHelper.GetAll<PAIT_HDR_DET_TEST>("[dbo].[SP_GetAllTESTDET]", dbPara, commandType: CommandType.StoredProcedure);
            for (int i = 0; i < data.Count; i++)
            {
                if (Convert.ToInt32(data[i].TESTDET_FieldType) == 1)
                {
                    List<PREDEFVALModel> PREDEFVALModel = new List<PREDEFVALModel>();
                    var PREDEFVALSTRING = GetPreDefineValue(data[i].TESTDET_CurrentId, -1, "Test Edit");
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

        public List<NarrationModel> GetNarration(string Keyword)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Keyword", Keyword, DbType.String);
            var data = _MyLabHelper.GetAll<NarrationModel>("[dbo].[SP_GetNarration]", dbPara, commandType: CommandType.StoredProcedure);
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


        public List<PAIT_HDR_DET_TEST> GetTestDetailByTestMstID(long ID)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", ID, DbType.Int32);

            var data = _MyLabHelper.GetAll<PAIT_HDR_DET_TEST>("[dbo].[SP_GetTestDetailByTestMstID]", dbPara, commandType: CommandType.StoredProcedure);
            for (int i = 0; i < data.Count; i++)
            {
                if (Convert.ToInt32(data[i].TESTDET_FieldType) == 1)
                {
                    List<PREDEFVALModel> PREDEFVALModel = new List<PREDEFVALModel>();
                    var PREDEFVALSTRING = GetPreDefineValue(data[i].TESTDET_CurrentId, -1, "Test Edit");
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



        public string GetLabNo(string LabSeriesSetting)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("LabSeriesSetting", LabSeriesSetting, DbType.String);
            var data = _MyLabHelper.Get<string>("[dbo].[USP_getLabNoByDate]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToString();
        }

        public List<PatientMasterModel> GetPatientMobileNos(string MobileNo)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("MobileNo", MobileNo, DbType.String);
            var data = _MyLabHelper.GetAll<PatientMasterModel>("[dbo].[USP_GetPatientMobileNo]", dbPara, commandType: CommandType.StoredProcedure);
            return data;
        }

        public string GlobalDelete(GlobalDeleteModal model)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Name", model.Name, DbType.String);
            dbPara.Add("ID", model.ID, DbType.String);
            var data = _MyLabHelper.Get<string>("[dbo].[USP_GlobalDelete]", dbPara, commandType: CommandType.StoredProcedure);
            return data;
        }


        public List<BlackListMobilesModel> GetBlackListMobilesSearch(SearchFilters model)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", model.PageNo, DbType.Int32);
            dbPara.Add("PageSize", model.PageSize, DbType.Int32);
            if (model.Keyword == "NoSearch")
            {
                dbPara.Add("Keyword", "", DbType.String);
            }
            else
            {
                dbPara.Add("Keyword", model.Keyword, DbType.String);
            }
            var data = _MyLabHelper.GetAll<BlackListMobilesModel>("[dbo].[SP_BlackListMobilesList]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public long GetBlackListMobilesSearchCount(SearchFilters model)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", -1, DbType.Int32);
            dbPara.Add("PageSize", 0, DbType.Int32);
            if (model.Keyword == "NoSearch")
            {
                dbPara.Add("Keyword", "", DbType.String);
            }
            else
            {
                dbPara.Add("Keyword", model.Keyword, DbType.String);
            }
            var data = _MyLabHelper.Get<CountModel>("[dbo].[SP_BlackListMobilesList]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ListCount;
        }
        public long DeleteBlackListMobiles(int ID)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", -4, DbType.Int32);
            dbPara.Add("PageSize", ID, DbType.Int32);
            dbPara.Add("Keyword", "", DbType.String);
            var data = _MyLabHelper.Get<long>("[dbo].[SP_BlackListMobilesList]", dbPara, commandType: CommandType.StoredProcedure);
            return data;
        }

        public long InsertBlackListMobiles(BlackListMobilesModel model)
        {
            long data = 0;
            var dbPara = new DynamicParameters();
            dbPara.Add("Mobile", model.Mobile, DbType.String);
            dbPara.Add("sysUserName", model.sysUserName, DbType.String);
            data = _MyLabHelper.Insert<long>("[dbo].[SP_InsertBlackListMobiles]",
                          dbPara,
                          commandType: CommandType.StoredProcedure);
            return data;
        }

    }
}