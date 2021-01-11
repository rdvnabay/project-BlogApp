using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YazilimBlogApp.DataAccessLayer.Abstract;
using YazilimBlogApp.Entities;

namespace YazilimBlogApp.DataAccessLayer.Concrete.EfCore
{
    public class EFBlogDal : IBlogDal
    {
        private YazilimBlogContext _context;
        public EFBlogDal(YazilimBlogContext context)
        {
            _context = context;
        }
        public void Add(Blog entity)
        {
            _context.Blogs.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Blog entity)
        {
            _context.Blogs.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<Blog> GetAll()
        {
            return _context.Blogs;
        }

        public Blog GetById(int id)
        {
            return _context.Blogs.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Blog entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
