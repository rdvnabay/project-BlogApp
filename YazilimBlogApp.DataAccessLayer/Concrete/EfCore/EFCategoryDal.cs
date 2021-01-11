using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YazilimBlogApp.DataAccessLayer.Abstract;
using YazilimBlogApp.Entities;

namespace YazilimBlogApp.DataAccessLayer.Concrete.EfCore
{
    public class EFCategoryDal : ICategoryDal
    {
        private YazilimBlogContext _context;
        public EFCategoryDal(YazilimBlogContext context)
        {
            _context = context;
        }
        public void Add(Category entity)
        {
            _context.Categories.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Category entity)
        {
            _context.Categories.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Categories;
        }

        public Category GetById(int id)
        {
            return _context.Categories.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Category entity)
        {
            _context.Categories.Update(entity);
            _context.SaveChanges();
        }
    }
}
