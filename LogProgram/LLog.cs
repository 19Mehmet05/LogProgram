using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogProgram
{
    
     public static class LLog
    {
      static  Logger logger = LogManager.GetLogger("databaseLogger");
        public static void Error(string error ,Exception ex)
        {
            logger.ErrorException(error, ex);
        }
        public static void Info(string message)
        {
            logger.Info(message);
        }
        public static void Warn(string message)
        {
            logger.Warn(message);
        }
    }
}
