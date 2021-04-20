using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework
{
    //NuGet > Data access içerisinde entity framework kodu yazılabilir.
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDAL
    {

    }
}
