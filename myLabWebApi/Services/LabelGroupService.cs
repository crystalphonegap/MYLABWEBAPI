using Dapper;
using Microsoft.Extensions.Configuration;
using myLabWebApi.Interface;
using myLabWebApi.Models;
using myLabWebApi.Models.New;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
namespace myLabWebApi.Services
{
    public class LabelGroupService : ILabelGroupService
    {

        private readonly IConfiguration _config;
        private readonly IMyLabHelper _MyLabHelper;
        private readonly ILogger _ILogger;

        public LabelGroupService(IMyLabHelper MyLabHelper, ILogger ILoggerservice, IConfiguration config)
        {
            _config = config;
            _ILogger = ILoggerservice;
            _MyLabHelper = MyLabHelper;
        }
        public long InsertUpdateLabelGroupMaster(LabelGroupMaster LabelGroupMaster)
        {
            return 0;
        }
    }
}
