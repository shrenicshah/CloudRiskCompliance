using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using NLog;
using NLog.Config;

namespace CloudRiskCompliance.Logging
{
    public class NLogLogger : ILogger
    {
        private Logger _logger;

        public NLogLogger(string currentClassName)
        {
            _logger = LogManager.GetLogger(currentClassName);
        }

        public void Log(string message)
        {
            _logger.Info(message);
        }

        public void Log(Exception ex)
        {
            _logger.Error(ex);
        }    
    }
}