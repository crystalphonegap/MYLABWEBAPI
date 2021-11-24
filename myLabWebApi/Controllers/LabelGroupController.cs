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
    }
}
