﻿using YazilimBlogApp.Core.DataAccess.EntityFramework;
using YazilimBlogApp.DataAccessLayer.Abstract;
using YazilimBlogApp.Entities.Concrete;

namespace YazilimBlogApp.DataAccessLayer.Concrete.EfCore.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, YazilimBlogDbContext>, ICategoryDal
    {    
    }
}
