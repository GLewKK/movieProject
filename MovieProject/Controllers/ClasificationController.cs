using MovieProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieProject.Controllers
{
    public class ClasificationController : Controller
    {
        // GET: Clasification
        public ActionResult Index()
        {
            var model = new ClasificationViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(ClasificationViewModel model)
        {

            return View();
        }
    }
}