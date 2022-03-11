using Microsoft.AspNetCore.Mvc;
using myLabWebApi.Interface;
using myLabWebApi.Models;
using myLabWebApi.Models.New;
using System;

namespace myLabWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CompanyController : Controller
    {
        private readonly ILogger _ILogger;
        private readonly ICompanyService _companyService;

        public CompanyController(ILogger ILoggerservice, ICompanyService companyService)
        {
            _ILogger = ILoggerservice;
            _companyService = companyService;
        }

        [HttpPost("InsertUpdateCompany")]
        public IActionResult InsertUpdateCompany(CompanyModel m)
        {
            try
            {
                return Ok(_companyService.InsertUpdateCompany(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }

        [HttpPost("GetCompanyList")]
        public IActionResult GetCompanyList(CompanySearchModel m)
        {
            try
            {
                return Ok(_companyService.GetCompanyList(m));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }
        [HttpGet("GetCompanyDetails/{ID}")]
        public IActionResult GetCompanyDetails(int ID)
        {
            try
            {
                return Ok(_companyService.GetCompanyDetails(ID));
            }
            catch (Exception ex)
            {
                _ILogger.Log(ex);
                return BadRequest(ex);
            }
        }
    }
}
