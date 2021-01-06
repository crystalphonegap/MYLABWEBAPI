using myLabWebApi.Interface;
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
    public class PATIENTService  
    {
        private readonly IConfiguration _config;
        private readonly IMyLabHelper _MyLabHelper;
        private readonly ILogger _ILogger;


        //public int Create(PATIENT PATIENT)
        //{
        //    var dbPara = new DynamicParameters();
        //    dbPara.Add("AddEditFlag", PATIENT.UserCodetxt, DbType.String);
        //    dbPara.Add("LabSeriesSetting", PATIENT.LabSeriesSetting, DbType.String);
        //    dbPara.Add("PATIENT_Id", PATIENT.PATIENTId, DbType.String);
        //    dbPara.Add("PATIENT_Name", PATIENT.PATIENTName, DbType.String);
        //    dbPara.Add("PATIENT_Address1", PATIENT.PATIENTAddress1, DbType.String);
        //    dbPara.Add("PATIENT_Address2", PATIENT.PATIENTAddress2, DbType.String);
        //    dbPara.Add("PATIENT_City", PATIENT.PATIENTCity, DbType.String);
        //    dbPara.Add("PATIENT_State", PATIENT.PATIENTState, DbType.Boolean);
        //    dbPara.Add("PATIENT_Region", PATIENT.PATIENTRegion, DbType.String);
        //    dbPara.Add("PATIENT_Country", PATIENT.PATIENTCountry, DbType.String);
        //    dbPara.Add("PATIENT_Pincode", PATIENT.PATIENTPincode, DbType.String);
        //    dbPara.Add("PATIENT_Telno", PATIENT.PATIENTTelno, DbType.String);
        //    dbPara.Add("MobileNo", PATIENT.MobileNo, DbType.String);
        //    dbPara.Add("PATIENT_Gender", PATIENT.PATIENTGender, DbType.String);
        //    dbPara.Add("PATIENT_Age", PATIENT.PATIENTAge, DbType.Boolean);
        //    dbPara.Add("PATIENT_Date", PATIENT.PATIENTDate, DbType.String);
        //    dbPara.Add("PATIENT_Doctorid", PATIENT.PATIENTDoctorid, DbType.String);
        //    dbPara.Add("PATIENT_Companyid", PATIENT.PATIENTCompanyid, DbType.String);
        //    dbPara.Add("PATIENT_AmountPaid", PATIENT.PATIENTAmountPaid, DbType.String);
        //    dbPara.Add("PATIENT_SampleCollected", PATIENT.PATIENTSampleCollected, DbType.String);
        //    dbPara.Add("Doctorid2", PATIENT.Doctorid2, DbType.String);
        //    dbPara.Add("blnCommission", PATIENT.BlnCommission, DbType.Boolean);
        //    dbPara.Add("labno", PATIENT.Labno, DbType.String);
        //    dbPara.Add("WardNo", PATIENT.WardNo, DbType.String);
        //    dbPara.Add("HOSPTYPE", PATIENT.Hosptype, DbType.String);
        //    dbPara.Add("TotalAmount", PATIENT.TotalAmount, DbType.String);
        //    dbPara.Add("EmergencyCharges", PATIENT.EmergencyCharges, DbType.String);
        //    dbPara.Add("Discount", PATIENT.Discount, DbType.String);
        //    dbPara.Add("EmergencyChargesPecent", PATIENT.EmergencyChargesPecent, DbType.String);
        //    dbPara.Add("Sample_Date", PATIENT.SampleDate, DbType.String);
        //    dbPara.Add("Remarks", PATIENT.Remarks, DbType.Boolean);
        //    dbPara.Add("userid", PATIENT.Userid, DbType.String);
        //    dbPara.Add("PATIENTno", PATIENT.PATIENTno, DbType.String);
        //    dbPara.Add("DiscountPercent", PATIENT.DiscountPercent, DbType.String);
        //    dbPara.Add("test_alias", PATIENT.TestAlias, DbType.String);
        //    dbPara.Add("Bar_copiese", PATIENT.BarCopiese, DbType.String);
        //    dbPara.Add("PATIENT_PERMANENTID", PATIENT.PATIENTPERMANENTID, DbType.String);
        //    dbPara.Add("TEST", PATIENT.TEST, DbType.String);
        //    dbPara.Add("DOB", PATIENT.DOB, DbType.Boolean);
        //    dbPara.Add("PATIENT_NORMAL", PATIENT.PATIENTNORMAL, DbType.String);
        //    dbPara.Add("PATIENT_SeniorCitizen", PATIENT.PATIENTSeniorCitizen, DbType.String);
        //    dbPara.Add("PATIENT_Diabetic", PATIENT.PATIENTDiabetic, DbType.String);
        //    dbPara.Add("IsBILL", PATIENT.IsBILL, DbType.String);
        //    dbPara.Add("Urgent", PATIENT.Urgent, DbType.String);
        //    dbPara.Add("AppointmentId", PATIENT.AppointmentId, DbType.String);
        //    dbPara.Add("Result", PATIENT.Result, DbType.String);

        //    #region using dapper  
        //    var data = _MyLabHelper.Insert<int>("[dbo].[uspInsertUserMaster]",
        //                    dbPara,
        //                    commandType: CommandType.StoredProcedure);
        //    return data;
        //    #endregion
        //}

    }
}
