using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace TestingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = LogManager.GetLogger("default");
            var logEventInfo = new LogEventInfo(LogLevel.Info, logger.Name, "this is a test");
            logEventInfo.Properties["Person"] = new { Name = "Peter", Age = 34 };
            logEventInfo.Properties["Pet"] = new { NickName = "whiskers", Kind = "Cat", Color = "Black" };

            logger.Log(logEventInfo);

            Console.WriteLine("Information logged");
        }
    }
}
