using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YazilimBlogApp.BusinessLayer.Abstract;

namespace YazilimBlogApp.WebUI.ViewComponents
{
    public class GetCategoryName:ViewComponent
    {
        private ICategoryService _categoryService;
        public GetCategoryName(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke(int id)
        {
            return View(_categoryService.GetById(id));
        }
    }
}
