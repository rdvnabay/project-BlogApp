using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using YazilimBlogApp.Core;

namespace YazilimBlogApp.Entities.Concrete
{
    public class Blog:IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Başlık alanı boş geçilemez!")]
        public string Title { get; set; }
       
        public string Description { get; set; }
        [Required(ErrorMessage = "İçerik alanı boş geçilemez!")]
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public string Image { get; set; }

        public bool IsHome { get; set; }
        public bool IsApproved { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        


    }
}
