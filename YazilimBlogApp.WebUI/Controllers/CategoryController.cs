using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YazilimBlogApp.BusinessLayer.Abstract;
using YazilimBlogApp.Entities;

namespace YazilimBlogApp.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List() => View(_categoryService.GetAll());
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Category entity)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Add(entity);
                return RedirectToAction("List");
            }
            return View(entity);
        }

        public IActionResult Edit(int id) => View(_categoryService.GetById(id));
        [HttpPost]
        public IActionResult Edit(Category entity)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Update(entity);
                return RedirectToAction("List");
            }
            else
            {
                return View(entity);
            }
        }

        public IActionResult Delete(Category entity)
        {
            _categoryService.Delete(_categoryService.GetById(entity.Id));
            return RedirectToAction("List");
        }
            
      
    }
}