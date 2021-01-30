using Microsoft.AspNetCore.Mvc;
using myLabWebApi.Interface;
using myLabWebApi.Models;
using System;

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
        [HttpGet("GetAllTestTypeDetails/{PageNo},{PageSize},{KeyWord}")]
        public IActionResult GetAllTestTypeDetails(int PageNo, int PageSize, string KeyWord)
        {
            try
            {
                return Ok(_ITestService.GetTestTypeSearch(PageNo, PageSize, KeyWord));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        //Use For Test Type List Search Count
        [HttpGet("GetTestTypeSearchCount/{KeyWord}")]
        public IActionResult GetTestTypeSearchCount(string KeyWord)
        {
            try
            {
                return Ok(_ITestService.GetTestTypeSearchCount(KeyWord));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
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
                return BadRequest();
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
                return BadRequest();
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
                return BadRequest();
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
                return BadRequest();
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
                return BadRequest();
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
                return BadRequest();
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
                return BadRequest();
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
                return BadRequest();
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
                return BadRequest();
            }
        }

        //Use For PathaLogyTest List Search
        [HttpGet("GetPathaLogyTestListSearch/{PageNo},{PageSize},{KeyWord}")]
        public IActionResult GetPathaLogyTestListSearch(int PageNo, int PageSize, string KeyWord)
        {
            try
            {
                return Ok(_ITestService.GetPathalogyTestSearch(PageNo, PageSize, KeyWord));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        //Use For PathaLogyTest List Search Count
        [HttpGet("GetPathaLogyTestSearchCount/{KeyWord}")]
        public IActionResult GetPathaLogyTestSearchCount(string KeyWord)
        {
            try
            {
                return Ok(_ITestService.GetPathalogyTestSearchCount(KeyWord));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
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
                return BadRequest();
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
                return BadRequest();
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
                return BadRequest();
            }
        }
    }
}