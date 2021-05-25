using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;
using YazilimBlogApp.BusinessLayer.Abstract;
using YazilimBlogApp.DataAccessLayer.Abstract;
using YazilimBlogApp.Entities.Concrete;

namespace YazilimBlogApp.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public IResult Add(Category entity)
        {
            _categoryDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Category entity)
        {
            _categoryDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<IEnumerable<Category>> GetAll()
        { 
            var data = _categoryDal.GetAll();
            return new SuccessDataResult<IEnumerable<Category>>(data);
        }

        public IDataResult<Category> GetById(int id)
        {
            var data= _categoryDal.Get(c => c.Id == id);
            return new SuccessDataResult<Category>(data);
        }

        public IResult Update(Category entity)
        {
            _categoryDal.Update(entity);
            return new SuccessResult();
        }
    }
}
