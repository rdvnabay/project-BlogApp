using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;
using YazilimBlogApp.BusinessLayer.Abstract;
using YazilimBlogApp.DataAccessLayer.Abstract;
using YazilimBlogApp.Entities.Concrete;

namespace YazilimBlogApp.BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        private IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        
        public IResult Add(Blog entity)
        {
            _blogDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Blog entity)
        {
            _blogDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<IEnumerable<Blog>> GetAll()
        {
            var data = _blogDal.GetAll();
            return new SuccessDataResult<IEnumerable<Blog>>(data);
        }

        public IDataResult<Blog> GetById(int id)
        {
            var data = _blogDal.Get(b => b.Id == id);
            return new SuccessDataResult<Blog>(data);
        }

        public IResult Update(Blog entity)
        {
            _blogDal.Update(entity);
            return new SuccessResult();
        }
    }
}
