using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YazilimBlogApp.BusinessLayer.Abstract;

namespace YazilimBlogApp.WebUI.ViewComponents
{
    public class SearchBlog:ViewComponent
    {
        private IBlogService _blogService;
        public SearchBlog(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke(string search)
        {
            var querySearch = _blogService.GetAll().Where(x => x.Title.Contains(search));
            return View(querySearch);
        }
    }
}
