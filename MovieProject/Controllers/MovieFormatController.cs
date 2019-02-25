using MovieProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieProject.Controllers
{
    public class MovieFormatController : Controller
    {
        // GET: MovieFormat
        public ActionResult Index()
        {
            var model = new MovieFormatViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(MovieFormatViewModel model)
        {

            return View();
        }
    }
}