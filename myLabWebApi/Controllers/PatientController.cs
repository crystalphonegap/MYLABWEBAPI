using AspNetCore.Reporting;
using CrystalDecisions.CrystalReports.Engine;
using Dapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using myLabWebApi.Interface;
using myLabWebApi.Models;
using System;
using System.Collections.Generic;

namespace myLabWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _IPatientService;
        private readonly ILogger _ILogger;
        private readonly IConfiguration _config;

      

        private readonly IMyLabHelper _MyLabHelper;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PatientController(ILogger ILoggerservice, IMyLabHelper MyLabHelper, IConfiguration config,IPatientService IPatientService, IWebHostEnvironment webHostEnvironment)
        {
            _ILogger = ILoggerservice;
            _webHostEnvironment = webHostEnvironment;
            _IPatientService = IPatientService;
            _MyLabHelper = MyLabHelper;
            _config = config;
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
                return BadRequest();
            }
        }

        [HttpPut("UpdateDocDetTestValue")]
        public ActionResult UpdateDocDetTestValue(List<PAIT_HDR_DET_TEST> model)
        {
            try
            {
                return Ok(_IPatientService.UpdateDocDetTestValue(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
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


        [HttpGet("GetPatientTestDetail/{ID}")]
        public  IActionResult GetPatientTestDetail(string ID)
        {
            try
            {
                return Ok(_IPatientService.GetPatientTestDetail(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }


        [HttpGet("GetNarration/{KeyWord}")]
        public IActionResult GetNarration(string KeyWord)
        {
            try
            {
                return Ok(_IPatientService.GetNarration(KeyWord));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        [HttpGet("GetPatientAllTestDetail/{ID}")]
        public IActionResult GetPatientAllTestDetail(int ID)
        {
            try
            {
                return Ok(_IPatientService.GetPatientAllTestDetail(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }
    }
}