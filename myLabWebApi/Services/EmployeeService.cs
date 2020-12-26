using myLabWebApi.Interface;
using myLabWebApi.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace myLabWebApi.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IConfiguration _config;
        private readonly IMyLabHelper _MyLabHelper;
        private readonly ILogger _ILogger;

        public EmployeeService(IMyLabHelper MyLabHelper, ILogger ILoggerservice, IConfiguration config)
        {
            _config = config;
            _ILogger = ILoggerservice;
            _MyLabHelper = MyLabHelper;
        }

        public List<EmployeeModel> GetAllEmployeeDetails()
        {
            var dbPara = new DynamicParameters();
            var data = _MyLabHelper.GetAll<EmployeeModel>("[dbo].[SP_GetEmployeeDetails]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }

        public List<DoctorModel> GetAllDoctorDetails()
        {
            var dbPara = new DynamicParameters();
            var data = _MyLabHelper.GetAll<DoctorModel>("[dbo].[SP_GetDoctorDetails]", dbPara, commandType: CommandType.StoredProcedure);
            return data.ToList();
        }
    }
}
