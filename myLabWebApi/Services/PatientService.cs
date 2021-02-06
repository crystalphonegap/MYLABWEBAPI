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
            dbPara.Add("OtherRemarks", string.IsNullOrEmpty(PATIENT.OtherRemarks) ? null : Convert.ToDecimal(PATIENT.OtherRemarks) , DbType.String);
            #region using dapper  
            var data = _MyLabHelper.Insert<int>("[dbo].[SP_PatientAdd]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;
            #endregion
        }


        public int InsertDOCHDR(DOCHDRModel model)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("DOCHDR_lDocumentId",model.DOCHDR_lDocumentId, DbType.String);
            dbPara.Add("DOCHDR_sDocNo",model.DOCHDR_sDocNo, DbType.String);
            dbPara.Add("DOCHDR_lPatientId", model.DOCHDR_lPatientId, DbType.Int32);
            dbPara.Add("DOCHDR_lDoctorId", model.DOCHDR_lDoctorId, DbType.Int32);
            dbPara.Add("DOCHDR_sDescription", model.DOCHDR_sDescription, DbType.String);
            dbPara.Add("DOCHDR_dDate", model.DOCHDR_dDate, DbType.DateTime);
            dbPara.Add("DOCHDR_TestCatID", model.DOCHDR_TestCatID, DbType.Int32);
            dbPara.Add("DOCHDR_Sex", model.DOCHDR_Sex, DbType.String);
            dbPara.Add("DOCHDR_Age", model.DOCHDR_Age, DbType.String);
            dbPara.Add("DOCHDR_Sample", model.DOCHDR_Sample, DbType.Int32);
            dbPara.Add("DOCHDR_Rate", model.DOCHDR_Rate, DbType.Decimal);
            dbPara.Add("DOCHDR_bCommission", model.DOCHDR_bCommission, DbType.Boolean);
            dbPara.Add("DOCHDR_lEmployeeId", model.DOCHDR_lEmployeeId, DbType.Int32);
            dbPara.Add("NoOfPrintOuts", model.NoOfPrintOuts, DbType.Int32);
            dbPara.Add("MarkComplete", model.MarkComplete, DbType.String);
            dbPara.Add("Doctorid2", model.Doctorid2, DbType.Int32);
            dbPara.Add("labno", model.labno, DbType.Int32);
            dbPara.Add("WardNo", model.WardNo, DbType.String);
            dbPara.Add("HOSPTYPE", model.HOSPTYPE, DbType.String);
            dbPara.Add("Sample_Date", model.Sample_Date, DbType.DateTime);
            dbPara.Add("username", model.username, DbType.String);
            dbPara.Add("Currentdate", model.Currentdate, DbType.DateTime);
            dbPara.Add("ProfileId", model.ProfileId, DbType.Int32);
            dbPara.Add("IsProfile", model.IsProfile, DbType.String);
            dbPara.Add("DOCHDR_AgeFlag", model.DOCHDR_AgeFlag, DbType.String);
            dbPara.Add("DOCHDR_PID", model.DOCHDR_PID, DbType.String);
            dbPara.Add("issent", model.issent, DbType.Boolean);
            dbPara.Add("issampleReceived", model.issampleReceived, DbType.Boolean);
            dbPara.Add("isAllResRec", model.isAllResRec, DbType.Boolean);
            dbPara.Add("BaseRate", model.BaseRate, DbType.Decimal);
            dbPara.Add("Discount", model.Discount, DbType.Decimal);
            dbPara.Add("RegistationDate", model.RegistationDate, DbType.DateTime);
            dbPara.Add("RegistationUser", model.RegistationUser, DbType.String);
            dbPara.Add("SampleReceivedDate", model.SampleReceivedDate, DbType.DateTime);
            dbPara.Add("SampleReceivedUser", model.SampleReceivedUser, DbType.String);
            dbPara.Add("DataEntryDate", model.DataEntryDate, DbType.DateTime);
            dbPara.Add("DataEntryUser", model.DataEntryUser, DbType.String);
            dbPara.Add("ValidateDate", model.ValidateDate, DbType.DateTime);
            dbPara.Add("ValidateUser", model.ValidateUser, DbType.String);
            dbPara.Add("ResampleDate", model.ResampleDate, DbType.DateTime);
            dbPara.Add("ResampleUser", model.ResampleUser, DbType.String);
            dbPara.Add("RerunDate", model.RerunDate, DbType.DateTime);
            dbPara.Add("RerunUser", model.RerunUser, DbType.String);
            dbPara.Add("AuntheticateDate", model.AuntheticateDate, DbType.DateTime);
            dbPara.Add("AuthenticateUser", model.AuthenticateUser, DbType.String);
            dbPara.Add("PrintDate", model.PrintDate, DbType.DateTime);
            dbPara.Add("PrintUser", model.PrintUser, DbType.String);
            dbPara.Add("PDFDate", model.PDFDate, DbType.DateTime);
            dbPara.Add("PDFUser", model.PDFUser, DbType.String);
            dbPara.Add("EmailDate", model.EmailDate, DbType.DateTime);
            dbPara.Add("EmailUser", model.EmailUser, DbType.String);
            dbPara.Add("SampleReceivedRemark ", model.SampleReceivedRemark, DbType.String);
            dbPara.Add("Lable_Sample", model.Lable_Sample, DbType.String);
            dbPara.Add("RequestDate", model.RequestDate, DbType.DateTime);
            dbPara.Add("RequestUser", model.RequestUser, DbType.String);
            dbPara.Add("IntegrationDate", model.IntegrationDate, DbType.DateTime);
            #region using dapper  
            var data = _MyLabHelper.Insert<int>("[dbo].[SP_InsertDOCHDR]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;
            #endregion
        }

        public int InsertDOCDET(DOCDETModel model)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("DOCDET_lHeaderId", model.DOCDET_lHeaderId, DbType.Int32);
            dbPara.Add("DOCDET_lFieldNo", model.DOCDET_lFieldNo, DbType.Int32);
            dbPara.Add("DOCDET_tFieldValue", model.DOCDET_tFieldValue, DbType.String);
            dbPara.Add("DOCDET_lTestCatId", model.DOCDET_lTestCatId, DbType.Int32);
            dbPara.Add("DOCDET_tFieldValue1", model.DOCDET_tFieldValue1, DbType.String);
            dbPara.Add("isResRec", model.isResRec, DbType.Boolean);
            dbPara.Add("Rerun", model.Rerun, DbType.Boolean);
            dbPara.Add("NormalValue", model.NormalValue, DbType.String);
            dbPara.Add("sUnit", model.sUnit, DbType.String);
            dbPara.Add("MinValue", model.MinValue, DbType.Decimal);
            dbPara.Add("MaxValue", model.MaxValue, DbType.Decimal);
            dbPara.Add("MinLimit", model.MinLimit, DbType.Decimal);
            dbPara.Add("MaxLimit", model.MaxLimit, DbType.Decimal);
            dbPara.Add("Low_High", model.Low_High, DbType.String);
            dbPara.Add("ValueForNormal", model.ValueForNormal, DbType.String);
            #region using dapper  
            var data = _MyLabHelper.Insert<int>("[dbo].[SP_InsertDOCDET]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;
            #endregion
        }


        public int InsertPatientPayment(AmountPaidModel model)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Patientid", model.Patientid, DbType.Int32);
            dbPara.Add("PayDate", model.PayDate, DbType.DateTime);
            dbPara.Add("AmountPaid", model.AmountPaid, DbType.Int32);
            dbPara.Add("userid", model.userid, DbType.String);
            dbPara.Add("CurrentDate", model.CurrentDate, DbType.Date);
            dbPara.Add("Remark", model.Remark, DbType.String);
            dbPara.Add("Paymode", model.Paymode, DbType.String);
            #region using dapper  
            var data = _MyLabHelper.Insert<int>("[dbo].[SP_InsertPatientPaymentDetails]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;
            #endregion
        }

        public int InsertPatientHistory(PatientHistoryModel model)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("PATIENT_id", model.PATIENT_id, DbType.Int32);
            dbPara.Add("Patientno", model.Patientno, DbType.Int32);
            dbPara.Add("PATIENT_Name", model.PATIENT_Name, DbType.String);
            dbPara.Add("PATIENT_Address1", model.PATIENT_Address1, DbType.String);
            dbPara.Add("PATIENT_Address2", model.PATIENT_Address2, DbType.String);
            dbPara.Add("PATIENT_SendSms", model.PATIENT_SendSms, DbType.String);
            dbPara.Add("PATIENT_VisitTime", model.PATIENT_VisitTime, DbType.String);
            dbPara.Add("PATIENT_Email", model.PATIENT_Email, DbType.String);
            dbPara.Add("PATIENT_Country", model.PATIENT_Country, DbType.String);
            dbPara.Add("PATIENT_PaymentMode", model.PATIENT_PaymentMode, DbType.String);
            dbPara.Add("PATIENT_Telno", model.PATIENT_Telno, DbType.String);
            dbPara.Add("PATIENT_Gender", model.PATIENT_Gender, DbType.String);
            dbPara.Add("PATIENT_Age", model.PATIENT_Age, DbType.String);
            dbPara.Add("PATIENT_Date", model.PATIENT_Date, DbType.DateTime);
            dbPara.Add("PATIENT_Doctorid", model.PATIENT_Doctorid, DbType.Int32);
            dbPara.Add("PATIENT_Companyid", model.PATIENT_Companyid, DbType.Int32);
            dbPara.Add("PATIENT_AmountPaid", model.PATIENT_AmountPaid, DbType.Decimal);
            dbPara.Add("PATIENT_SampleCollected", model.PATIENT_SampleCollected, DbType.Int32);
            dbPara.Add("Doctorid2", model.Doctorid2, DbType.Int32);
            dbPara.Add("blnCommission", model.blnCommission, DbType.Boolean);
            dbPara.Add("labno", model.labno, DbType.Int32);
            dbPara.Add("WardNo", model.WardNo, DbType.String);
            dbPara.Add("HOSPTYPE", model.HOSPTYPE, DbType.String);
            dbPara.Add("TotalAmount", model.TotalAmount, DbType.Decimal);
            dbPara.Add("EmergencyCharges", model.EmergencyCharges, DbType.Decimal);
            dbPara.Add("Discount", model.Discount, DbType.Decimal);
            dbPara.Add("EmergencyChargesPecent", model.EmergencyChargesPecent, DbType.Decimal);
            dbPara.Add("Sample_Date", model.Sample_Date, DbType.DateTime);
            dbPara.Add("Remarks", model.Remarks, DbType.String);
            dbPara.Add("DiscountPercent", model.DiscountPercent, DbType.Decimal);
            dbPara.Add("PATIENT_AgeFlag", model.PATIENT_AgeFlag, DbType.String);
            dbPara.Add("CreatedDate", model.CreatedDate, DbType.DateTime);
            dbPara.Add("username", model.username, DbType.String);
            dbPara.Add("TEST_ALIAS", model.TEST_ALIAS, DbType.String);
            dbPara.Add("Bar_Copiese", model.Bar_Copiese, DbType.Int32);
            dbPara.Add("Urgent", model.Urgent, DbType.Int32);
            dbPara.Add("History_Date", model.History_Date, DbType.DateTime);
            #region using dapper  
            var data = _MyLabHelper.Insert<int>("[dbo].[SP_InsertPatientHistory]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;
            #endregion
        }
    }
}