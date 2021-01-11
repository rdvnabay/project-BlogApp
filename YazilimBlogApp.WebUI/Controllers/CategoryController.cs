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
        #region Fields
        private ICategoryService _categoryService;
        #endregion

        #region Constructor
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        #endregion

        //Actions
        #region Index
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region List
        public IActionResult List() => View(_categoryService.GetAll());
        #endregion

        #region Create
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
        #endregion

        #region Edit
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
        #endregion

        #region Delete
        public IActionResult Delete(Category entity)
        {
            _categoryService.Delete(_categoryService.GetById(entity.Id));
            return RedirectToAction("List");
        }
        #endregion
    }
}