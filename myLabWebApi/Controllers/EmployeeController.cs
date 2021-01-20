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
        public IActionResult InsertCollectionCenter(COLLECTIONCENTER centermodel)
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
        public IActionResult UpdateCollectionCenter(COLLECTIONCENTER centermodel)
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


        [HttpGet("DeleteCollectionCenterDetailsByID/{ID}")]
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




        [HttpPost("InsertRateList")]
        public IActionResult InsertRateList(RATELISTHDR centermodel)
        {
            try
            {
                return Ok(_IEmployeeService.insertUpdateRateList(centermodel));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        [HttpPut("UpdateRateList")]
        public IActionResult UpdateRateList(RATELISTHDR centermodel)
        {
            try
            {
                return Ok(_IEmployeeService.insertUpdateRateList(centermodel));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }



        [HttpGet("GetRateListSearch/{PageNo},{PageSize},{KeyWord}")]
        public IActionResult GetRateListSearch(int PageNo, int PageSize, string KeyWord)
        {
            try
            {
                return Ok(_IEmployeeService.GetRateListSearch(PageNo, PageSize, KeyWord));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        [HttpGet("GetRateListSearchCount/{KeyWord}")]
        public IActionResult GetRateListSearchCount(string KeyWord)
        {
            try
            {
                return Ok(_IEmployeeService.GetRateListSearchCount(KeyWord));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        [HttpGet("GetRateListDetailsByID/{ID}")]
        public IActionResult GetRateListDetailsByID(int ID)
        {
            try
            {
                return Ok(_IEmployeeService.GetRateListById(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }


        [HttpGet("DeleteRateListDetailsByID/{ID}")]
        public IActionResult DeleteRateListDetailsByID(int ID)
        {
            try
            {
                return Ok(_IEmployeeService.DeleteRateListById(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }


        //Use For Test Master List
        [HttpGet("GetTestMasterForRateList")]
        public IActionResult GetTestMasterForRateList()
        {
            try
            {
                return Ok(_IEmployeeService.GetTestMasterForRateList());
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }


        //Use For Insert Rate Detail List
        [HttpPost("InsertRateDetailList")]
        public IActionResult InsertRateDetailList(TestMaster mastermodel)
        {
            try
            {
                return Ok(_IEmployeeService.InsertRateListDetails(mastermodel));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        //Use For Delete Rate Detail List
        [HttpGet("DeleteRateListDetailsById/{ID}")]
        public IActionResult DeleteRateListDetailsById(int ID)
        {
            try
            {
                return Ok(_IEmployeeService.DeleteRateListDetailsById(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        //Use For Get Rate List Detail By ID
        [HttpGet("GetRateListDetailsById/{ID}")]
        public IActionResult GetRateListDetailsById(int ID)
        {
            try
            {
                return Ok(_IEmployeeService.GetRateListDetailsById(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }



        //Use For Insert Employee
        [HttpPost("InsertEmployee")]
        public IActionResult InsertEmployee(EMPLOYEE empmodel)
        {
            try
            {
                return Ok(_IEmployeeService.InsertUpdateEmployee(empmodel));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        //Use For Update Employee
        [HttpPut("UpdateEmployee")]
        public IActionResult UpdateEmployee(EMPLOYEE empmodel)
            {
            try
            {
                return Ok(_IEmployeeService.InsertUpdateEmployee(empmodel));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        //Use For Delete Employee List
        [HttpGet("DeleteEmployeeById/{ID}")]
        public IActionResult DeleteEmployeeById(int ID)
        {
            try
            {
                return Ok(_IEmployeeService.DeleteEmployeeById(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        //Use For Get Employee By ID
        [HttpGet("GetEmployeeById/{ID}")]
        public IActionResult GetEmployeeById(int ID)
        {
            try
            {
                return Ok(_IEmployeeService.GetEmployeeListByID(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }


        //Use For Employee Search
        [HttpGet("GetEmployeeSearch/{PageNo},{PageSize},{KeyWord}")]
        public IActionResult GetEmployeeSearch(int PageNo, int PageSize, string KeyWord)
        {
            try
            {
                return Ok(_IEmployeeService.GetEmployeeSearch(PageNo, PageSize, KeyWord));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }


        //Use For Employee Search  Count
        [HttpGet("GetEmployeeSearchCount/{KeyWord}")]
        public IActionResult GetEmployeeSearchCount(string KeyWord)
        {
            try
            {
                return Ok(_IEmployeeService.GetEmployeeSearchCount(KeyWord));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }
    }
}
