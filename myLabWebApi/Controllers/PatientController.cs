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
                return Ok(_IPatientService.Create(model,"A"));
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
                var PATIENT_Age = model.PATIENT_Age;
                var gender = model.PATIENT_Gender;
                var flag = model.PATIENT_AgeFlag;


                return Ok(_IPatientService.Create(model,"U"));


            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                throw ex;

                return BadRequest();
            }
        }


        [HttpGet("GetPatientSearch/{PageNo},{PageSize},{KeyWord}")]
        public IActionResult GetPatientSearch(int PageNo, int PageSize, string KeyWord)
        {
            try
            {
                return Ok(_IPatientService.GetPatientSearch(PageNo, PageSize, KeyWord));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }


        [HttpGet("GetPatientDetail/{ID}")]
        public IActionResult GetPatientDetail(int ID)
        {
            try
            {
                return Ok(_IPatientService.GetPatientDetail(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        [HttpGet("GetPatientSearchCount/{KeyWord}")]
        public IActionResult GetPatientSearchCount(string KeyWord)
        {
            try
            {
                return Ok(_IPatientService.GetPatientSearchCount(KeyWord));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }


       
    }
}