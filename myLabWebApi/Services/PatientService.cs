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
using myLabWebApi.Models.DB;

namespace myLabWebApi.Services
{
    public class PatientService :IPatientService
    {
        private readonly IConfiguration _config;
        private readonly IMyLabHelper _MyLabHelper;
        private readonly ILogger _ILogger;


        public int Create(Patient Patient)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("AddEditFlag", Patient.UserCodetxt, DbType.String);
            dbPara.Add("LabSeriesSetting", Patient.LabSeriesSetting, DbType.String);
            dbPara.Add("Patient_Id", Patient.PatientId, DbType.String);
            dbPara.Add("PATIENT_Name", Patient.PatientName, DbType.String);
            dbPara.Add("PATIENT_Address1", Patient.PatientAddress1, DbType.String);
            dbPara.Add("PATIENT_Address2", Patient.PatientAddress2, DbType.String);
            dbPara.Add("PATIENT_City", Patient.PatientCity, DbType.String);
            dbPara.Add("PATIENT_State", Patient.PatientState, DbType.Boolean);
            dbPara.Add("PATIENT_Region", Patient.PatientRegion, DbType.String);
            dbPara.Add("PATIENT_Country", Patient.PatientCountry, DbType.String);
            dbPara.Add("PATIENT_Pincode", Patient.PatientPincode, DbType.String);
            dbPara.Add("PATIENT_Telno", Patient.PatientTelno, DbType.String);
            dbPara.Add("MobileNo", Patient.MobileNo, DbType.String);
            dbPara.Add("PATIENT_Gender", Patient.PatientGender, DbType.String);
            dbPara.Add("PATIENT_Age", Patient.PatientAge, DbType.Boolean);
            dbPara.Add("PATIENT_Date", Patient.PatientDate, DbType.String);
            dbPara.Add("PATIENT_Doctorid", Patient.PatientDoctorid, DbType.String);
            dbPara.Add("PATIENT_Companyid", Patient.PatientCompanyid, DbType.String);
            dbPara.Add("PATIENT_AmountPaid", Patient.PatientAmountPaid, DbType.String);
            dbPara.Add("PATIENT_SampleCollected", Patient.PatientSampleCollected, DbType.String);
            dbPara.Add("Doctorid2", Patient.Doctorid2, DbType.String);
            dbPara.Add("blnCommission", Patient.BlnCommission, DbType.Boolean);
            dbPara.Add("labno", Patient.Labno, DbType.String);
            dbPara.Add("WardNo", Patient.WardNo, DbType.String);
            dbPara.Add("HOSPTYPE", Patient.Hosptype, DbType.String);
            dbPara.Add("TotalAmount", Patient.TotalAmount, DbType.String);
            dbPara.Add("EmergencyCharges", Patient.EmergencyCharges, DbType.String);
            dbPara.Add("Discount", Patient.Discount, DbType.String);
            dbPara.Add("EmergencyChargesPecent", Patient.EmergencyChargesPecent, DbType.String);
            dbPara.Add("Sample_Date", Patient.SampleDate, DbType.String);
            dbPara.Add("Remarks", Patient.Remarks, DbType.Boolean);
            dbPara.Add("userid", Patient.Userid, DbType.String);
            dbPara.Add("Patientno", Patient.Patientno, DbType.String);
            dbPara.Add("DiscountPercent", Patient.DiscountPercent, DbType.String);
            dbPara.Add("test_alias", Patient.TestAlias, DbType.String);
            dbPara.Add("Bar_copiese", Patient.BarCopiese, DbType.String);
            dbPara.Add("PATIENT_PERMANENTID", Patient.PATIENTPERMANENTID, DbType.String);
            dbPara.Add("TEST", Patient.TEST, DbType.String);
            dbPara.Add("DOB", Patient.DOB, DbType.Boolean);
            dbPara.Add("PATIENT_NORMAL", Patient.PATIENTNORMAL, DbType.String);
            dbPara.Add("PATIENT_SeniorCitizen", Patient.PATIENTSeniorCitizen, DbType.String);
            dbPara.Add("PATIENT_Diabetic", Patient.PATIENTDiabetic, DbType.String);
            dbPara.Add("IsBILL", Patient.IsBILL, DbType.String);
            dbPara.Add("Urgent", Patient.Urgent, DbType.String);
            dbPara.Add("AppointmentId", Patient.AppointmentId, DbType.String);
            dbPara.Add("Result", Patient.Result, DbType.String);

            #region using dapper  
            var data = _MyLabHelper.Insert<int>("[dbo].[uspInsertUserMaster]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;
            #endregion
        }

    }
}
