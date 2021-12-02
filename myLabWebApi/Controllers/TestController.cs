using Microsoft.AspNetCore.Mvc;
using myLabWebApi.Interface;
using myLabWebApi.Models;
using System;
using System.Collections.Generic;

namespace myLabWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ILogger _ILogger;
        private readonly ITestService _ITestService;

        public TestController(ILogger ILoggerservice, ITestService ITestService)
        {
            _ILogger = ILoggerservice;
            _ITestService = ITestService;
        }

        //Use For Test Type List Search
        [HttpGet("GetPTestResult/{ID}")]
        public IActionResult GetPTestResult(long ID)
        {
            try
            {
                return Ok(_ITestService.GetPTestResult(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }


        //Use For Test Type List Search
        [HttpPost("GetAllTestTypeDetails")]
        public IActionResult GetAllTestTypeDetails(SearchFilters m)
        {
            try
            {
                return Ok(_ITestService.GetTestTypeSearch(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }
         

        //Use For Test Type List Search Count
        [HttpPost("GetTestTypeSearchCount")]
        public IActionResult GetTestTypeSearchCount(SearchFilters m)
        {
            try
            {
                return Ok(_ITestService.GetTestTypeSearchCount(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //Use For Insert Test Type List
        [HttpPost("InsertTestType")]
        public IActionResult InsertTestType(TestTypeModel model)
        {
            try
            {
                return Ok(_ITestService.InsertUpdateTestType(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //Use For Update Test Type List
        [HttpPut("UpdateTestType")]
        public IActionResult UpdateTestType(TestTypeModel model)
        {
            try
            {
                return Ok(_ITestService.InsertUpdateTestType(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //Use For Get TestType By Id
        [HttpGet("GetTestTypeByID/{ID}")]
        public IActionResult GetTestTypeByID(int ID)
        {
            try
            {
                return Ok(_ITestService.GetTestTypeUsingId(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //Use For Delete  TestType By Id
        [HttpDelete("DeleteTestTypeByID/{ID}")]
        public IActionResult DeleteTestTypeByID(int ID)
        {
            try
            {
                return Ok(_ITestService.DeleteTestTypeById(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }


        [HttpPost("InsertRemarkMaster")]
        public IActionResult InsertRemarkMaster(List<TestDetModel> model,string ID)
        {
            try
            {
                return Ok(_ITestService.InsertRemarkMaster(model, ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //Use For Insert PathaLogy Test
        [HttpPost("InsertPathaLogyTest")]
        public IActionResult InsertPathaLogyTest(PathalogyTestMaster model)
        {
            try
            {
                return Ok(_ITestService.InsertUpdatePathalogyTest(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //Use For Update  PathaLogy Test
        [HttpPut("UpdatePathaLogyTest")]
        public IActionResult UpdatePathaLogyTest(PathalogyTestMaster model)
        {
            try
            {
                return Ok(_ITestService.InsertUpdatePathalogyTest(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }





        //Use For Insert xRAY,HISTO,Sono Test
        [HttpPost("InsertTest")]
        public IActionResult InsertTest(PathalogyTestMaster model)
        {
            try
            {
                return Ok(_ITestService.InsertUpdateTest(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //Use For Update  PathaLogy Test
        [HttpPut("UpdateTest")]
        public IActionResult UpdateTest(PathalogyTestMaster model)
        {
            try
            {
                return Ok(_ITestService.InsertUpdateTest(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }



        //Use For Insert xRAY,HISTO,Sono Test
        [HttpPost("InsertProfileTest")]
        public IActionResult InsertProfileTest(ProfileTestModel model)
        {
            try
            {
                return Ok(_ITestService.InsertUpdateProfileTest(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //Use For Update  PathaLogy Test
        [HttpPut("UpdateProfileTest")]
        public IActionResult UpdateProfileTest(ProfileTestModel model)
        {
            try
            {
                return Ok(_ITestService.InsertUpdateProfileTest(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }


        //Use For Delete PathaLogyTest
        [HttpGet("DeletePathaLogyTest/{ID}")]
        public IActionResult DeletePathaLogyTest(int ID)
        {
            try
            {
                return Ok(_ITestService.DeletePathalogyTestMaster(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //Use For Get PathaLogyTest MasterByID
        [HttpGet("GetPathaLogyTestMasterByID/{ID}")]
        public IActionResult GetPathaLogyTestMasterByID(int ID)
        {
            try
            {
                return Ok(_ITestService.GetPathalogyTestMasterUsingId(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //Use For Get PathaLogyTest DetailsByID
        [HttpGet("GetPathaLogyTestdetailsByID/{ID}")]
        public IActionResult GetPathaLogyTestdetailsByID(int ID)
        {
            try
            {
                return Ok(_ITestService.GetPathalogyTestDetailsUsingId(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //Use For PathaLogyTest List Search
        [HttpPost("GetPathalogyTestSearch")]
        public IActionResult GetPathalogyTestSearch(SearchByKeywordPageNoPageSizeType m)
        {
            try
            {
                return Ok(_ITestService.GetPathalogyTestSearch(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //Use For PathaLogyTest List Search Count
        [HttpPost("GetPathalogyTestSearchCount")]
        public IActionResult GetPathalogyTestSearchCount(SearchByKeywordType m)
        {
            try
            {
                return Ok(_ITestService.GetPathalogyTestSearchCount(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //Use For Insert Test  Format Details
        [HttpPost("InsertTestFormatDetails")]
        public IActionResult InsertTestFormatDetails(TestFormatDetails model)
        {
            try
            {
                return Ok(_ITestService.InsertTestFormatDetails(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //Use For Delete Test  Format Details
        [HttpGet("DeleteTestFormatDetails/{ID}")]
        public IActionResult DeleteTestFormatDetails(int ID)
        {
            try
            {
                return Ok(_ITestService.DeleteTestFormat(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //Use For Get PathaLogyTest MasterByID
        [HttpGet("GetTestFormatDetails/{ID}")]
        public IActionResult GetTestFormatDetails(int ID)
        {
            try
            {
                return Ok(_ITestService.GetTestFormatDetailList(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }




        //Use For Insert Test Type List
        [HttpPost("InsertNarration")]
        public IActionResult InsertNarration(NarrationModel model)
        {
            try
            {
                return Ok(_ITestService.InsertUpdateNarration(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //Use For Update Test Type List
        [HttpPut("UpdateNarration")]
        public IActionResult UpdateNarration(NarrationModel model)
        {
            try
            {
                return Ok(_ITestService.InsertUpdateNarration(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }


        //Use For Narration List Search
        [HttpPost("GetNarrationSearch")]
        public IActionResult GetNarrationSearch(SearchFilters m)
        {
            try
            {
                return Ok(_ITestService.GetNarrationSearch(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //Use For Narration List Search Count
        [HttpPost("GetNarrationSearchCount")]
        public IActionResult GetNarrationSearchCount(SearchFilters m)
        {
            try
            {
                return Ok(_ITestService.GetNarrationSearchCount(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }




        //Use For Insert Test Type List
        [HttpPost("InsertReSampleReason")]
        public IActionResult InsertReSampleReason(NarrationModel model)
        {
            try
            {
                return Ok(_ITestService.InsertUpdateReSampleReason(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //Use For Update Test Type List
        [HttpPut("UpdateReSampleReason")]
        public IActionResult UpdateReSampleReason(NarrationModel model)
        {
            try
            {
                return Ok(_ITestService.InsertUpdateReSampleReason(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }


        //Use For ReSampleReason List Search
        [HttpPost("GetReSampleReasonListSearch")]
        public IActionResult GetReSampleReasonListSearch(SearchFilters m)
        {
            try
            {
                return Ok(_ITestService.GetReSampleReasonSearch(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //Use For ReSampleReason List Search Count
        [HttpPost("GetReSampleReasonSearchCount")]
        public IActionResult GetReSampleReasonSearchCount(SearchFilters m)
        {
            try
            {
                return Ok(_ITestService.GetReSampleReasonSearchCount(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        #region "Added by Suman"

        [HttpGet("GetAllTestDetailsbyPatientID/{ID}")]
        public IActionResult GetAllTestDetailsbyPatientID(int ID)
        {
            try
            {

                return Ok(_ITestService.GetAllTestDetailsbyPatientID(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        [HttpGet("GetPatientListforDataEntry/{Keyword},{FromDate},{ToDate}")]
        public IActionResult GetPatientListforDataEntry(string Keyword, string FromDate, string ToDate)
        {
            try
            {
                return Ok(_ITestService.GetPatientListforDataEntry(Keyword, FromDate, ToDate));
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
                return Ok(_ITestService.GetPatientAllTestDetail(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }
        #endregion
    }
}