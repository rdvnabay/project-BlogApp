using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YazilimBlogApp.BusinessLayer.Abstract;
using YazilimBlogApp.WebUI.ViewModels;

namespace YazilimBlogApp.WebUI.ViewComponents
{
    public class CategoryMenuRight:ViewComponent
    {
        private ICategoryService _categoryService;
        private IBlogService _blogService;
        public CategoryMenuRight(ICategoryService categoryService, IBlogService blogService)
        {
            _categoryService = categoryService;
            _blogService = blogService;
        }
        public IViewComponentResult Invoke()
        {
            var model = new BlogCategoryViewModel()
            {
                Categories = _categoryService.GetAll().Data,
                CountCategory = _blogService.GetAll().Data.Where(x => x.CategoryId == 0).Count()
            };     
            return View(model);
        }
    }
}
