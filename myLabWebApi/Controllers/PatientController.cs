using Microsoft.AspNetCore.Mvc;
using myLabWebApi.Interface;
using myLabWebApi.Security;

namespace myLabWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _IPatientService;
        private readonly ILogger _ILogger;

        public PatientController(ILogger ILoggerservice, IPatientService IPatientService)
        {
            _ILogger = ILoggerservice;
            _IPatientService = IPatientService;
        }

        [HttpPost("Create")]
        public ActionResult Create(PatientMasterModel model)
        {
            try
            {
                return Ok(_IPatientService.Create(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }
        }

    }
}