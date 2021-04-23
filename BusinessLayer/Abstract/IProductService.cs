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
       List<Product> GetAll();
       //Ürün listesi 
       List<Product> GetAllByCategoryId(int id);

       List<Product> GetByUnitPrice(decimal min, decimal max);

       List<ProductDetailDto> GetProductDetails();

       IResult Add(Product product);

       Product GetById(int productId);
   }
}
