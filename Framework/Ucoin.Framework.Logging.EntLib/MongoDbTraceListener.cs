﻿using Microsoft.Practices.EnterpriseLibrary.Logging.TraceListeners;
using Microsoft.Practices.EnterpriseLibrary.Logging.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using System.Diagnostics;
using System;

namespace Ucoin.Framework.Logging.EntLib
{
    [ConfigurationElementType(typeof(CustomTraceListenerData))]
    public class MongoDbTraceListener : CustomTraceListener
    {
        public override void TraceData(TraceEventCache eventCache,
           string source, TraceEventType eventType, int id, object data)
        {
            if (data is LogEntry)
            {                
                this.Write(data as LogEntry);
            }
            //throw new Exception("test");
        }

        public override void Write(object obj)
        {
            //var log = obj as LogEntry;
            //var logService = ServiceLocator.GetService<ILogService>();

            ////TODO : 將LogEntry轉換為相應的MongoDb Log Entity
            //if (log.Categories.Contains(LogCategoryType.AppLog.GetDescription()))
            //{
            //    logService.LogAppInfo(null);
            //}
            //else if (log.Categories.Contains(LogCategoryType.ErrorLog.GetDescription()))
            //{
            //    logService.LogErrorInfo(null);
            //}
            //else if (log.Categories.Contains(LogCategoryType.PerfLog.GetDescription()))
            //{
            //    logService.LogPerfInfo(null);
            //}
        }

        public override void Write(string message)
        {
        }

        public override void WriteLine(string message)
        {
        }
    }
}