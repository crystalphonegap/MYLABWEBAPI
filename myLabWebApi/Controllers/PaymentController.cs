using Microsoft.AspNetCore.Mvc;
using myLabWebApi.Interface;
using myLabWebApi.Models;
using myLabWebApi.Models.New;
using myLabWebApi.Models.RequestModel;
using System;


namespace myLabWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PaymentController : Controller
    {
        private readonly ILogger _ILogger;
        private readonly IPaymentService _IPaymentService;

        public PaymentController(ILogger ILoggerservice, IPaymentService IPaymentService)
        {
            _ILogger = ILoggerservice;
            _IPaymentService = IPaymentService;
        }

        [HttpPost("GetPaymentList")]
        public IActionResult GetPaymentList(PaymentListModel model)
        {
            try
            {
                return Ok(_IPaymentService.GetPaymentList(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        [HttpPost("AddPayment")]
        public IActionResult AddPayment(AmountPaidModel model)
        {
            try
            {
                return Ok(_IPaymentService.AddPayment(model));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        } 

        [HttpGet("GetPaymentHistory")]
        public IActionResult GetPaymentHistory(int Id)
        {
            try
            {
                return Ok(_IPaymentService.GetPaymentHistory(Id));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

    }
}
