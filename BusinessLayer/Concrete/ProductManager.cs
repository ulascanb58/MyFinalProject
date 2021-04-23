using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Abstract;
using Core.Utilities.Results;
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

         public IResult Add(Product product)
         {
             
             if (product.ProductName.Length < 2)
             {
                 return new ErrorResult("Ürün ismi en az iki karakter olmalıdır");

             }
             _productDal.Add(product);
            return  new SuccessResult("Ürün eklendi");
         }

         public Product GetById(int productId)
         {
             return  _productDal.Get(p=>p.ProductId==productId)
         }
     }
}
