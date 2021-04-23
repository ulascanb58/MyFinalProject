﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    
        public class ErrorDataResult<T> : DataResult<T>
        {
            // Data + mesaj
            public ErrorDataResult(T data, string message) : base(data, false, message)
            {

            }

            //Data 
            public ErrorDataResult(T data) : base(data, false)
            {

            }

            //Mesaj
            public ErrorDataResult(string message) : base(default, false, message)
            {

            }
            //direkt FALSE
            public ErrorDataResult() : base(default, false)
            {

            }
        }

    
}
