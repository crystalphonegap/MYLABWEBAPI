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
    public class PATIENTService  : IPatientService
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
            dbPara.Add("PATIENT_PaymentMode", PATIENT.PATIENT_PaymentMode, DbType.String);
            dbPara.Add("PATIENT_Telno", PATIENT.PATIENT_Telno, DbType.String);
            dbPara.Add("PATIENT_Gender", PATIENT.PATIENT_Gender, DbType.String);
            dbPara.Add("PATIENT_Age", PATIENT.PATIENT_Age, DbType.String);
            dbPara.Add("Patient_DocType", PATIENT.Patient_DocType, DbType.String);
            dbPara.Add("CollectionCenterId", PATIENT.CollectionCenterId, DbType.Int64);
            dbPara.Add("PATIENT_Date", string.IsNullOrEmpty(PATIENT.PATIENT_Date) ? null : Convert.ToDateTime(PATIENT.PATIENT_Date), DbType.DateTime);
            dbPara.Add("PATIENT_DOB", string.IsNullOrEmpty(PATIENT.PATIENT_DOB) ? null : Convert.ToDateTime(PATIENT.PATIENT_DOB) , DbType.DateTime);
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
            dbPara.Add("EmergencyCharges", string.IsNullOrEmpty(PATIENT.EmergencyCharges)? null : Convert.ToDecimal(PATIENT.EmergencyCharges)  , DbType.Decimal);
            dbPara.Add("Discount", string.IsNullOrEmpty(PATIENT.Discount) ? null : Convert.ToDecimal(PATIENT.Discount), DbType.Decimal);
            dbPara.Add("EmergencyChargesPecent", string.IsNullOrEmpty(PATIENT.EmergencyChargesPecent)? null : Convert.ToDecimal(PATIENT.EmergencyChargesPecent) , DbType.Decimal);
            dbPara.Add("Sample_Date",string.IsNullOrEmpty(PATIENT.Sample_Date) ? null : Convert.ToDateTime(PATIENT.Sample_Date) , DbType.DateTime);
            dbPara.Add("Remarks", PATIENT.Remarks, DbType.String);
            dbPara.Add("DiscountPercent", string.IsNullOrEmpty(PATIENT.DiscountPercent)? null : Convert.ToDecimal(PATIENT.DiscountPercent) , DbType.Decimal);
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
            dbPara.Add("UPI_WalletAmount", string.IsNullOrEmpty(PATIENT.UPI_WalletAmount) ? null : Convert.ToDecimal(PATIENT.UPI_WalletAmount) , DbType.Decimal);
            dbPara.Add("ChequeAmount", string.IsNullOrEmpty(PATIENT.ChequeAmount) ? null : Convert.ToDecimal(PATIENT.ChequeAmount) , DbType.Decimal);
            dbPara.Add("CreditCardAmount", string.IsNullOrEmpty(PATIENT.CreditCardAmount) ? null : Convert.ToDecimal(PATIENT.CreditCardAmount) , DbType.Decimal);
            dbPara.Add("NEFT_RTGSAmount", string.IsNullOrEmpty(PATIENT.NEFT_RTGSAmount) ? null : Convert.ToDecimal(PATIENT.NEFT_RTGSAmount), DbType.Decimal);
            dbPara.Add("CashAmount", string.IsNullOrEmpty(PATIENT.CashAmount) ? null : Convert.ToDecimal(PATIENT.CashAmount), DbType.Decimal);
            dbPara.Add("OtherRemarks",PATIENT.OtherRemarks , DbType.String);
            #region using dapper  
            var data = _MyLabHelper.Insert<int>("[dbo].[SP_PatientAdd]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;
            #endregion
        }



        public List<PatientMasterModel> GetPatientSearch(int PageNo, int PageSize, string KeyWord)
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
            var data = _MyLabHelper.GetAll<PatientMasterModel>("[dbo].[SP_PatientList]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public long GetPatientSearchCount(string KeyWord)
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
            var data = _MyLabHelper.GetAll<PatientMasterModel>("[dbo].[SP_PatientList]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList().Count;
        }
        public List<PatientMasterModel> GetPatientDetail(long ID)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PageNo", -3, DbType.Int32);
            dbPara.Add("PageSize", ID, DbType.Int32);
            dbPara.Add("Keyword", "", DbType.String);
            var data = _MyLabHelper.GetAll<PatientMasterModel>("[dbo].[SP_PatientList]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList() ;
        }


        public List<PAIT_HDR_DET_TEST> GetPatientTestDetail(long ID)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("TestId", ID, DbType.Int32);
            var data = _MyLabHelper.GetAll<PAIT_HDR_DET_TEST>("[dbo].[USP_GETTESTDETAIL]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList() ;
        }

    }
}