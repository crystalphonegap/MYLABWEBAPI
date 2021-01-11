using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using myLabWebApi.Interface;
using myLabWebApi.Models;
using ExcelDataReader;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using myLabWebApi.Models.New;

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
    }
}
