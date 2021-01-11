using System;
using System.Collections.Generic;
using System.Text;
using YazilimBlogApp.Entities;

namespace YazilimBlogApp.DataAccessLayer.Abstract
{
    public interface IBlogDal:IRepository<Blog>
    {
    }
}
