using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.InMemory;
using Entities.Concrete;

namespace BusinessLayer.Concrete
{
     public class ProductManager:IProductService
     {
         IProductDAL _productDal;

         public ProductManager(IProductDAL productDal)
         {
             _productDal = productDal;
         }

         public List<Product> GetAll()
         {
             return _productDal.GetAll();
         }
    }
}
