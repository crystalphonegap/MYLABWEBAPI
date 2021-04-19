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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
        //        return BadRequest(ex);
        //    }
        //}

        //Use For Test Master List
        [HttpGet("GetTestMasterForRateList/{Keyword},{Type},{Catagory}")]
        public IActionResult GetTestMasterForRateList(string Keyword, string Type, int Catagory)
        {
            try
            {
                return Ok(_IEmployeeService.GetTestMasterForRateList(Keyword,  Type,  Catagory));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
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
                return BadRequest(ex);
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
        //        return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
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
                return BadRequest(ex);
            }
        }

        //Use For GetTestMasterByCollectionCenterID
        [HttpGet("GetTestMasterByCollectionCenterID/{CenterID},{Type},{Keyword}")]
        public IActionResult GetTestMasterByCollectionCenterID(int CenterID, string Type, string Keyword)
        {
            try
            {
                return Ok(_IEmployeeService.GetTestMasterByCollectionCenterID(CenterID, Type, Keyword));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }
    }
}