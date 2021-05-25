using Core.Utilities.Results;
using System.Collections.Generic;
using YazilimBlogApp.Entities.Concrete;

namespace YazilimBlogApp.BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        IDataResult<IEnumerable<Category>> GetAll();
        IDataResult<Category>GetById(int id);
        IResult Add(Category category);
        IResult Update(Category category);
        IResult Delete(Category category);
    }
}
