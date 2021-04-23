using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{   
    //Temel voidler için başlangıç
    //Bir adet işlem sonucu ve bir adet kullanıcı bilgilendirmek adına mesaj
    public interface IResult
    {
        //Setler yazmak için kullanılır
        bool Success { get; } //Sadece okunabilir
        //Yaptığın işlem başarılı kullanıcıya mesaj ver
        string Message { get; }


    }
}
