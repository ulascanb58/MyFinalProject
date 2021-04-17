using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace BusinessLayer.Abstract
{
   public interface IProductService
   {
       List<Product> GetAll();

   }
}
