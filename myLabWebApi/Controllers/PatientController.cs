using Microsoft.AspNetCore.Mvc;
using myLabWebApi.Interface;
using myLabWebApi.Models;
using myLabWebApi.Security;
using System;

namespace myLabWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _IPatientService;
        private readonly ILogger _ILogger;

        public PatientController(ILogger ILoggerservice, IPatientService IPatientService)
        {
            _ILogger = ILoggerservice;
            _IPatientService = IPatientService;
        }

        [HttpPost("CreatePatient")]
        public ActionResult CreatePatient(PatientMasterModel model)
        {
            try
            {
                return Ok(_IPatientService.Create(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        [HttpPut("UpdatePatient")]
        public ActionResult UpdatePatient(PatientMasterModel model)
        {
            try
            {
                return Ok(_IPatientService.Create(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        [HttpPost("InsertDOCHDR")]
        public ActionResult InsertDOCHDR(DOCHDRModel model)
        {
            try
            {
                return Ok(_IPatientService.InsertDOCHDR(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }


        [HttpPost("InsertDOCDET")]
        public ActionResult InsertDOCDET(DOCDETModel model)
        {
            try
            {
                return Ok(_IPatientService.InsertDOCDET(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        [HttpPost("InsertPatientPayment")]
        public ActionResult InsertPatientPayment(AmountPaidModel model)
        {
            try
            {
                return Ok(_IPatientService.InsertPatientPayment(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }


        [HttpPost("InsertPatientHistory")]
        public ActionResult InsertPatientHistory(PatientHistoryModel model)
        {
            try
            {
                return Ok(_IPatientService.InsertPatientHistory(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }
    }
}