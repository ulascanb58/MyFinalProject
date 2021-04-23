using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result :IResult
    {

        //:this(success) Success'in set etme işlemini tamamlar
        //c# ta this kullanımı class'ın kendisini kast eder yani burda Result class'ını kast ediyor

        public Result(bool success, string message):this(success)
        {
            Message = message;
            
        }

        public Result(bool success)
        {
            
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; }
    }
}
