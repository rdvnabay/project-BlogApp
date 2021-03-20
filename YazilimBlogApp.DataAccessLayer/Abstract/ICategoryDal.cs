using System;
using System.Collections.Generic;
using System.Text;
using YazilimBlogApp.Core.DataAccess;
using YazilimBlogApp.Entities.Concrete;

namespace YazilimBlogApp.DataAccessLayer.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
