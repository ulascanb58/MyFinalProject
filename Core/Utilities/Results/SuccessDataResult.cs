using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public class SuccessDataResult<T>:DataResult<T>
    {
        // Data + mesaj
        public SuccessDataResult(T data, string message):base(data,true,message)
        {
            
        }

        //Data 
        public SuccessDataResult(T data):base(data,true)
        {
            
        }

        //Mesaj
        public SuccessDataResult(string message) : base(default, true, message)
        {

        }
        //direkt true 
        public SuccessDataResult() : base(default, true)
        {

        }
    }
}
