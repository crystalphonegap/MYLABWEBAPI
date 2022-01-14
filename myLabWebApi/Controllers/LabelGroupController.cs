using Microsoft.AspNetCore.Mvc;
using myLabWebApi.Interface;
using myLabWebApi.Models;
using myLabWebApi.Models.New;
using System;

namespace myLabWebApi.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class LabelGroupController : Controller
    {
        private readonly ILogger _ILogger;
        private readonly ILabelGroupService _ILabelGroupService;

        public LabelGroupController(ILogger ILoggerservice, ILabelGroupService ILabelGroupService)
        {
            _ILogger = ILoggerservice;
            _ILabelGroupService = ILabelGroupService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("InsertUpdateLabelGroupMaster")]
        public IActionResult InsertUpdateLabelGroupMaster(LabelGroupMaster LabelGroupMaster)
        {
            try
            {
                return Ok(_ILabelGroupService.InsertUpdateLabelGroupMaster(LabelGroupMaster));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        [HttpGet("GetTestList")]
        public IActionResult GetTestList()
        {
            try
            {
                return Ok(_ILabelGroupService.GetTestList());
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }


        [HttpGet("GetLabelGroupDetailsById/{ID}")]
        public IActionResult GetLabelGroupDetailsById(int ID)
        {
            try
            {
                return Ok(_ILabelGroupService.GetLabelGroupDetailsById(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        [HttpPost("GetLabelGroupList")]
        public IActionResult GetTestList(SearchByKeywordType m)
        {
            try
            {
                return Ok(_ILabelGroupService.GetLabelGroupList(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }


    }
}
