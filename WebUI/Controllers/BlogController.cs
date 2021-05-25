using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using YazilimBlogApp.BusinessLayer.Abstract;
using YazilimBlogApp.Entities.Concrete;

namespace YazilimBlogApp.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private IBlogService _blogService;
        private ICategoryService _categoryService;

        public BlogController(IBlogService blogService, ICategoryService categoryService)
        {
            _blogService = blogService;
            _categoryService = categoryService;
        }

        //Methods
        public void ListCategory()
        {
            ViewBag.ListCategory = new SelectList(_categoryService.GetAll().Data, "Id", "Name");
        }

        //Actions
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View(_blogService.GetAll().Data);
        }

        public IActionResult Create()
        {
            ListCategory();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Blog entity,IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                   var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                        entity.Image = file.FileName;
                    }
                }
                _blogService.Add(entity);
                return RedirectToAction("List");
            }
            return View(entity);
        }

        public IActionResult Edit(int id)
        {
            ListCategory();
            return View(_blogService.GetById(id).Data);
        }

        [HttpPost]
        public IActionResult Edit(Blog entity)
        {
            if (ModelState.IsValid)
            {
                _blogService.Update(entity);
                return RedirectToAction("List");
            }
            else
            {
                return View(entity);
            }  
        }

        public IActionResult Delete(Blog entity)
        {
            _blogService.Delete(_blogService.GetById(entity.Id).Data);
            return RedirectToAction("List");
        }

        public IActionResult Details(int id)
        {
            return View(_blogService.GetById(id).Data);
        }
    }
}   