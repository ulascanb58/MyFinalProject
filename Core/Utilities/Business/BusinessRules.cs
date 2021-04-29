using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)// bunları array'in içine atar //List<IResult> logics
        {
            // parametre göndermiş olduğumuz iş kurallarını business'e haber ederiz.
            foreach(var logic in logics)
            {
                if(!logic.Success==true)
                {
                    return logic;
                }
            }

            return null;
        }
    }
}
