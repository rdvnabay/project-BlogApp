using System;
using System.Collections.Generic;
using System.Text;
using YazilimBlogApp.Entities.Concrete;

namespace YazilimBlogApp.BusinessLayer.Abstract
{
    public interface ICategoryService:IRepositoryService<Category>
    {
    }
}
