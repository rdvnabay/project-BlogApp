using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using YazilimBlogApp.Entities.Concrete;

namespace YazilimBlogApp.DataAccessLayer.Concrete.EfCore.EntityFramework
{
    public class YazilimBlogDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-T7I39GU; Database=YazilimBlogAppDb; Trusted_Connection=true");
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
    }

}
