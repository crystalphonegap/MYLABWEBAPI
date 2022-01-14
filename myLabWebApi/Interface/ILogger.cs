using System;

namespace myLabWebApi.Interface
{
    public interface ILogger
    {
        void Log(Exception exception);

        void LogToDB(string log);
    }
}