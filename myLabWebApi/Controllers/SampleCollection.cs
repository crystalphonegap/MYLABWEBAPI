using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using myLabWebApi.Interface;
using myLabWebApi.Models;
using myLabWebApi.Utility;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Http;
using System.Threading.Tasks;

namespace myLabWebApi.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class SampleCollection : Controller
    {

        private readonly ISampleCollection _SampleCollection;
        private readonly ILogger _ILogger;
        private readonly IConfiguration _config;
        private readonly IPaymentModeService _IpaymentMode;
        private readonly IMyLabHelper _MyLabHelper;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public SampleCollection(ILogger ILoggerservice, IMyLabHelper MyLabHelper, IConfiguration config, ISampleCollection ISampleCollection, IWebHostEnvironment webHostEnvironment)
        {
            _ILogger = ILoggerservice;
            _webHostEnvironment = webHostEnvironment;
            _SampleCollection = ISampleCollection;
            _MyLabHelper = MyLabHelper;
            _config = config;
           
        }

        [HttpPost("GetSamplePatientList")]
        public ActionResult GetSamplePatientList(SampleCollectionClassSearchModel model)
        {

            try
            {
                return Ok(_SampleCollection.GetSamplePatientList(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return Ok(ex.Message);
            }
        }

        [HttpGet("GetPATIENTTESTDETAILS/{ID},{Type}")]
        public ActionResult GetPATIENTTESTDETAILS(int ID,string Type)
        {

            try
            {
                return Ok(_SampleCollection.GetPATIENTTESTDETAILS(ID, Type));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return Ok(ex.Message);
            }
        }

        [HttpGet("GetTestType/{ID}")]
        public ActionResult GetTestType(int ID)
        {

            try
            {
                return Ok(_SampleCollection.GetTestType());
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return Ok(ex.Message);
            }
        }
        [HttpPost("UpdateSampleCollectionDerails")]
        public ActionResult UpdateSampleCollectionDerails(SampleCollectionInsertClass model)
        {

            try
            {
                return Ok(_SampleCollection.UpdateSampleCollectionDerails(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return Ok(ex.Message);
            }
        }
    }
}
