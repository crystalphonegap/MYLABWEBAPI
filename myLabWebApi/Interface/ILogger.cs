﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  myLabWebApi.Interface
{
    public interface ILogger
    {
        void Log(Exception exception);
        void LogToDB(string log);
    }
}
