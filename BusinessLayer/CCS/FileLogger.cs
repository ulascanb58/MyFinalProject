using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.CCS
{
    public class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı");
        }
    }
}
