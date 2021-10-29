using Microsoft.AspNetCore.Mvc;
using myLabWebApi.Interface;
using myLabWebApi.Models;
using myLabWebApi.Models.New;
using System;


namespace myLabWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PaymentModeController : Controller
    {
        private readonly ILogger _ILogger;
        private readonly IPaymentModeService _IPaymentMode;

        public PaymentModeController(ILogger ILoggerservice, IPaymentModeService IPaymentMode)
        {
            _ILogger = ILoggerservice;
            _IPaymentMode = IPaymentMode;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet("GetAllPaymentMode")]
        public IActionResult GetAllPaymentMode()
        {
            try
            {
                return Ok(_IPaymentMode.GetAllPaymentMode());
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }
    }


}
