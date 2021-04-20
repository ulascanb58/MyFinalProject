using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.DTOs;

namespace DataAccessLayer.Abstract
{
    public interface IProductDAL:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();


    }
}
