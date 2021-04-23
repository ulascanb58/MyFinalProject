using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace BusinessLayer.Abstract
{
   public interface IProductService
   {
       IDataResult<List<Product>> GetAll();
       //Ürün listesi 
       IDataResult<List<Product>> GetAllByCategoryId(int id);

       IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

       IDataResult<List<ProductDetailDto>> GetProductDetails();

       //IResult voidler için kullanılır
       IResult Add(Product product);

       IDataResult<Product> GetById(int productId);
   }
}
