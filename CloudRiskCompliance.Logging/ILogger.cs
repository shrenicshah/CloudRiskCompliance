using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudRiskCompliance.Logging
{
    public interface ILogger
    {
        void Log(string message);
        void Log(Exception ex);

        //void Info(Exception exception);
        //void Info(Exception exception, string format, params object[] args);
    }
}
