using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YazilimBlogApp.Core.DataAccess.EntityFramework;
using YazilimBlogApp.DataAccessLayer.Abstract;
using YazilimBlogApp.Entities.Concrete;

namespace YazilimBlogApp.DataAccessLayer.Concrete.EfCore.EntityFramework
{
    public class EFCategoryDal : EfEntityRepositoryBase<Category, YazilimBlogDbContext>, ICategoryDal
    {    
    }
}
