using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult // Data + mesaj getirir
    {
        T Data { get; }
    }
}
