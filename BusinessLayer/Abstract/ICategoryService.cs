using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace BusinessLayer.Abstract
{
    interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int categoryId);
    }
}
