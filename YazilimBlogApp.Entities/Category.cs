using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YazilimBlogApp.Entities
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Kategori adı alanı boş geçilemez!")]
        public string Name { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
