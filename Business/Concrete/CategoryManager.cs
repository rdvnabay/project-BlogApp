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
        public void Add(Category entity)
        {
            _categoryDal.Add(entity);
        }

        public void Delete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public IEnumerable<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(c=>c.Id==id);
        }

        public void Update(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
