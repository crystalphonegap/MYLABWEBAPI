using Microsoft.AspNetCore.Mvc;
using myLabWebApi.Interface;
using myLabWebApi.Models;
using System;
using System.Collections.Generic;

namespace myLabWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TPAController : Controller
    {

        private readonly ILogger _ILogger;
        private readonly ITPAService _ITPAService;

        public TPAController(ILogger ILoggerservice, ITPAService ITPAService)
        {
            _ILogger = ILoggerservice;
            _ITPAService = ITPAService;
        }
        public IActionResult Index()
        {
            return View();
        }

        //Use For TPA List Search
        [HttpPost("GetAllTPADetails")]
        public IActionResult GetAllTPADetails(SearchFilters m)
        {
            try
            {
                return Ok(_ITPAService.GetAllTPADetails(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //Use For Test TPA List Search Count
        [HttpPost("GetAllTPADetailsCount")]
        public IActionResult GetAllTPADetailsCount(SearchFilters m)
        {
            try
            {
                return Ok(_ITPAService.GetAllTPADetailsCount(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }


        //Use For Insert TPA List
        [HttpPost("InsertUpdateTPADetails")]
        public IActionResult InsertUpdateTPADetails(TPAClass model)
        {
            try
            {
                return Ok(_ITPAService.InsertUpdateTPADetails(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        [HttpGet("GetTPADetailsByID/{ID}")]
        public IActionResult GetTPADetailsByID(int ID)
        {
            try
            {
                return Ok(_ITPAService.GetTPADetailsByID(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        //Use For Delete TPA Details
        [HttpDelete("DeleteTPAById/{ID}")]
        public IActionResult DeleteETPAById(int ID)
        {
            try
            {
                return Ok(_ITPAService.DeleteTPAById(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

    }
}
