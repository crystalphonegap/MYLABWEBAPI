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
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _IPatientService;
        private readonly ILogger _ILogger;
        private readonly IConfiguration _config;
        private readonly IPaymentModeService _IpaymentMode;

        private readonly IMyLabHelper _MyLabHelper;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PatientController(ILogger ILoggerservice, IMyLabHelper MyLabHelper, IConfiguration config,IPatientService IPatientService, IWebHostEnvironment webHostEnvironment, IPaymentModeService IpaymentMode)
        {
            _ILogger = ILoggerservice;
            _webHostEnvironment = webHostEnvironment;
            _IPatientService = IPatientService;
            _MyLabHelper = MyLabHelper;
            _config = config;
            _IpaymentMode = IpaymentMode;
        }

        [HttpPost("CreatePatient")]
        public async Task<ActionResult> CreatePatient([FromForm]  PatientMasterModel model)
        {
            try
            {

                if (model.FileUpload != null)
                {
                    model.SavedFileName = await FileUtilityService.UploadedSitePhotoFiles(model.FileUpload, model.PATIENT_Name, "PatientReg", null);
                }
                return Ok(_IPatientService.Create(model,"A"));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return Ok(ex.Message);
            }
        }



        [HttpGet("GetAllPaymentMode")]
        public IActionResult GetAllPaymentMode()
        {
            try
            {
                return Ok(_IpaymentMode.GetAllPaymentMode());
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        [HttpPost("InsertUpdatePaymentMode")]
        public ActionResult InsertUpdatePaymentMode(PaymentModeClass model)
        {
            
            //var filesToDelete =System.Web.HttpContext.Current.Request.Params["filesToDelete"];
            try
            {
                return Ok(_IpaymentMode.InsertUpdatePaymentMode(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return Ok(ex.Message);
            }
        }

        [HttpGet("GetAllTAPLIST")]
        public IActionResult GetAllTAPLIST()
        {
            try
            {
                return Ok(_IpaymentMode.GetAllTAPLIST());
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
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
                return BadRequest(ex);
            }
        }

        [HttpPut("UpdatePatient")]
        public async Task<ActionResult> UpdatePatientAsync([FromForm]  PatientMasterModel model)
        {
            try
            {
               
                //var files = Request.Form.Files;
                var PATIENT_Age = model.PATIENT_Age;
                var gender = model.PATIENT_Gender;
                var flag = model.PATIENT_AgeFlag;
                if (model.FileUpload != null)
                {
                    model.SavedFileName =await FileUtilityService.UploadedSitePhotoFiles(model.FileUpload, model.PATIENT_Name, "PatientReg", null);
                }
                return Ok(_IPatientService.Create(model,"U"));

            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }



        //[HttpPut("UpdateDocDetTestValue")]
        //public IActionResult UpdateDocDetTestValue( List<PAIT_HDR_DET_TEST> model)
        //{
        //    try
        //    {
        //        return Ok(_IPatientService.UpdateDocDetTestValue(model));
        //    }
        //    catch (Exception ex)
        //    {
        //        _ILogger.Log(ex);
        //        return BadRequest(ex);
        //    }
        //}

        [HttpPut("UpdateDocDetTestValue")]
        public IActionResult UpdateDocDetTestValue( PAIT_HDR_DET_TESTWITH_ID model)
        {
            try
            {
                return Ok(_IPatientService.UpdateDocDetTestValue(model.value,model.AddedBy, model.Markcomplete2));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        [HttpGet("UpdateDocDetTestValuemarkcomplete")]
        public IActionResult UpdateDocDetTestValuemarkcomplete(PAIT_HDR_DET_TESTWITH_MARKCOMPLETE2 model)
        {
            try
            {
                return Ok(_IPatientService.UpdateDocDetTestValuemarkcomplete(model.value, model.AddedBy, model.Markcomplete2));
              
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }



        [HttpPut("SaveDocument")]
        public async Task<ActionResult> SaveDocument([FromForm] DocumentClassModel model)
        {
            try
            {
                string filename = "";
                if(model.files!=null)
                {
                for(int i=0;i<model.files.Count;i++)
                {
                    filename = await FileUtilityService.UploadedSitePhotoFiles(model.files[i], "", "PatientReg", null);
                    _IPatientService.SaveDocument(model, filename);
                }
                }
                else 
                {
                  
                        _IPatientService.patientTesthistory(model);
                  
                  

                }
                return Ok();
            }
            catch (Exception ex)
            {       
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        [HttpGet("GetPatientSearch/{PageNo},{PageSize},{Keyword},{FromDate},{ToDate},{UserId}")]
        public IActionResult GetPatientSearch(int PageNo, int PageSize, string Keyword,string FromDate,string ToDate,string UserId)
        {
            try
            {
               
               return Ok(_IPatientService.GetPatientSearch(PageNo, PageSize, Keyword,FromDate,ToDate, UserId));
              
                
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
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
                return BadRequest(ex);
            }
        }

        [HttpGet("GetPatientSearchCount/{Keyword},{FromDate},{ToDate},{UserId}")]
        public IActionResult GetPatientSearchCount(string Keyword, string FromDate, string ToDate,string UserId)
        {
            try
            {
                return Ok(_IPatientService.GetPatientSearchCount(Keyword,FromDate,ToDate, UserId));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
            }
        }

        //Use for Get Patient Details By Mobile No
        [HttpGet("GetPatientByMobileNo/{MobileNo}")]
        public IActionResult GetPatientByMobileNo(string MobileNo)
        {
            try
            {
                //int rst = _IPatientService.GetPatientByMobileNoCount(MobileNo);
                //if (rst == 1)
                //{
                    List<PatientMasterModel> model = _IPatientService.GetPatientByMobileNo(MobileNo);
                    return Ok(_IPatientService.GetPatientDetail2(MobileNo));

                    //return Ok(_IPatientService.GetPatientDetail(model[0].Patient_Id));
                //}
                //else if (rst > 1)
                //{
                //    return Ok(_IPatientService.GetPatientByMobileNo(MobileNo));
                //}
                //else
                //{
                //    return Ok(null);
                //}
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
            }
        }

        //Use For Get Patient Mobile No's
        [HttpPost("GlobalDelete")]
        public IActionResult GlobalDelete(GlobalDeleteModal model)
        {
            try
            {
                return Ok(_IPatientService.GlobalDelete(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
            }
        }


        [HttpPost("GetPatientListBlanceAmount")]
        public IActionResult GetPatientListBlanceAmount(PaymentSearchFilters model)
        {
            try
            {
                return Ok(_IPatientService.GetPatientListBlanceAmount(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        [HttpGet("GetPatientListBlanceAmountByID/{ID}")]
        public ActionResult GetPatientListBlanceAmountByID(int ID)
        {
            try
            {
                return Ok(_IPatientService.GetPatientListBlanceAmountByID(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }
        [HttpPost("PaidBalanceAmount")]
        public IActionResult PaidBalanceAmount(AmountPaidClass model)
        {
            try
            {
                return Ok(_IPatientService.PaidBalanceAmount(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }
    }
}