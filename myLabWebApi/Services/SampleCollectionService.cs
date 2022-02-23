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
    public class SampleCollectionService:ISampleCollection
    {


        private readonly IConfiguration _config;
        private readonly IMyLabHelper _MyLabHelper;
        private readonly ILogger _ILogger;

        public SampleCollectionService(IMyLabHelper MyLabHelper, ILogger ILoggerservice, IConfiguration config)
        {
            _config = config;
            _ILogger = ILoggerservice;
            _MyLabHelper = MyLabHelper;
        }

        public List<SampleCollectionClass> GetSamplePatientList(SampleCollectionClassSearchModel m)
        {


            var dbPara = new DynamicParameters();
            dbPara.Add("@P_TYPE", m.TYPE, DbType.String);
            dbPara.Add("@P_KEYWORD", m.KEYWORD, DbType.String);
            
            if (m.FROMDAATE == null || m.TODATE == "null")
            {

                DateTime FDate = DateTime.ParseExact(DateTime.Now.Date.ToString("MM-dd-yyyy"), "MM-dd-yyyy", null);
                dbPara.Add("@P_FromDate", FDate, DbType.DateTime);
                dbPara.Add("@P_ToDate", FDate, DbType.DateTime);
            }
            else
            {
                dbPara.Add("@P_FromDate", DateTime.ParseExact(m.FROMDAATE, "MM-dd-yyyy", null), DbType.DateTime);
                dbPara.Add("@P_ToDate", DateTime.ParseExact(m.TODATE, "MM-dd-yyyy", null), DbType.DateTime);
            }

            var data = _MyLabHelper.GetAll<SampleCollectionClass>("[dbo].[PRC_TR_SAMPLE_PATIENTLIST]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public List<PatientTestDetailsSampleCollection> GetPATIENTTESTDETAILS(int PatientId,string Type)
        {

            var dbPara = new DynamicParameters();
            dbPara.Add("@P_PATIENTID", PatientId, DbType.Int32);
            dbPara.Add("@P_TYPE", Type, DbType.String);
            
            var data = _MyLabHelper.GetAll<PatientTestDetailsSampleCollection>("[dbo].[PRC_TR_SAMPLE_PATIENTTESTDETAILS]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }
        public List<SampleCollectionTestType> GetTestType()
        {

            var dbPara = new DynamicParameters();
            dbPara.Add("@P_ID", 0, DbType.Int32);
            var data = _MyLabHelper.GetAll<SampleCollectionTestType>("[dbo].[PRC_MS_GETTESTTYPE]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public string UpdateSampleCollectionDerails(SampleCollectionInsertClass model)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("@P_DOCHDRID", model.DOCHDRID.TrimEnd(','), DbType.String);
            dbPara.Add("@P_PatientId", model.PatientId, DbType.String);
            dbPara.Add("@P_Temprature", model.Temprature, DbType.String);
            dbPara.Add("@P_TempratureStatus", model.TempratureStatus, DbType.String);
            dbPara.Add("@P_Remarks", model.Remarks, DbType.String);
            dbPara.Add("@P_LabelSampleReceived",model.LabelSampleReceived, DbType.Boolean);
            dbPara.Add("@P_ISDone",model.ISDone, DbType.Boolean);

            var data = _MyLabHelper.Update<string>("[dbo].[PRC_TR_SAMPLECOLLECTION_IUD]", dbPara, commandType: CommandType.StoredProcedure);
            return data;

        }
    }
}
