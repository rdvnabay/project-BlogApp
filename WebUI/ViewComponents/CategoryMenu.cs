using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YazilimBlogApp.BusinessLayer.Abstract;

namespace YazilimBlogApp.WebUI.ViewComponents
{
    public class CategoryMenu:ViewComponent
    {
        private ICategoryService _categoryService;
        public CategoryMenu(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {

            ViewBag.ActiveCategory = RouteData.Values["id"];
            return View(_categoryService.GetAll().Data);
        }
    }
   
}
