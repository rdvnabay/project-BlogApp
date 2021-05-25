using Core.Utilities.Results;
using System.Collections.Generic;
using YazilimBlogApp.Entities.Concrete;

namespace YazilimBlogApp.BusinessLayer.Abstract
{
    public interface IBlogService
    {
        IDataResult<IEnumerable<Blog>> GetAll();
        IDataResult<Blog> GetById(int id);
        IResult Add(Blog blog);
        IResult Update(Blog blog);
        IResult Delete(Blog blog);
    }
}
