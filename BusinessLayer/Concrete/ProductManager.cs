using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Abstract;
using BusinessLayer.Constants;
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

         public IDataResult<List<Product>> GetAll()
         {
             if (DateTime.Now.Hour == 14)
             {
                 return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
             }
             
             return new  SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductsListed );
         }

         public IDataResult<List<Product>> GetAllByCategoryId(int id)
         {
             return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
         }

         public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
         {
             return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
         }

         public IDataResult<List<ProductDetailDto>> GetProductDetails()
         {
             if (DateTime.Now.Hour == 19)
             {

                return new ErrorDataResult<List<ProductDetailDto>>(Messages.MaintenanceTime);
             
             }
             return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }

        public IResult Add(Product product)
         {
             
             if (product.ProductName.Length < 2)
             {
                 return new ErrorResult(Messages.ProductNameInvalid);

             }
             _productDal.Add(product);
            return  new SuccessResult(Messages.ProductAdded);
         }

         public IDataResult<Product>GetById(int productId)
         {
             return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
         }
     }
}
