using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using YazilimBlogApp.Entities;

namespace YazilimBlogApp.DataAccessLayer.Concrete.EfCore
{
    public class YazilimBlogContext : DbContext
    {
        public YazilimBlogContext(DbContextOptions<YazilimBlogContext> options) : base(options)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}