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

namespace myLabWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger _ILogger;
        private readonly IEmployeeService _IEmployeeService;

        public EmployeeController( ILogger ILoggerservice,IEmployeeService IEmployeeService)
        {
            _ILogger = ILoggerservice;
            _IEmployeeService = IEmployeeService;
        }

        [HttpGet("GetAllEmployeeDetails")]
        public IActionResult GetAllEmployeeDetails()
        {
            try
            {
                return Ok(_IEmployeeService.GetAllEmployeeDetails());
            }
            catch (Exception ex)
            {
                //_ILogger.Log(ex);
                return BadRequest();
            }
        }

        [HttpGet("GetAllDoctorDetails")]
        public IActionResult GetAllDoctorDetails()
        {
            try
            {
                return Ok(_IEmployeeService.GetAllDoctorDetails());
            }
            catch (Exception ex)
            {
                //_ILogger.Log(ex);
                return BadRequest();
            }
        }
    }
}
