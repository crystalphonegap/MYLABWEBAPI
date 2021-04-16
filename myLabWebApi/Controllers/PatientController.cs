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
                return Ok(ex.Message);
            }
        }


        [HttpGet("GetAllTESTDETForPathTest/{search}")]
        public IActionResult GetAllTESTDETForPathTest(string search)
        {
            try
            {
                return Ok(_IPatientService.GetAllTESTDETForPathTest(search));
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


        [HttpGet("GetPatientSearch/{PageNo},{PageSize},{Keyword}")]
        public IActionResult GetPatientSearch(int PageNo, int PageSize, string Keyword)
        {
            try
            {
                return Ok(_IPatientService.GetPatientSearch(PageNo, PageSize, Keyword));
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

        [HttpGet("GetPatientSearchCount/{Keyword}")]
        public IActionResult GetPatientSearchCount(string Keyword)
        {
            try
            {
                return Ok(_IPatientService.GetPatientSearchCount(Keyword));
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


        [HttpGet("GetNarration/{Keyword}")]
        public IActionResult GetNarration(string Keyword)
        {
            try
            {
                return Ok(_IPatientService.GetNarration(Keyword));
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



        [HttpGet("GetTestDetailByTestMstID/{ID}")]
        public IActionResult GetTestDetailByTestMstID(int ID)
        {
            try
            {
                return Ok(_IPatientService.GetTestDetailByTestMstID(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        //Use for Get Patient Details By Mobile No
        [HttpGet("GetPatientByMobileNo/{MobileNo}")]
        public IActionResult GetPatientByMobileNo(string MobileNo)
        {
            try
            {
                int rst = _IPatientService.GetPatientByMobileNoCount(MobileNo);
                if (rst == 1)
                {
                    List<PatientMasterModel> model = _IPatientService.GetPatientByMobileNo(MobileNo);
                    return Ok(_IPatientService.GetPatientDetail(model[0].Patient_Id));
                }
                else if (rst > 1)
                {
                    return Ok(_IPatientService.GetPatientByMobileNo(MobileNo));
                }
                else
                {
                    return Ok(null);
                }
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        //Use For Get Default Lab No
        [HttpGet("GetLabNo/{LabSeriesSetting}")]
        public IActionResult GetLabNo(string LabSeriesSetting)
        {
            try
            {
               return Ok(_IPatientService.GetLabNo(LabSeriesSetting));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        //Use For Get Patient Mobile No's
        [HttpGet("GetPatientMobileNos/{MobileNo}")]
        public IActionResult GetPatientMobileNos(string MobileNo)
        {
            try
            {
                return Ok(_IPatientService.GetPatientMobileNos(MobileNo));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }


        [HttpPost("GetBlackListMobilesSearch")]
        public ActionResult GetBlackListMobilesSearch(SearchFilters model)
        {
            try
            {
                return Ok(_IPatientService.GetBlackListMobilesSearch( model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }


        [HttpPost("GetBlackListMobilesSearchCount")]
        public ActionResult GetBlackListMobilesSearchCount(SearchFilters model)
        {
            try
            {
                return Ok(_IPatientService.GetBlackListMobilesSearchCount(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }
        [HttpGet("DeleteBlackListMobiles/{ID}")]
        public ActionResult DeleteBlackListMobiles(int ID)
        {
            try
            {
                return Ok(_IPatientService.DeleteBlackListMobiles(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }
        [HttpPost("InsertBlackListMobiles")]
        public ActionResult InsertBlackListMobiles(BlackListMobilesModel model)
        {
            try
            {
                return Ok(_IPatientService.InsertBlackListMobiles(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }
    }
}