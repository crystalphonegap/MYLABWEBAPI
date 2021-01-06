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
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger _ILogger;
        private readonly IEmployeeService _IEmployeeService;

        public EmployeeController( ILogger ILoggerservice,IEmployeeService IEmployeeService)
        {
            _ILogger = ILoggerservice;
            _IEmployeeService = IEmployeeService;
        }

        [HttpGet("GetAllEmployeeDetails/{PageNo},{PageSize},{KeyWord}")]
        public IActionResult GetAllEmployeeDetails(int PageNo, int PageSize, string KeyWord)
        {
            try
            {
                return Ok(_IEmployeeService.GetAllEmployeeDetails(PageNo, PageSize, KeyWord));
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
        public IActionResult InsertDoctor(DOCTOR DOCTORs)
        {
            try
            {
                return Ok(_IEmployeeService.InsertUpdateDoctor(DOCTORs));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        [HttpPut("UpdateDoctor")]
        public IActionResult UpdateDoctor(DOCTOR DOCTORs)
        {
            try
            {
                return Ok(_IEmployeeService.InsertUpdateDoctor(DOCTORs));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }


        [HttpGet("GetDoctorDetailsByID/{ID}")]
        public IActionResult GetDoctorDetailsByID(int ID)
        {
            try
            {
                return Ok(_IEmployeeService.GetDoctorUsingId(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }


        [HttpDelete("DeleteDoctorDetailsByID/{ID}")]
        public IActionResult DeleteDoctorDetailsByID(int ID)
        {
            try
            {
                return Ok(_IEmployeeService.DeleteDoctorById(ID));
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


        [HttpPost("InsertCollectionCenter")]
        public IActionResult InsertCollectionCenter(CollectionCenterModel centermodel)
        {
            try
            {
                return Ok(_IEmployeeService.insertUpdollectionCenter(centermodel));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        [HttpPut("UpdateCollectionCenter")]
        public IActionResult UpdateCollectionCenter(CollectionCenterModel centermodel)
        {
            try
            {
                return Ok(_IEmployeeService.insertUpdollectionCenter(centermodel));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }



        [HttpGet("GetCollectionCenterSearch/{PageNo},{PageSize},{KeyWord}")]
        public IActionResult GetCollectionCenterSearch(int PageNo, int PageSize, string KeyWord)
        {
            try
            {
                return Ok(_IEmployeeService.GetCollectionCenterSearch(PageNo, PageSize, KeyWord));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        [HttpGet("GetCollectionCenterSearchCount/{KeyWord}")]
        public IActionResult GetCollectionCenterSearchCount(string KeyWord)
        {
            try
            {
                return Ok(_IEmployeeService.GetCollectionCenterSearchCount(KeyWord));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        [HttpGet("GetCollectionCenterDetailsByID/{ID}")]
        public IActionResult GetCollectionCenterDetailsByID(int ID)
        {
            try
            {
                return Ok(_IEmployeeService.GetCollectionCenterById(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }


        [HttpPost("DeleteCollectionCenterDetailsByID/{ID}")]
        public IActionResult DeleteCollectionCenterDetailsByID(int ID)
        {
            try
            {
                return Ok(_IEmployeeService.DeleteCollectionCenterById(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }
    }
}
