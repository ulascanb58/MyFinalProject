using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;

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

         public List<Product> GetAllByCategoryId(int id)
         {
             return _productDal.GetAll(p => p.CategoryId == id);
         }

         public List<Product> GetByUnitPrice(decimal min, decimal max)
         {
             return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
         }

         public List<ProductDetailDto> GetProductDetails()
         {
             return _productDal.GetProductDetails();
         }
     }
}
