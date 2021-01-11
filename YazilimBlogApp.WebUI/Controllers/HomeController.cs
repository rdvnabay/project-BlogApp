using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YazilimBlogApp.BusinessLayer.Abstract;
using YazilimBlogApp.WebUI.ViewModels;

namespace YazilimBlogApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IBlogService _blogService;
        private ICategoryService _categoryService;
        public HomeController(IBlogService blogService, ICategoryService categoryService)
        {
            _blogService = blogService;
            _categoryService = categoryService;
        }
        public IActionResult Index(int id,string search)
        {
            if (!string.IsNullOrEmpty(search))
            {
                var querySearch = _blogService.GetAll().Where(x => x.Title.Contains(search));
                return View(querySearch);
            }
            //BlogsCategoryViewModel model = new BlogsCategoryViewModel();
            //model.Blogs = _blogService.GetAll();
           
            return View(_blogService.GetAll().Where(x=>x.IsHome && x.IsApproved));
        }

        public IActionResult Category(int id)
        {
            return View(_blogService.GetAll().Where(x => x.CategoryId == id && x.IsApproved));
        }

        public IActionResult Details(int id)
        {
            return View(_blogService.GetById(id));
        }
    }
}