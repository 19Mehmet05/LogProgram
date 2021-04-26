using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogWebApi
{
    
     public static class LLog
    {
     public static  Logger logger = LogManager.GetLogger("databaseLogger");
    
    }
}
