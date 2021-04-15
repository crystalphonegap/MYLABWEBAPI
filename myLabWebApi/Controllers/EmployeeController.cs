using Microsoft.AspNetCore.Mvc;
using myLabWebApi.Interface;
using myLabWebApi.Models;
using myLabWebApi.Models.New;
using System;

namespace myLabWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger _ILogger;
        private readonly IEmployeeService _IEmployeeService;

        public EmployeeController(ILogger ILoggerservice, IEmployeeService IEmployeeService)
        {
            _ILogger = ILoggerservice;
            _IEmployeeService = IEmployeeService;
        }

        [HttpPost("GetAllEmployeeDetails")]
        public IActionResult GetAllEmployeeDetails(SearchFilters m)
        {
            try
            {
                return Ok(_IEmployeeService.GetAllEmployeeDetails(m));
            }
            catch (Exception ex)
            {
                 _ILogger.Log(ex);
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
                _ILogger.Log(ex);
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

        [HttpPost("GetDoctorSearch")]
        public IActionResult GetDoctorSearch(SearchFilters m)
        {
            try
            {
                return Ok(_IEmployeeService.GetDoctorSearch(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        [HttpPost("GetDoctorSearchCount")]
        public IActionResult GetDoctorSearchCount(SearchFilters m)
        {
            try
            {
                return Ok(_IEmployeeService.GetDoctorSearchCount(m));
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

        [HttpPost("GetCollectionCenterSearch")]
        public IActionResult GetCollectionCenterSearch(SearchFilters m)
        {
            try
            {
                return Ok(_IEmployeeService.GetCollectionCenterSearch(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        [HttpPost("GetCollectionCenterSearchCount")]
        public IActionResult GetCollectionCenterSearchCount(SearchFilters m)
        {
            try
            {
                return Ok(_IEmployeeService.GetCollectionCenterSearchCount(m));
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

        [HttpPost("GetRateListSearch")]
        public IActionResult GetRateListSearch(SearchFilters m)
        {
            try
            {
                return Ok(_IEmployeeService.GetRateListSearch(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        [HttpPost("GetRateListSearchCount")]
        public IActionResult GetRateListSearchCount(SearchFilters m)
        {
            try
            {
                return Ok(_IEmployeeService.GetRateListSearchCount(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        //[HttpDelete("DeleteRateListDetailsByID/{ID}")]
        //public IActionResult DeleteRateListDetailsByID(int ID)
        //{
        //    try
        //    {
        //        return Ok(_IEmployeeService.DeleteRateListById(ID));
        //    }
        //    catch (Exception ex)
        //    {
        //        _ILogger.Log(ex);
        //        return BadRequest();
        //    }
        //}

        //Use For Test Master List
        [HttpGet("GetTestMasterForRateList/{keyword},{Type},{Catagory}")]
        public IActionResult GetTestMasterForRateList(string keyword, string Type, int Catagory)
        {
            try
            {
                return Ok(_IEmployeeService.GetTestMasterForRateList(keyword,  Type,  Catagory));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        [HttpGet("GetRateListHeaderById/{s}")]
        public IActionResult GetRateListHeaderById(int s)
        {
            try
            {
                return Ok(_IEmployeeService.GetRateListHeaderById(s));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        ////Use For Insert Rate Detail List
        //[HttpPost("InsertRateDetailList")]
        //public IActionResult InsertRateDetailList(TestMaster mastermodel)
        //{
        //    try
        //    {
        //        return Ok(_IEmployeeService.InsertRateListDetails(mastermodel));
        //    }
        //    catch (Exception ex)
        //    {
        //        _ILogger.Log(ex);
        //        return BadRequest();
        //    }
        //}

        //Use For Delete Rate Detail List
        [HttpDelete("DeleteRateListDetailsById/{ID}")]
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

        [HttpGet("GetRateListById/{ID}")]
        public IActionResult GetRateListById(int ID)
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
        [HttpDelete("DeleteEmployeeById/{ID}")]
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
        [HttpPost("GetEmployeeSearch")]
        public IActionResult GetEmployeeSearch(SearchFilters m)
        {
            try
            {
                return Ok(_IEmployeeService.GetEmployeeSearch(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        //Use For Employee Search  Count
        [HttpPost("GetEmployeeSearchCount")]
        public IActionResult GetEmployeeSearchCount(SearchFilters m)
        {
            try
            {
                return Ok(_IEmployeeService.GetEmployeeSearchCount(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

        //Use For GetTestMasterByCollectionCenterID
        [HttpGet("GetTestMasterByCollectionCenterID/{CenterID},{Type},{KeyWord}")]
        public IActionResult GetTestMasterByCollectionCenterID(int CenterID, string Type, string KeyWord)
        {
            try
            {
                return Ok(_IEmployeeService.GetTestMasterByCollectionCenterID(CenterID, Type, KeyWord));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }
    }
}