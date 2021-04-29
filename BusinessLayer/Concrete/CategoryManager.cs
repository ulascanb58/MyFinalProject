using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Abstract;
using Core.Utilities.Results;
using DataAccessLayer.Abstract;
using Entities.Concrete;

namespace BusinessLayer.Concrete
{
   public class CategoryManager:ICategoryService
   {
        ICategoryDAL _iCategoryDal;

        public CategoryManager(ICategoryDAL categoryDal)
        {
            _iCategoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _iCategoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            return _iCategoryDal.Get(c => c.CategoryId == categoryId);
        }

        IDataResult<List<Category>> ICategoryService.GetAll()
        {
            return new SuccessDataResult<List<Category>>(_iCategoryDal.GetAll());
        }

        IDataResult<Category> ICategoryService.GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_iCategoryDal.Get(c => c.CategoryId == categoryId));
        }
    }
}
