using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using YazilimBlogApp.BusinessLayer.Abstract;

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

        //Actions
        public IActionResult Index(int id,string search)
        {
            if (!string.IsNullOrEmpty(search))
            {
                var querySearch = _blogService.GetAll().Data.Where(x => x.Title.Contains(search));
                return View(querySearch);
            }
            //BlogsCategoryViewModel model = new BlogsCategoryViewModel();
            //model.Blogs = _blogService.GetAll();
           
            return View(_blogService.GetAll().Data.Where(x=>x.IsHome && x.IsApproved));
        }
        public IActionResult Category(int id)
        {
            return View(_blogService.GetAll().Data.Where(x => x.CategoryId == id && x.IsApproved));
        }

        public IActionResult Details(int id)
        {
            return View(_blogService.GetById(id).Data);
        }
    }
}