using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Athletics.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly INewsRepository newsRepository;

        public SearchController(INewsRepository newsRepository)
        {
            this.newsRepository = newsRepository;
        }

        public IActionResult Index(string query)
        {
            var news = newsRepository.GetAllByTag(query);
                
            return View(news);
        }
    }
}
 