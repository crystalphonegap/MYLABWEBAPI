using myLabWebApi.Interface;
using myLabWebApi.Security;
using Microsoft.AspNetCore.Mvc;
using myLabWebApi.Models;

namespace myLabWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _IPatientService;
        private readonly IChecktokenservice _Checktokenservice;
        private readonly JwtSettings _jwtSettings;
        private readonly ILogger _ILogger;
        static bool AngularEncryption = true;



        [HttpPost("Create")]
        public ActionResult Create(UserMasterModel model)
        {
            try
            {
                var userMaster = new UserMasterModel()
                {
                    UserCodetxt = model.UserCodetxt,
                    UserNametxt = model.UserNametxt,
                    UserTypetxt = model.UserTypetxt,
                    Divisionvtxt = model.Divisionvtxt,
                    Mobilevtxt = model.Mobilevtxt,
                    ParentCodevtxt = model.ParentCodevtxt,
                    Emailvtxt = model.Emailvtxt,
                    IsActivebit = model.IsActivebit,
                    Passwordvtxt = Encrypttxt(model.Passwordvtxt),
                    CreatedByint = 1,
                    CreatedDatedatetime = DateTime.Now,
                    ModifyByint = 1,
                    ModifyDatedatetime = DateTime.Now
                };

                return Ok(_userMasterService.Create(userMaster));

            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest();
            }


        }



    }
}
