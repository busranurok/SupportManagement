﻿using System;
namespace Core.CrossCuttingConcerns.Logging.Log4Net.Loggers
{
    public class DatabaseLogger : LoggerServiceBase
    {
        public DatabaseLogger() :base(name: "DatabaseLogger")
        {
        }
    }
}
