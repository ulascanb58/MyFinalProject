﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
   public class EfCategoryDal:EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDAL
    {
       
    }
}
