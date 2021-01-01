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
using myLabWebApi.Models.DB;

namespace myLabWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private readonly ILogger _ILogger;
        private readonly IMaster _IMasterServices;

        public MasterController(ILogger ILoggerservice, IMaster IMasterServices)
        {
            _ILogger = ILoggerservice;
            _IMasterServices = IMasterServices;
        }

        [HttpGet("GetAllCollectionCenterDetails")]
        public IActionResult GetAllCollectionCenterDetails()
        {
            try
            {
                return Ok(_IMasterServices.GetAllCollectionCenterDetails());
            }
            catch (Exception ex)
            {
                //_ILogger.Log(ex);
                return BadRequest();
            }
        }
    }
}
