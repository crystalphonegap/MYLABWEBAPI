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

        [HttpPost("InsertDoctor")]
        public IActionResult InsertDoctor(DoctorModel doctormodels)
        {
            try
            {
                return Ok(_IEmployeeService.InsertUpdateDoctor(doctormodels));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        [HttpPut("UpdateDoctor")]
        public IActionResult UpdateDoctor(DoctorModel doctormodels)
        {
            try
            {
                return Ok(_IEmployeeService.InsertUpdateDoctor(doctormodels));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }


        [HttpGet("GetDoctorSearch/{PageNo},{PageSize},{KeyWord}")]
        public IActionResult GetDoctorSearch(int PageNo, int PageSize, string KeyWord)
        {
            try
            {
                return Ok(_IEmployeeService.GetDoctorSearch(PageNo,PageSize, KeyWord));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        [HttpGet("GetDoctorSearchCount/{KeyWord}")]
        public IActionResult GetDoctorSearchCount(string KeyWord)
        {
            try
            {
                return Ok(_IEmployeeService.GetDoctorSearchCount(KeyWord));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

    }
}
