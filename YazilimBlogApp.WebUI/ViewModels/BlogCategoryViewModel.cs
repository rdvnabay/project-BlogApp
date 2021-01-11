using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YazilimBlogApp.Entities;

namespace YazilimBlogApp.WebUI.ViewModels
{
    public class BlogCategoryViewModel
    {
        public Blog Blog { get; set; }
        public int CountCategory { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Category> Categories { get; set; }
   
    }
}
