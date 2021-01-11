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
            var model = new BlogCategoryViewModel();
            model.Categories = _categoryService.GetAll();
            //model.CountCategory = _blogService.GetAll().Where(x => x.CategoryId == 1).Count();
            return View(_categoryService.GetAll());
        }
    }
}
